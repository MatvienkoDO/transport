using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
	public class Airplane : AirVehicle
	{
		public override void Fly()
		{
			Console.WriteLine($"{GetType().Name} is flying");
		}
	}
}
