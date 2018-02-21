using System;

namespace GettingStartedLib
{
	public class CalculatorService : ICalculator
	{
		public double Add(double n1, double n2)
		{
			double result = n1 + n2;
			Console.WriteLine($"Received: Add({n1},{n2})");
			Console.WriteLine($"Return: {result}");
			return result;
		}

		public double Divide(double n1, double n2)
		{
			double result = n1 / n2;
			Console.WriteLine($"Received: Divide({n1},{n2})");
			Console.WriteLine($"Return: {result}");
			return result;
		}

		public double Multiply(double n1, double n2)
		{
			double result = n1 * n2;
			Console.WriteLine($"Received: Multiply({n1},{n2})");
			Console.WriteLine($"Return: {result}");
			return result;
		}

		public double Substract(double n1, double n2)
		{
			double result = n1 - n2;
			Console.WriteLine($"Received: Substract({n1},{n2})");
			Console.WriteLine($"Return: {result}");
			return result;
		}
	}
}
