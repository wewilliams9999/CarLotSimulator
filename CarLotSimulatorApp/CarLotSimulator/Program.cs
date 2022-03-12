using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instanciate Carlot at beginning of program
            //and as you create a car, add car to list.
            var lot = new CarLot();

            //Done - Create a separate class file called Car
            //Done - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Done - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //Done - The methods should take one string parameter: the respective noise property

            //Done - Now that the Car class is created we can instanciate 3 new cars

                        //Done - Set the properties for each of the cars
            //Done - *************BONUS*************//
            //Done - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //1. Instantiation using dot notation
            var bmw = new Car();
            bmw.Year = 2015;
            bmw.Make = "BMW";
            bmw.Model = "Z4";
            bmw.EngineNoise = "vroom vroom";
            bmw.HonkNoise = "toot toot";
            bmw.IsDriveable = true;
            //add bmw to lot
            lot.Cars.Add(bmw);


            //2. Instantiation using object initializer syntax
            var mercedes = new Car()
            { 
              Year = 2021,
              Make = "Mercedes Benz",
              Model = "AMGGLS63",
              EngineNoise = "growl",
              HonkNoise = "honk honk",
              IsDriveable = true
            };
            //add mercedes to lot
            lot.Cars.Add(mercedes);


            //3. Instantiation using a new contructor to allow parameter values to be placed inside properties
            var rangeRover = new Car (1991, "Range Rover", "Defender", "merp", "beep", false);
            //add RangeRover to lot
            lot.Cars.Add(rangeRover);


            //Call each of the methods for each car
            bmw.MakeEngineNoise();
            bmw.MakeHonkNoise();

            mercedes.MakeEngineNoise();
            mercedes.MakeHonkNoise();

            rangeRover.MakeEngineNoise();
            rangeRover.MakeHonkNoise();



            //*************BONUS X 2*************//

            //Done - Create a CarLot class
            //Done - It should have at least one property: a List of cars
            //Done - Instanciate the Carlot at beginning of program, and as you create a car, add car to list.
            //At the end, iterate through list - printing each of car's Year, Make, and Model to  console
            
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");
            
            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}   Make: {car.Make}   Model: {car.Model}");
            }
        }
    }
}
