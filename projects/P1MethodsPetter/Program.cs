namespace Methods
{
 class Program
 {
  static void Main()
  {
   int to = 1;
   CountUp(to);
   int from = 1;
   CountDown(from);
   to = 2;
   CountUp(to);
   from = 2;
   CountDown(from);
   to = 3;
   CountUp(to);
   from = 3;
   CountDown(from);
  }

  static void CountUp(int a)
  {
   for (int i = 0; i <= a; i++)
   {
    Console.WriteLine(i);
   }
  }
  static void CountDown(int b)
  {
   for (int i = b; i >= 0; i--)
   {
    Console.WriteLine(i);
   }
  }
 }
}


