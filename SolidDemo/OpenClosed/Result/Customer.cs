namespace SolidDemo.OpenClosed.Result
{
	public class Customer
	{
		public virtual double GetDiscount(double totalSales)
		{
			return totalSales;
		}
	}
}