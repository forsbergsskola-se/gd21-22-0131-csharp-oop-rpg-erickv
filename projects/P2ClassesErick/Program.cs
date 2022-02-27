namespace Classes
{
    class Person
    {
        public string name;

        public void IntroduceYourself()
        {
            Console.WriteLine("Hello, my name is: " + name);
        }
    }

    public class Program
    {
        static void Main()
        {
            Person[] personList = new Person[3];

            //Console.WriteLine(Animal.animal);
            //Console.WriteLine(Car.car);
            for (int i = 0; i < personList.Length; i++)
            {
                personList[i] = new Person();
                Console.WriteLine("Give me a name: ");
                personList[i].name = Console.ReadLine();
            }

            foreach (Person person in personList)
            {
                person.IntroduceYourself();
            }
        }
    }
    public class Animal
    {
        public static Animal animal = new Animal();
    }

    public class Car
    {
        public static Car car = new Car();
    }
}