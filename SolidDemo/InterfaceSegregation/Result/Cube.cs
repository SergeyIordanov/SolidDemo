using SolidDemo.InterfaceSegregation.Result.Interfaces;

namespace SolidDemo.InterfaceSegregation.Result
{
	public class Cube : IShape, IHaveArea, IHaveVolume
	{
		public int Width { get; set; }

		public double GetArea()
		{
			return 6 * Width * Width;
		}

		public double GetVolume()
		{
			return Width * Width * Width;
		}
	}
}