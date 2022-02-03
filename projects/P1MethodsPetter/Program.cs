namespace Methods
{
    class Program
    {
        static void Main()
        {
            CountUp();
            CountDown();
            CountUp();
            CountDown();
        }
        static void CountUp()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void CountDown()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    
    
}
