using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Make Rocky Player
            //Rocky r = new Rocky("Balboa");

            //Console.WriteLine($"{r.Name} throws {r.GenerateRoshambo}");

            ////Make random object
            //Random rando = new Random();
            ////Make Randy Player
            //Randy R = new Randy("Randy Marsh", rando)

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{R.Name} throws {R.GenerateRoshambo}");
            //}

            

            RPSApp ra = new RPSApp();
            ra.Run();


        }
    }
}
