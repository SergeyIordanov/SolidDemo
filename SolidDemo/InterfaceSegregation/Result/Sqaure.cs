using SolidDemo.InterfaceSegregation.Result.Interfaces;

namespace SolidDemo.InterfaceSegregation.Result
{
	public class Sqaure : IShape, IHaveArea
	{
		public int Width { get; set; }

		public double GetArea()
		{
			return Width * Width;
		}
	}
}