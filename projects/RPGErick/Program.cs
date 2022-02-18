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

    public void SetHealth(int newHealth)
    {
        health = Math.Clamp(newHealth, 0, maxHealth);
        ReportStatus();
    }
}

static class Program
{
    static void Main()
    {
        Unit leet = new Unit("Leet", 1337);

        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine("What do you want Leet's Health to be?");
            leet.SetHealth(int.Parse(Console.ReadLine()));
        }
    }
}
