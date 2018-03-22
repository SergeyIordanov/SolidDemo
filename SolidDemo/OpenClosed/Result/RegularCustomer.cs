namespace SolidDemo.OpenClosed.Result
{
	public class RegularCustomer : Customer
	{
		public override double GetDiscount(double totalSales)
		{
			return base.GetDiscount(totalSales) - 50;
		}
	}
}