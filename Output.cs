using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSB
{
    class Output
    {
        static void Main(String[] args)
        {
            Console.Write("Hey");
            Console.WriteLine("Hello");

            //This is comment
            /*
             * This
             * is
             * a
             * multiline
             * comment
             */

            Console.WriteLine("\tDon");

            Console.ReadKey();
        }
    }

    class Variables
    {
        static void Main(string[] args)
        {
            int x; // declaration
            x = 123; // initialization
            int z = 3;
            int result = x + z;
            double height = 1.70d; // dec number with some precision
            bool isOn = false;
            char symbol = '@'; // beware the single quotes!
            String name = "Tom"; // Strings use double quotes!

            Console.WriteLine("result: " + result);
            Console.WriteLine("height: " + height);
            Console.WriteLine(height);
        }
    }

    class Constants
    {
        static void Main(String[] args)
        {
            // constants = immutable values which are always known at compile time
            //             and cannot change during the life of the programm

            double PI = Math.PI;
            Console.WriteLine(PI);
            Console.ReadKey();
        }
    }

    class TypeCasting
    {
        static void Main(String[] args)
        {
            // type casting = converting a value to a different data type

            double a = 3.14;
            int b = Convert.ToInt32(a); // if we convert from double to int, it will truncate any decimal portion

            Console.WriteLine(b);
            Console.WriteLine(a.GetType());

            Console.ReadKey();
        }
    }

    class UserInput
    {
        static void Main(String[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + age);

            Console.ReadKey();
        }
    }

    class MathClass
    {
        static void Main(String[] args)
        {

            double x = 3; ;
            double y = 3.14;
            double xPow = Math.Pow(x, 2);
            double b = Math.Sqrt(x);
            double c = Math.Abs(x);
            double d = Math.Round(y);

            Console.ReadKey();
        }
    }

    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int num = r.Next(1, 101); // the last number is exclusive
            double numDec = r.NextDouble(); // random number between 0 and 1
            Console.WriteLine(num);

            Console.ReadKey();
        }
    }

    class StringMethods
    {
        static void Main(String[] args)
        {
            String fullName = "Tom Thomas";
            String phoneNumber = "123-456-789";
            phoneNumber = phoneNumber.Replace("-", "/");
            Console.WriteLine(phoneNumber);

            String username = fullName.Insert(0, "@");
            Console.WriteLine(username);

            String firstName = fullName.Substring(0, 3);
            Console.WriteLine(firstName);

            Console.ReadKey();
        }
    }
}
