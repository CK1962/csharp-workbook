﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello method
            // hello();
            // Addition();
            // CatDog();
            // OddEvent();
            //inches();
            echo(();
        }
        public static void hello()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Bye " + name);
            Console.ReadLine();
        }
        public static void Addition()
        {
            Console.WriteLine("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("The sum is " + sum);
            Console.ReadLine();
        }
        public static void CatDog()
        {
            Console.WriteLine("Do you prefer Cat or Dog? ");
            string choice = Console.ReadLine();
            if (choice == "dog" || choice == "dogs")
            {
                Console.WriteLine("Bark!");
            }
            else if (choice == "cat" || choice == "cats")
            {
                Console.WriteLine("Meow!");
            }
            Console.ReadLine();
        }

        public static void OddEvent()
        {
            Console.WriteLine("Please write your number: ");
            int num3 = int.Parse(Console.ReadLine());
            if (num3 % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.ReadLine();
        }

        public static void inches()
        {
            Console.WriteLine("Please enter your height to the nearest foot: ");
            int num4 = int.Parse(Console.ReadLine());
            int product = num4 * 12;
            Console.WriteLine("You are approximately " + product + " inches tall");
            Console.ReadLine();
        }

        public static void echo()
        {
            Console.WriteLine("Please enter your favorite word: ");
            string name echo = Console.ReadLine();
        }
    }
}