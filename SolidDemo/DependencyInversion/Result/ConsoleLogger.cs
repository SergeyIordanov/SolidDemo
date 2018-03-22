using System;

namespace SolidDemo.DependencyInversion.Result
{
	public class ConsoleLogger : ILogger
	{
		public void WriteError(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}