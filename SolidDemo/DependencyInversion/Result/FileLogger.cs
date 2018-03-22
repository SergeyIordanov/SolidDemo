using System;

namespace SolidDemo.DependencyInversion.Result
{
	public class FileLogger : ILogger
	{
		public void WriteError(Exception ex)
		{
			System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
		}
	}
}