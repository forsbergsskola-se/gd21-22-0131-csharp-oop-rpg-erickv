static class SuperMath
{
    public static float Lerp (float from, float to, float t)
    {
        return from + (to - from) * t;
    }
}
class Program
{
    public static void Main()
    {
        Console.WriteLine(SuperMath.Lerp(0,100,0));
    }
}