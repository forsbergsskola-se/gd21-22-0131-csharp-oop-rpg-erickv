namespace ReturnType
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Which Fibonacci Number do you want? ");
            int pos = Convert.ToInt32(Console.ReadLine());
            int result = Fibonacci(pos);
            Console.WriteLine($"Fibonacci Number {pos} has the value: {result}");
        }

       static int Fibonacci(int position)
       {
           int a = 0;
           int b = 1;
            for (int i = 0; i < position; i++)
            {
                int temp = a;
                a = b;
                b += temp;
            }
            return a;
        }
    }
}