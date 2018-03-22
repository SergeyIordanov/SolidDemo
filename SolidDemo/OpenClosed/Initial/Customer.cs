namespace SolidDemo.OpenClosed.Initial
{
	public class Customer
	{
		public CustomerType Type { get; set; }

		public double GetDiscount(double totalSales)
		{
			if (Type == CustomerType.Regular)
			{
				return totalSales - 100;
			}
			else
			{
				return totalSales - 50;
			}
		}
	}
}