



class Program
{
    class Unit
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }   
        }
        private int id;
        private int maxHealth;
        private int health;
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
        
        private static int nextId;
        
        public Unit(string name, int maxHealth)
        {
            this.name = name;
            id = nextId;
            nextId++;
            this.maxHealth = maxHealth;
            health = maxHealth;
            // Make sure, that this is the last line of the constructor
            ReportStatus();
        }

        ~Unit()
        {
            Console.WriteLine("Unit " +id + ": " + name + " got killed.");
        }

        public void ReportStatus()
        {
            Console.WriteLine("Unit " +id +": " +name +" - " +health +"/" +maxHealth);
        }
    }
    
    
    public static void Main()
    {

        Unit evilReceptionist = new Unit("Evil Receptionist", 30);
        while (evilReceptionist.Health > 0)
        {
           
            Console.WriteLine("What value do you want to give Evil Receptionist?");
            int newHealth = Int32.Parse(Console.ReadLine());
            evilReceptionist.Health = newHealth; 
        }
    }
}