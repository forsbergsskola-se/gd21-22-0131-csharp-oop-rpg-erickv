public class Unit
{
    public string name;
    public int id;
    public static int nextId;

    public Unit(string name)
    {
        this.name = name;
        id = nextId++;
        ReportStatus();
    }

    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{id}: {name}");
    }
}

static class Program
{
    static void Main()
    {
        Unit zombie = new Unit("Warrior");
        Unit Wolf = new Unit("Wolf");
        Unit Wizard = new Unit("Wizard");
    }
}
