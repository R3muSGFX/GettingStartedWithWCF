using System.ServiceModel;

namespace GettingStartedLib
{
	[ServiceContract]
	public interface ICalculator
	{
		[OperationContract]
		double Add(double n1, double n2);

		[OperationContract]
		double Substract(double n1, double n2);

		[OperationContract]
		double Multiply(double n1, double n2);

		[OperationContract]
		double Divide(double n1, double n2);
	}
}