using System;

namespace SolidDemo.DependencyInversion.Initial
{
	public class FileLogger
	{
		public void WriteError(Exception ex)
		{
			System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
		}
	}
}