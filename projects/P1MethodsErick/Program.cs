namespace Methods
{
    class Program
    {

        static void Main()
        {
            /*for (int to = 1; to <= 3; to++)
            {
                int from = to;
                //CountUP(to);
                //CountDown(to, from);
            }*/
            
            int from = 2;
            int to = 3;
            Count(from, to);
            
            from = 100;
            to = 101;
            Count(from, to);
            
            from = 10;
            to = 8;
            Count(from, to);
            
            from = 1;
            to = -1;
            Count(from, to);
            
            from = 1337;
            to = 1337;
            Count(from, to);


        }
        
       /* static void CountUP(int num1)
        {
            Console.WriteLine($"\nCounting from 0 to {num1}");
            for (int i = 0; i <= num1; i++)
            {
                Console.WriteLine(i);
            }
        }*/

        static void Count(int a, int b)
        {
            if (a<b)
            {
                Console.WriteLine($"\nCounting from {b} to {a}");
                for(int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine($"\nCounting from {a} to {b}");
                for(int i = a; i >= b; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}