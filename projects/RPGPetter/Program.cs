



class Program
{
    class Unit
    {
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
            get
            {
                return health;
            }
            private set
            {
                health = Math.Clamp(value, 0, maxHealth);
                ReportStatus();
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

        public void Damage(int value)
        {
            Health = Health - value;
        }
    }
    
    public static void Main()
    {
        Unit evilReceptionist = new Unit("Evil Receptionist", 30);
        while (evilReceptionist.IsAlive)
        {
            Console.WriteLine("What damage do you want to make to " +evilReceptionist.Name +"?");
            int value = Int32.Parse(Console.ReadLine());
            evilReceptionist.Damage(value);
        }
    }
}