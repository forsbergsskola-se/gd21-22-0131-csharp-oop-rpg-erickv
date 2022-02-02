namespace ForLoops
{
    class  Program
    {
        static void Main()
        {
            Console.WriteLine("Loop showing 1-1000.");
            
            for (int i = 1; i <= 1000; i++) 
            {
                Console.WriteLine(i);   
            }
            Console.WriteLine("\nLoop showing 200-100.");
            
            for (int i = 200; i >= 100; i--) 
            {
                Console.WriteLine(i);   
            }
            Console.WriteLine("\nLoop showing 1024, divided by 2, down to 1.");
            
            for (int i = 1024; i >= 1; i= i/2) 
            {
                Console.WriteLine(i);   
            }
        } 
        
    }
}

