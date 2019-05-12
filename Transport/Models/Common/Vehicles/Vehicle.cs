using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
	public abstract class Vehicle : IVehicle
	{
		public double Speed { get; set; }
		public double MaxCargoWeight { get; set; }
		public string Brand { get; set; }
		public int CrewSize { get; set; }
		public int PassengersNumber { get; set; }
		public string FullInfo => new StringBuilder()
			.AppendLine(GetType().Name)
			.AppendLine($"Speed is {Speed}")
			.AppendLine($"Max cargo weight is {MaxCargoWeight}")
			.AppendLine($"Brand is {Brand}")
			.AppendLine($"Size of crew is {CrewSize}")
			.Append($"Number of passengers is {PassengersNumber}")
			.ToString();
		public abstract void DeliverCargo();
	}
}
