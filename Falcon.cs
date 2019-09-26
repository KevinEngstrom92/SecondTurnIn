using System;

namespace StarX
{
    class Falcon : Rocket
    {
    
        public Falcon(decimal initialWeight)
            : base(initialWeight)
        {
            bool isIn = false;
            Name = "Heavy Falcon, SpaceX";
           
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