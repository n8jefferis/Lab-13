using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Randy : Player
    {
        
        //props
        public Random R { get; set; }

        //constructors
        public Randy(string Name, Random R) : base(Name)
        {
            this.R = R;
        }
        //methods
        public override string GenerateRoshambo()
        {
            int choice = R.Next(0, 3);
            List<string> RPSValues = new List<string>() { RPS.Rock, RPS.Paper, RPS.Scissors };
            return RPSValues[choice];
        }

        //public int RandomNumber(int min, int max)
        //{
        //    Random random = new Random();
        //    return random.Next();
        //}

        //public string SelectOption()
        //{
        //    Console.WriteLine(RandomNumber(1, 3));
            
        //    int input = int.Parse(Console.ReadLine());
        //    string option = RPS[input];
        //    return option;
        //}
    }
}
