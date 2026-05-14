using System;
using System.Collections.Generic;
using System.IO;

namespace ArcadeLog
{
    public class ScoreByNameComparer : IComparer<Score>
    {
        public int Compare(Score x, Score y)
        {
            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }
    }
    public class Program
    {
        // Argumento:
        // args[0]: Caminho para o ficheiro (formato "nome pontuação" por linha)
        private static void Main(string[] args)
        {
            // Lê o Ficheiro e Cria os Scores
            List<Score> scores = new List<Score>();

            string[] lines = File.ReadAllLines(args[0]);
            foreach (string line in lines)
            {
                string[] parts = line.Split(" ");
                string name = parts[0];
                int points = int.Parse(parts[1]);
                scores.Add(new Score(name, points));
            }

            // Ordena os Scores
            scores.Sort();

            // Agrupa por Medalha e Imprime (Gold → Silver → Bronze)
            // Escreve a lista no ficheiro ranking.txt
            string[] medalOrder = {"Gold", "Silver", "Bronze"};
            using (StreamWriter writer = new StreamWriter("ranking.txt"))
            {
                foreach (string medal in medalOrder)
                {
                    foreach (Score s in scores)
                    {
                        if (s.Medal == medal)
                        {
                            Console.WriteLine(s);
                            writer.WriteLine(s);
                        }
                    }
                }
            }

            Console.WriteLine("Ranking guardado em 'ranking.txt'.");

            // Ordena por Nome e Escreve em alpha.txt
            scores.Sort(new ScoreByNameComparer());
            using (StreamWriter writer = new StreamWriter("alpha.txt"))
            {
                foreach (Score s in scores)
                    writer.WriteLine(s);
            }

            // Este programa mostra o seguinte no ecrã (exemplo: scores.txt com "Kronos 7400", "Luna 3800", "Rex 520", "Phantom 6100"):
            //
            // Kronos [Gold]: 7400
            // Phantom [Silver]: 6100
            // Luna [Bronze]: 3800
            // Rex [Bronze]: 520
            // Ranking guardado em 'ranking.txt'.
        }
    }
}
