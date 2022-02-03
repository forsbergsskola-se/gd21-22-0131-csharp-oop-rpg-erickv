namespace ReturnType
{
    class Program
    {
        static int next = 0;
        static int prev = 0;
        static void Main()
        {
            
            Console.Write("Which Fibonacci Number do you want? ");
            int pos = Convert.ToInt32(Console.ReadLine());
            double result = Fibonacci(pos);
            Console.WriteLine(result);
        }

       static int Fibonacci(int position)
        {
            for (int i = 0; i < position; i++)
            {
                if (next == 0)
                {
                    next = 1;
                }
                else
                {
                    int temp = next;
                    next = next + prev;
                    prev = temp;
                }
            }
            return next;
        }
    }
}