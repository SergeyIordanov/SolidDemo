using System;

namespace SolidDemo.SingleResponsibility.Result
{
	public class FileLogger
	{
		public void WriteError(Exception ex)
		{
			System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
		}
	}
}