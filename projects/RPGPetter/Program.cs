



class Program
{
    class Unit
    {
        private string name;
        private int id;
        private int maxHealth;
        private int health;
        
        
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

        public void SetHealth(int newHealth)
        {
            health = newHealth;
            if (health < 0)
            {
                health = 0;
            }

            if (health > maxHealth)
            {
                health = maxHealth;
            }
            ReportStatus();
        }

    }
    
    
    public static void Main()
    {
  /*  Unit orri = new Unit(name: "Órri (Wizard)", 100);
    Unit alfgerdur = new Unit("Alfgérdur (Evil Wizard)",500);
    Unit princessBianca = new Unit(name: "Princess Bianca",30);
    */
  Unit evilReceptionist = new Unit("Evil Receptionist", 30);

  for (int i = 0; i <3; i++)
  {
      Console.WriteLine("What value do you want to give Evil Receptionist?");
      int newHealth = Int32.Parse(Console.ReadLine());
      evilReceptionist.SetHealth(newHealth);
  }
  
    }
}