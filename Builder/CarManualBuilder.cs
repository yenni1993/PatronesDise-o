using System.Collections.Generic;

namespace Builder
{
    public class CarManualBuilder : IBuilder
    {
        private Manual manualCar;

        public void reset()
        {
            manualCar = new Manual();
        }

        public void setEngine(SportEngine _sportEngine)
        {
            string cEngine = "No se asignó el tipo de motor.";

            if (_sportEngine != null)
            {
                _sportEngine.cTypeEngine = "Normal";
                cEngine = $"Se asignó el tipo de motor {_sportEngine.cTypeEngine}";
            }

            manualCar.Add(cEngine);
        }

        public void setGPS()
        {
            string cGPS = "Se asignó el GPS";
            manualCar.Add(cGPS);
        }

        public void setSeats(int _iNumber)
        {
            string cSeat = $"Se asignó {_iNumber} asientos";
            manualCar.Add(cSeat);
        }

        public void setTripComputer()
        {
            string cTrip = "Se asignó el trip de computadora";
            manualCar.Add(cTrip);
        }

        public Manual getResult()
        {
            return manualCar;
        }
    }
}
