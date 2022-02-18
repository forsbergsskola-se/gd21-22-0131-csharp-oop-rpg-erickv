public class Unit
{
    public string name;
    public int id;
    public static int nextId;
    private int maxHealth;
    private int health;

    public Unit(string name, int maxHealth)
    {
        this.name = name;
        id = nextId++;

        this.maxHealth = maxHealth;
        health = maxHealth;
        ReportStatus();
    }

    public void ReportStatus()
    {
        Console.WriteLine($"\nUnit #{id}: {name} | {health}/{maxHealth} Hp\n");
    }

    public int Health
    {
        set
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

        while (leet.Health > 0)
        {
            Console.WriteLine("What do you want Leet's Health to be?");
            leet.Health = int.Parse(Console.ReadLine());
        }
    }
}
