namespace Classes
{
    class Person
    {
        static Person person = new Person();
        private static string[] name = new string [3];

        static void IntroduceYourself(int pos)
        {
            Console.WriteLine("Hello, my name is: " + name[pos]);
        }
        static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Give me a name: ");
                name[i] = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)
            {
                IntroduceYourself(i);
            }
        }
    }

    class Animal
    {
        public static Animal animal = new Animal();
    }

    class Car
    {
        public static Car car = new Car();
    }
}