namespace SolidDemo.OpenClosed.Result
{
	public class NewCustomer : Customer
	{
		public override double GetDiscount(double totalSales)
		{
			return base.GetDiscount(totalSales) - 30;
		}
	}
}