namespace SolidDemo.DependencyInversion.Result
{
	public class Client
	{
		public void Method()
		{
			var manager1 = new CustomerManager(new FileLogger());
			var manager2 = new CustomerManager(new ConsoleLogger());
		}
	}
}