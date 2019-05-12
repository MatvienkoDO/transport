using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
	public abstract class GroundVehicle : Vehicle, IGroundVehicle
	{
		public abstract void GoOverland();
		public override void DeliverCargo()
		{
			GoOverland();
		}
	}
}
