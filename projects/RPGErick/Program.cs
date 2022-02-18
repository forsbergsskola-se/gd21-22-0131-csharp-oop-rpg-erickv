public class Unit
{
    public string Name { get; }
    public int id;
    public static int nextId;
    private int maxHealth;
    private int health;

    public bool IsAlive
    {
        get
        {
            if (health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public Unit(string name, int maxHealth)
    {
        Name = name;
        id = nextId++;

        this.maxHealth = maxHealth;
        health = maxHealth;
        ReportStatus();
    }

    public void Damage(int value)
    {
        Health -= value;
    }

    public void ReportStatus()
    {
        Console.WriteLine($"\nUnit #{id}: {Name} | {health}/{maxHealth} Hp\n");
    }

    public int Health
    {
        private set
        {
            health = Math.Clamp(value, 0, maxHealth);
            ReportStatus();
        }
        get
        {
            return health;
        }
    }
    
    /*
    public void SetHealth(int newHealth)
    {
        health = Math.Clamp(newHealth, 0, maxHealth);
        ReportStatus();
    }*/
}

static class Program
{
    static void Main()
    {
        Unit leet = new Unit("Leet", 1337);

        while (leet.IsAlive)
        {
            Console.WriteLine("How much damage you want to deal?");
            leet.Damage(int.Parse(Console.ReadLine()));
        }
    }
}
