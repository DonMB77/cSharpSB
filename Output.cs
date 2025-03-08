using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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
            int age = 23;
            phoneNumber = phoneNumber.Replace("-", "/");
            Console.WriteLine(phoneNumber);

            String username = fullName.Insert(0, "@");
            Console.WriteLine(username);

            String firstName = fullName.Substring(0, 3); // the last argument is the amount of steps, not index
            Console.WriteLine(firstName);

            String interpolatedString = $"Hello {firstName}. Your full name is {fullName} and you are {age} years old";
            Console.WriteLine(interpolatedString);

            Console.ReadKey();
        }
    }

    class IfStatements
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());


            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }
        }
    }

    class SwitchStatements
    {
        static void Main(String[] args)
        {
            String day = "Monday";

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Today is Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("Today is Tuesday!");
                    break;
                default:
                    Console.WriteLine("Weekday not yet implemented!");
                    break;
            }
        }
    }

    class WhileLoops
    {
        static void Main(String[] args)
        {
            String name = "";

            while (name == "")
            {
                Console.WriteLine("Please enter your name: ");
                name = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }

    class ForLoops
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class ArraysDemo
    {
        static void Main(String[] args)
        {
            String[] cars = { "BMW", "Ford", "Subaru" };
            Console.WriteLine(cars[0]);
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }

    class Methods
    {
        static void Main(string[] args)
        {
            GreetUser("Tom");
            Console.ReadKey();
        }

        static void GreetUser(String name)
        {
            Console.WriteLine("Hello " + name);
        }
    }

    class ParamsKeyword
    {
        static void Main(String[] args)
        {
            // params = a method parameteer that takes a variable number of arguments.
            //          the parameter must be a single dimensional array

            double total1 = CheckOut(3.1, 4.2);
            Console.WriteLine(total1);

            double total2 = CheckOut(3.5, 6.2, 3.8);
            Console.WriteLine(total2);
        }

        static double CheckOut(params double[] pricesTotal)
        {
            double total = 0;
            foreach (double itemPrice in pricesTotal)
            {
                total += itemPrice;
            }
            return total;
        }
    }

    class Exceptions
    {
        // try = try some code that is considered "dangerous"
        // catch = catches and handles exceptions when they occur
        // finally = always executed regardless if exception is caught or not

        static void Main(String[] args)
        {
            int x = 5;
            int y;
            double result;

            try
            {
                Console.WriteLine("Enter number 2:");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input needs to be a number!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You cannot divide by zero!");
            }
            Console.ReadKey();
        }
    }
    class ConditionalOperator
    {
        static void Main(String[] args)
        {
            // used in conditional assignment if a condition is true/false
            // (condition) ? x : y

            double temperature = 20;
            String message;

            message = (temperature >= 15) ? "It is warm outside!" : "It is cool outside";

            Console.ReadKey();
        }
    }

    class MultidimentionalArrays
    {
        static void Main(String[] args)
        {
            String[,] parkinglot = { { "Mustang", "BMW", "Subaru" },
                                     { "Nissan", "Golf", "Ford" } };

            foreach(String item in parkinglot)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < parkinglot.GetLength(0); i++)
            {
                for (int j = 0; j < parkinglot.GetLength(1); j++)
                {
                    Console.Write(parkinglot[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Car
    {
        String make;
        String model;
        int year;
        String color;
        int speed;

        public int Speed
        {
            get { return speed; } //read
            set
            {
                if (value > 500)
                {
                    speed = 500;
                } else
                {
                    speed = value;
                }
            }
        }

        public Car(String make, String model, int year, String color, int speed)
        {

            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            this.Speed = speed;
        }

        public void Drive()
        {
            Console.WriteLine($"You drive the {make} {model}.");
        }
    }

    class Vehicle
    {
        public int speed = 0;
        public void Go()
        {
            Console.WriteLine("Moving!");
        }
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    class DemoProgram
    {
        static void Main(String[] args) 
        {
            Car car1 = new Car("Nissan", "Skyline", 2001, "blue", 200);
            car1.Drive();

            Console.WriteLine(Planets.Earth + " is a planet #" + (int)Planets.Earth);
        }
    }

    enum Planets
    {
        Mercury = 1, Earth = 400, Jupiter
    }
}