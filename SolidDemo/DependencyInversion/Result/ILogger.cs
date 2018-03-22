using System;

namespace SolidDemo.DependencyInversion.Result
{
	public interface ILogger
	{
		void WriteError(Exception ex);
	}
}