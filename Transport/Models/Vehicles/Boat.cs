using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
	public class Boat : WaterVehicle
	{
		public override void Swim()
		{
			Console.WriteLine($"{GetType().Name} is swimming");
		}
	}
}
