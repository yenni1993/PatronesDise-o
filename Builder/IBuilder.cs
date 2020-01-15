namespace Builder
{
    public interface IBuilder
    {
        void reset();
        void setSeats(int _iNumber);
        void setEngine(SportEngine _sportEngine);
        void setTripComputer();
        void setGPS();
    }
}
