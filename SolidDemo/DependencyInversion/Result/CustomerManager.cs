using System;

namespace SolidDemo.DependencyInversion.Result
{
	public class CustomerManager
	{
		private readonly ILogger _logger;

		public CustomerManager(ILogger logger)
		{
			_logger = logger;
		}

		public void Add(Customer customer)
		{
			try
			{
				// Database code goes here
			}
			catch (Exception ex)
			{
				_logger.WriteError(ex);
			}
		}
	}
}