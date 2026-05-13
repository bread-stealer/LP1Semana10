public enum PlayerClass
{
    Tank, Fighter, Slayer, Mage,
    Controller, Marksmen
}

public class Player
{
    public PlayerClass PClass { get; }
    public string Name { get; }

    public Player(PlayerClass pClass, string name)
    {
        PClass = pClass;
        Name = name;
    }

    public override int GetHashCode()
    {
        return PClass.GetHashCode() ^ Name.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        if (obj is Player other)
        {
            return PClass == other.PClass && Name == other.Name;
        }
        return false;
    }
}