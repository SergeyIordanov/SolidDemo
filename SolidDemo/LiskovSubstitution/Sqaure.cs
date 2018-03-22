using System;

namespace SolidDemo.LiskovSubstitution
{
	public class Sqaure : IShape
	{
		public int Width { get; set; }

		public double GetArea()
		{
			return Width * Width;
		}

		public double GetVolume()
		{
			throw new NotImplementedException();
		}
	}
}