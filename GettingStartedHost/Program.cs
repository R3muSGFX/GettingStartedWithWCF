using GettingStartedLib;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace GettingStartedHost
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Getting Standard Service";
			Console.ForegroundColor = ConsoleColor.Green;

			Uri baseAddress = new Uri("http://localhost:8000/GettingsStarted");
			ServiceHost selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);

			try
			{
				selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");

				ServiceMetadataBehavior smb = new ServiceMetadataBehavior
				{
					HttpGetEnabled = true
				};
				selfHost.Description.Behaviors.Add(smb);

				selfHost.Open();
				Console.WriteLine("The service is ready.");
				Console.WriteLine("Press <ENTER> to terminate service.");
				Console.WriteLine();
				Console.ReadLine();

				selfHost.Close();
			}
			catch (CommunicationException ce)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(ce.Message);
				selfHost.Abort();
			}
		}
	}
}