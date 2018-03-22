namespace SolidDemo.InterfaceSegregation.Initial
{
	public interface IShape
	{
		int Width { get; set; }

		double GetArea();

		double GetVolume();
	}
}