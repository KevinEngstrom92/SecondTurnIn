using System;

namespace StarX
{
    abstract class Rocket
    {
        decimal noLoadMass { get; set; }
        public decimal fuelWeight = 20000;
        decimal LaunchMass { get; set; }
        public string Name { get; set; }
        decimal endMass { get; set; }
            public Rocket(decimal launchMass)
        {
            LaunchMass = launchMass;
            Name = "Nothing";
           
        }
         public decimal SimulateMotion(int seconds)
        {
            decimal burnWeight = 0;
            for (int i = 0; i < seconds; i++)
            {
                //make burn, lets say we const burn 29 units of fule;
               burnWeight += 29;
                    
            }
           
            const decimal specificImpuls = (decimal)7.1;
            this.fuelWeight -= burnWeight;
            
            decimal log = (decimal)Math.Log((double)(this.LaunchMass+this.fuelWeight / this.fuelWeight));

            decimal result = specificImpuls*log;
            this.fuelWeight -= burnWeight;
            return result;
        }
    }
}
