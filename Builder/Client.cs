using System;

namespace Builder
{
    public class Client
    {
        public void Main()
        {
            Director director = new Director();
            Console.WriteLine("CarBuilder");
            CarBuilder carBuilder = new CarBuilder();
            Car car = new Car();

            director.makeSportsCar(carBuilder);
            car = carBuilder.getResult();
            

            foreach (string cPart in car.lstCarBuilder)
            {
                Console.WriteLine(cPart);
            }

            Console.WriteLine("");
            Console.WriteLine("CarManualBuilder");
            CarManualBuilder carManualBuilder = new CarManualBuilder();
            director.makeSUV(carManualBuilder);
            Manual manual = carManualBuilder.getResult();

            foreach (string cPart in manual.lstCarManualBuilder)
            {
                Console.WriteLine(cPart);
            }

            Console.ReadLine();
        }
    }
}
