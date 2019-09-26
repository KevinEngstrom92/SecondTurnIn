using System;

namespace StarX
{
    partial class Program
    {
        class Starship : Rocket
        {
            
            public Starship(decimal initialWeight)
                : base(initialWeight)
            {
                Name = "Starship, SpaceX";
                bool isIn = false;
                foreach (Rocket rocket in Program.rocketList)
                {
                    if (rocket.Name == this.Name)
                    {
                        isIn = true;
                    }
                }
                if (isIn)


                {
                   
                    Console.Clear();
                    Console.WriteLine("Already added this ship!");
                    System.Threading.Thread.Sleep(2000);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Added Ship");
                    System.Threading.Thread.Sleep(2000);
                    Program.rocketList.Add(this);
                }
            }


        }
    }
}
