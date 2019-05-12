using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
	public abstract class WaterVehicle : Vehicle, IWaterVehicle
	{
		public abstract void Swim();
		public override void DeliverCargo()
		{
			Swim();
		}
	}
}
