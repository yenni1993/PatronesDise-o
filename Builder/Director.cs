namespace Builder
{
    public class Director
    {
        public void makeSUV(IBuilder _IBuilder)
        {
            _IBuilder.reset();
            _IBuilder.setSeats(4);
            _IBuilder.setEngine(new SportEngine());
            _IBuilder.setTripComputer();
            _IBuilder.setGPS();
        }

        public void makeSportsCar(IBuilder _IBuilder)
        {
            _IBuilder.reset();
            _IBuilder.setSeats(4);
            _IBuilder.setEngine(new SportEngine());
            _IBuilder.setTripComputer();
            _IBuilder.setGPS();
        }
    }
}
