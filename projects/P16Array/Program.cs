namespace Array
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            
            int[] array = new int[11];
            
                for (int i = 0; i < 10000; i++)
                {
                    int index = random.Next(0, 11);
                    array[index]++;
                }
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"You got the number {i} {array[i]} times" );   
            }
        }
    }
}

