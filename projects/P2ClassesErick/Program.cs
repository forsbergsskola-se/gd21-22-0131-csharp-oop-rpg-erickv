namespace Classes
{
    class Person
    {
        static Person person = new Person();

        static void Main()
        {
            Console.WriteLine(person);
            Console.WriteLine(Animal.animal);
            Console.WriteLine(Car.car);
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