using GettingStartedClient.CalculatorService;
using System;

namespace GettingStartedClient
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "FUCK YOU TITLE";
			Console.ForegroundColor = ConsoleColor.Green;

			CalculatorClient client = new CalculatorClient();

			double value1 = 100;
			double value2 = 150;

			double result = client.Add(value1, value2);
			Console.WriteLine($"Add({value1}, {value2}) = {result})");

			result = client.Substract(value1, value2);
			Console.WriteLine($"Substract({value1}, {value2}) = {result})");

			result = client.Multiply(value1, value2);
			Console.WriteLine($"Multiply({value1}, {value2}) = {result})");

			result = client.Divide(value1, value2);
			Console.WriteLine($"Divide({value1}, {value2}) = {result})");

			Console.ReadKey();
			client.Close();
		}
	}
}