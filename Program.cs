using System;

namespace Reference_types_and_Value_Types
{

    //Second part of the lesson below including the class and methods made below
    public class Person
    {
        public int Age;
    }
    public class Program
    {
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(String.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] {1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(String.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            //Second part of the lesson below including the class and methods made above

            var number = 1;
            Increment(number); // Number will still be one since its in the main method and seen as different from the number in the Increment method
            Console.WriteLine(number);

            var person = new Person() { Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age); // reference type so age will increase

         
        }
    }
}
