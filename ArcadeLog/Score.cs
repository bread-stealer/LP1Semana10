using System;

namespace ArcadeLog
{
    public class Score : IComparable<Score>
    {
        // Variável de Instância Privada: points (int)
        private int points;

        // Propriedade Auto-Implementada Só de Leitura: Name (string)
        public string Name { get; }

        // Propriedade: Points (int), sempre entre 0 e 9999
        public int Points
        {
            get { return points; }
            set { points = Math.Clamp(value, 0, 9990);}
        }

        // Propriedade Só de Leitura: Medal (string)
        public string Medal
        {
            get
            {
                if (points >= 7000) return "Gold";
                if (points >= 4000) return "Silver";

                return "Bronze";
            }
        }

        // Construtor: aceita nome e pontuação
        public Score(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public int CompareTo(Score other)
        {
            // CÓDIGO AQUI
            return other.Points.CompareTo(this.Points);
        }

        public override string ToString()
        {
            // CÓDIGO AQUI
            return $"{Name} [{Medal}]: {Points}";
        }
    }
}
