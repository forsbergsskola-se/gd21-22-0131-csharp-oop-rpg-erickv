namespace Methods
{
 class Program
 {
  static void Main()
  {
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

  static void Count(int a, int b)
  {
   if (a < b)
   {
    Console.WriteLine($"Counting from {a} to {b}");
    for (int i = a; i <= b; i++)
    {
     Console.WriteLine(i);
    }
   }
   else
   {
    Console.WriteLine($"Counting from {a} to {b}");
    for (int i = a; i >= b; i--)
    {
     Console.WriteLine(i);
    }
   }
   
  }
 }
}


