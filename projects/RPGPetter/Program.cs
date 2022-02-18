



class Program
{
    class Unit
    {
        private string name;
        private int id;
        
        private static int nextId;
        
        public Unit(string name)
        {
            this.name = name;
            id = nextId;
            nextId++;
            // Make sure, that this is the last line of the constructor
            ReportStatus();
        }

        ~Unit()
        {
            Console.WriteLine("Unit " +id + ": " + name + " got killed.");
        }

        public void ReportStatus()
        {
            Console.WriteLine("Unit " +id +": " +name);
        }
        
        
    }
    
    
    public static void Main()
    {
    Unit orri = new Unit(name: "Órri (Wizard)");
    Unit alfgerdur = new Unit("Alfgérdur (Evil Wizard)");
    Unit princessBianca = new Unit(name: "Princess Bianca");
    
    }
}