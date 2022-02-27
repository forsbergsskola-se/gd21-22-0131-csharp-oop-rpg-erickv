

class Animal
{
            
}

class Car
{
            
}
class Program
{
    class Person
    {
       public string name;
   
        public void IntroduceYourself()
        {
            Console.WriteLine("Your name is " + name +".");
       
        }
    }
    
    public static void Main()
    {

      /* Testing:
       Person chinese;
        chinese = new Person();
        chinese.name = "Chang";
        chinese.IntroduceYourself();

        Person italian;
        italian = new Person();
        italian.name = "Giorginio";
        italian.IntroduceYourself(); */


        Person [] people;
        people = new Person [3];
        for (int i = 0; i <= people.Length - 1; i++)
        {
            people[i] = new Person();
            Console.WriteLine("Write a name.");
            people[i].name = Console.ReadLine();
        }
        
        /*
        people[0].name = "Anders";
       people[1].name = "Peder";
       people[2].name = "Ulf"; */

        for (int i = 0; i <= people.Length - 1; i++)
        {
            Person currentPerson = people[i];
            currentPerson.IntroduceYourself();
        }


        /*   Animal dog;
           dog = new Animal();
   
           Car volvo;
           volvo = new Car();
           
           Console.WriteLine(chinese);
           Console.WriteLine(dog);
           Console.WriteLine(volvo);
           */

    }
}