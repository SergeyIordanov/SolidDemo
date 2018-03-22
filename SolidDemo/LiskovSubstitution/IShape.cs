namespace SolidDemo.LiskovSubstitution
{
	public interface IShape
	{
		int Width { get; set; }

		double GetArea();

		double GetVolume();
	}
}