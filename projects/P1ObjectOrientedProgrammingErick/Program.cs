namespace ObjectOrienteProgramming
{
    class Programm
    {
        static void Main()
        {
            string[] name = new string[3];
            for (int i = 0; i < 3; i++)
            {
                name[i] = GetNames();
            }
            Console.WriteLine($"\n{name[0]}, {name[1]}, {name[2]}");
        }

        static string GetNames()
        {
            Console.WriteLine("Give me a name.");
            string names = Console.ReadLine();
            return names;
        }
    }
}