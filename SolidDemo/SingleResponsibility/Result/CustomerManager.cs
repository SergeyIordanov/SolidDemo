using System;

namespace SolidDemo.SingleResponsibility.Result
{
	public class CustomerManager
	{
		private readonly FileLogger _fileLogger;

		public CustomerManager()
		{
			_fileLogger = new FileLogger();
		}

		public void Add(Customer customer)
		{
			try
			{
				// Database code goes here
			}
			catch (Exception ex)
			{
				_fileLogger.WriteError(ex);
			}
		}
	}
}