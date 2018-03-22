using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SolidDemo.LiskovSubstitution.LiveExample
{
	public static class LiskovTest
	{
		public static void Test()
		{
			ICollection<int> collection1 = new List<int>(new[] { 1, 2, 3 });
			ICollection<int> collection2 = new Collection<int>(new[] { 1, 2, 3 });
			ICollection<int> collection3 = new ReadOnlyCollection<int>(new [] { 1, 2, 3 });

			IEnumerable<ICollection<int>> enumOfEnums = new []{ collection1, collection2, collection3 };

			foreach (var @enum in enumOfEnums)
			{
				@enum.Add(4);
			}
		}
	}
}