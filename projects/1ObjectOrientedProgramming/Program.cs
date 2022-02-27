namespace ObjectOrientedProgramming
{
    class Program
    {
        public static void Main()
        {
            string[] names = new string[3];
            /*
             names[0] = 
             names[1] = 
            names[2] =
            */
            for (int i = 0; i < names.Length; i++)
            {
              Console.WriteLine("Give me a name.");
              names[i] = Console.ReadLine();
            }
            for (int i = 0; i < names.Length; i++)
            {
                /* Alternative 1:
                if (i == 0 || i == 1)
                {
                    Console.Write(names[i] + ", ");
                }
                else
                {
                    Console.Write(names[i] + ".");
                }
                */
                
                //Alternative 2:
                /* if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(names[i]); */
                
                //Alternative 3
                Console.Write(names[i]);
               if(i < names.Length-1)
               {
                   Console.Write(", ");
               }
                
            }
        }
    }
}