using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        //Default contructor//
        public Car()
        {
        }

        //Create a constructor that will accept arguments//
        public Car (int year,
                    string make, 
                    string model, 
                    string engineNoise, 
                    string honkNoise, 
                    bool isDriveable)
        { //left side is property, right side is what they will pass in//
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        //DONE - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //DONE - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //DONE - The methods should take one string parameter: the respective noise property
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }


    }
}
