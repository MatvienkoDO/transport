using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
	public class Helicopter : AirVehicle
	{
		public override void Fly()
		{
			Console.WriteLine($"{GetType().Name} is flying");
		}
	}
}
