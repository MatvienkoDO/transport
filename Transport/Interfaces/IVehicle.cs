namespace Transport
{
	public interface IVehicle
	{
		double Speed { get; set; }
		double MaxCargoWeight { get; set; }
		string Brand { get; set; }
		int CrewSize { get; set; }
		int PassengersNumber { get; set; }
		void DeliverCargo();
		string FullInfo { get; }
	}
}
