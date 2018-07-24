using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("A Simple Calculator");
			Console.WriteLine("Please input two numbers: ");

			  double num1 = Convert.ToDouble(Console.ReadLine()); //the user's first number will be converted to double and stored in num1
			  double num2 = Convert.ToDouble(Console.ReadLine()); //the user's second number will be converted to double and stored in num2
			
			Console.Write("Do want to add, subtract, multiply, or divide these numbers? Please type out your selection: ");
			string response = Console.ReadLine(); //the user's math selection will be stored in response

			double total = 0 ; //the user's final calculation will be stored here

			if (response == "add" || response == "+") //if the response is 'add' or '+', apply below
			{
				total = num1 + num2;
			}
			else if (response == "subtract" || response== "-") //if the response is 'subtract' or '-', apply below
			{
				total = num1 - num2;
			}
			else if (response == "multiply" || response == "*") //if the response is 'multiply' or '*', apply below
			{
				total = num1 * num2;
			}
			else if (response == "divide" || response == "/") //if the response is 'divide' or '/', apply below
			{
				total = num1 / num2;
			}
			else{ //any other responses will output below

				Console.WriteLine("Please try again. We don't understand your response.");
				Console.ReadLine(); 
				Environment.Exit(0); //closes the application
			}
				


			Console.WriteLine($"The answer is {total}.");
			Console.ReadLine();
        }
    }
}
