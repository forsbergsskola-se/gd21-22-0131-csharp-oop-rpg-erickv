namespace Methods
{
    class Program
    {

        static void Main()
        {
            for (int to = 1; to <= 3; to++)
            {
                int from = to;
                CountUP(to);
                CountDown(from);
            }
            
        }
        static void CountUP(int num1)
        {
            Console.WriteLine($"\nCounting from 0 to {num1}");
            for (int i = 0; i <= num1; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void CountDown(int num2)
        {
            Console.WriteLine($"\nCounting from {num2} to 0");
            for(int i = num2; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}