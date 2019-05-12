using System;

namespace Transport
{
	public class Train : GroundVehicle
	{
		public override void GoOverland()
		{
			Console.WriteLine($"{GetType().Name} is going overland");
		}
	}
}
