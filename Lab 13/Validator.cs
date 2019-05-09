using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Validator
    {
        //props

        //constructor
        public Validator()
        {

        }

        //methods
        public static string ValidateInput(string message)
        {
           string input = "";
           try
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                //return input;

            }
            catch (FormatException)
            {
                Console.WriteLine("enter valid input");
            }
            return input;
        }
    }
}
