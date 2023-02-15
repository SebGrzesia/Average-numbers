using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c;
        int sum;
        double average;
        Console.WriteLine("Enter first integrer number");
        while (!int.TryParse(Console.ReadLine(), out a)){
            Console.WriteLine("Number is invalid");
            Console.WriteLine("Try again");
        }
        Console.WriteLine("Enter secound number");
        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("number is invalid");
            Console.WriteLine("Try again");
        }
        Console.WriteLine("Enter the third number");
        while(!int.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("number is invalid");
            Console.WriteLine("try again");
        }

        sum = a + b + c;
        average = (double)sum / 3;

        Console.WriteLine("Sum is: " + sum + " average is: " + average);
        Console.ReadKey();
    }
}