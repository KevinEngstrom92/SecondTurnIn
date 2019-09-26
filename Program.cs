using System;
using System.Collections.Generic;
using System.Text;

namespace StarX
{
  partial class Program
    {
        public static List<Rocket> rocketList = new List<Rocket>();
        static void Main(string[] args)
        {
            bool willExit = false;
            while (!willExit) {
                Console.Clear();
            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Add Rocket\n2. List Rockets\n3. Run Simulation");

            ConsoleKeyInfo inputKey = Console.ReadKey(true);

            switch (inputKey.Key)
            {
                case ConsoleKey.D1:
                        Console.Clear();
                    Console.WriteLine("1. Starship, SpaceX\n2.Heavy Falcon, SpaceX");

                    ConsoleKeyInfo shipKey = Console.ReadKey(true);

                    switch (shipKey.Key)
                    {
                        case ConsoleKey.D1:
                            Rocket starShip = new Starship(1335000);
                            break;

                        case ConsoleKey.D2:
                            Rocket falcon = new Falcon((1335000*5));
                            break;
                    }
                    break;

                case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Simulated Rockets:");
                        StringBuilder sb1 = new StringBuilder();
                        sb1.Append('-', Console.WindowWidth);
                        Console.WriteLine(sb1);
                    foreach (Rocket rocket in rocketList)
                    {
                        Console.WriteLine(rocket.Name);
                    }
                        Console.ReadKey(true);
                    break;
                case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Burn Time in sec: ");
                        int burnTime = int.Parse(Console.ReadLine());
                        StringBuilder sb = new StringBuilder();
                        sb.Append('-', Console.WindowWidth);
                        Console.WriteLine($"Engine burn period (sec): {burnTime}");
                        Console.WriteLine("Rocket:\t\t\tVelocity (km/s)\t\t\tFuel left (tons)");
                        Console.WriteLine(sb);
                        foreach (var rocket in Program.rocketList)
                        {
                            Console.WriteLine($"{rocket.Name}\t\t{Math.Round(rocket.SimulateMotion(burnTime)/1000,2)}\t\t{rocket.fuelWeight/1000}");
                        }
                        Console.WriteLine("<Press anykey to continue>");
                        Console.ReadKey(true);

                    break;
                    case ConsoleKey.D4:
                        willExit = true;
                        break;
            }

        }
        }
    }
}
