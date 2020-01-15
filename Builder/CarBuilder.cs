namespace Builder
{
    public class CarBuilder : IBuilder
    {
        public Car car;

        public void reset()
        {
            car = new Car();
        }

        public void setEngine(SportEngine _sportEngine)
        {
            string cEngine = "No se asignó el tipo de motor.";

            if (_sportEngine != null) {
                _sportEngine.cTypeEngine = "Deportivo";
                cEngine = $"Se asignó el tipo de motor {_sportEngine.cTypeEngine}";
            }

            car.Add(cEngine);
        }

        public void setGPS()
        {
            string cGPS = "Se asignó el GPS";
            car.Add(cGPS);
        }

        public void setSeats(int _iNumber)
        {
            string cSeat = $"Se asignó {_iNumber} asientos";
            car.Add(cSeat);
        }

        public void setTripComputer()
        {
            string cTrip = "Se asignó el trip de computadora";
            car.Add(cTrip);
        }

        public Car getResult()
        {
            return car;
        }
    }
}
