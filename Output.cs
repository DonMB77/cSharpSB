﻿using System;
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
}
