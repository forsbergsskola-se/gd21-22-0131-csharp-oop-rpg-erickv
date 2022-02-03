namespace Methods
{
    class Program
    {
        static void Main()
        {
            CountUP();
            CountDown();
            CountUP();
            CountDown();
        }
        static void CountUP()
        {
            Console.WriteLine("\nCounting from 0 to 5");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void CountDown()
        {
            Console.WriteLine("\nCounting from 5 to 0");
            for(int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}