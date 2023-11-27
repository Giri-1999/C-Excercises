// See https://aka.ms/new-console-template for more information
using HelloFromCSharp;

Console.WriteLine("Enter the Number for Executing the Program : \n\n" +
    "1.Print Odd Numbers in a Given Range:\n\n" +
    "2.Find the Largest of Three Numbers:\n\n" +
    "3.Swap Two Numbers with and without 3rd variable:\n\n" +
    "4.Find the Sum of All the Multiples of 3 and 5 under a givem limit number:\n\n" +
    "5.Print All the Multiples of 17 which are Less than 100:\n\n" +
    "6.Find Sum of Digits of a Number:\n");
int Number = int.Parse(Console.ReadLine());
switch (Number)
{
    case 1:
        Giri.OddNumbers();
        break;
    case 2:
        Giri.LargestOfThree();
        break;
    case 3:
        Giri.Swap();
        break;
    case 4:
        Giri.SumOfAllMultiples();
        break;
    case 5:
        Giri.Multiple();
        break;
    case 6:
        Giri.SumOfDigits();
        break;
    default:
        Console.WriteLine("Invalid input, Please enter the valid data");
        break;
}


