namespace SolidDemo.InterfaceSegregation.Initial
{
	public class Cube : IShape
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