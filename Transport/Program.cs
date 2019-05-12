using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Transport
{
	class Program
	{
		public static void Main(string[] args)
		{
			var vehicles = new List<IVehicle>();

			while(true)
			{
				string input = Console.ReadLine();
				if(Regex.Match(input, "exit", RegexOptions.Compiled | RegexOptions.IgnoreCase).Success)
				{
					break;
				}

				Match matchToCommand = Regex.Match(input,
					@"(airplane|boat|helicopter|train) \d+(?:\.\d+)? \d+(?:\.\d+)?",
					RegexOptions.Compiled);

				if (matchToCommand.Success)
				{
					string[] parts = input.Split(' ');

					Type vehicleType = null;

					switch (parts[0])
					{
						case "airplane":
							vehicleType = typeof(Airplane);
							break;
						case "boat":
							vehicleType = typeof(Boat);
							break;
						case "helicopter":
							vehicleType = typeof(Helicopter);
							break;
						case "train":
							vehicleType = typeof(Train);
							break;
					}

					if(vehicleType != null)
					{
						IVehicle vehicle = (IVehicle)Activator.CreateInstance(vehicleType);
						
						bool success = double.TryParse(parts[1], NumberStyles.Number, CultureInfo.InvariantCulture, out double weight);
						success &= double.TryParse(parts[2], NumberStyles.Number, CultureInfo.InvariantCulture, out double speed);

						if (success)
						{
							vehicle.MaxCargoWeight = weight;
							vehicle.Speed = speed;
							vehicle.Brand = "SomeDefaultVehicleBrand";
							vehicle.CrewSize = 5;
							vehicle.PassengersNumber = 10;
							vehicles.Add(vehicle);
						}
					}
				}
			}

			Console.WriteLine("Doing some job with vehicles...");
			Task.Delay(TimeSpan.FromSeconds(3)).Wait();

			Console.WriteLine(vehicles
				.Select(v => v.FullInfo)
				.Aggregate("", (acc, curr) => $"{acc}{Environment.NewLine}{curr}{Environment.NewLine}"));

			vehicles.ForEach(v => v.DeliverCargo());

			Console.WriteLine("Done.");
		}
	}
}
