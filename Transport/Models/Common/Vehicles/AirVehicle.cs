using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
	public abstract class AirVehicle : Vehicle, IAirVehicle
	{
		public abstract void Fly();
		public override void DeliverCargo()
		{
			Fly();
		}
	}
}
