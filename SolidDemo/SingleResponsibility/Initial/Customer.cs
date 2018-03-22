using System;

namespace SolidDemo.SingleResponsibility.Initial
{
	public class Customer
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public void Add(Customer customer)
		{
			try
			{
				// Database code goes here
			}
			catch (Exception ex)
			{
				System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
			}
		}
	}
}