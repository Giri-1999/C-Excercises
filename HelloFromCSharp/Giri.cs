using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloFromCSharp
{
    internal class Giri
    {
        //C# Program to Print Odd Numbers in a Given Range
        public static void OddNumbers()
        {
            Console.WriteLine("Enter the Number : ");
            int range = int.Parse(Console.ReadLine());
            for (int i = 1; i < range; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
        //C# Program to Find the Largest of Three Numbers
        public static void LargestOfThree()
        {
            int x = 10, y = 20, z = 5;
            if(x>y && x > z)
            {
                Console.WriteLine($"{x} is the Largest Number");
            }else if(y>x && y > z)
            {
                Console.WriteLine($"{y} is the Largest Number");
            }
            else
            {
                Console.WriteLine($"{z} is the Largest Number");
            }
        }
        // C# Program to Swap Two Numbers with and without 3rd variable.
        public static void Swap()
        {
            int a = 10, b = 20;
            Console.WriteLine($"Beafore swapping a={a} b={b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After swapping a={a} b={b}");
        }
        //C# Program to Find the Sum of All the Multiples of 3 and 5 under a givem limit number.
        public static void SumOfAllMultiples()
        {
            Console.WriteLine("Enter the Number : ");
            int range = int.Parse(Console.ReadLine());
            int sum=0;
            for (int i = 1; i<range; i++) 
            {
                if(i%3==0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
        //C# Program to Print All the Multiples of 17 which are Less than 100
        public static void Multiple()
        {
            for(int i = 1; i< 100; i++)
            {
                if (i % 17 == 0) {
                    Console.WriteLine(i);
                }
            }
        }
        //C# Program to Find Sum of Digits of a Number
        public static void SumOfDigits()
        {
            Console.WriteLine("Enter the Number : ");
            int digit= int.Parse(Console.ReadLine());
            int sum = 0;
            while (digit > 0)
            {
                sum = sum + digit%10;
                digit /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
