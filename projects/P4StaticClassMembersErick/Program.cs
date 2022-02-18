static class SuperMath
{
    public static float Lerp(float from, float to, float t)
    {
        return from + (to - from) * t;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(SuperMath.Lerp(100, 200, 0.5f));
    }
}
