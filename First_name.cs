using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_First_Name_UC_1
{
    class UC_1_First_Name   //create one class.
    {       
        public static void FirstName(string name)  //declaring the static meythod to take user input.
        {
            string firstname = "^[A-Z]{1}[A-Za-z]{2,}$"; //write regularExpration    ^=start  $=end.

            Regex a = new Regex(firstname); //class Ststem.regularExpressions.Regex
            //Regex represent an immutable regular expression.
            if (a.IsMatch(name)) //chicking the condition with the help of if /else statement.
                //IsMatch :indicates whether the regular expression specified in the Regex constructor finds a match in a specified input string.
            {
                Console.WriteLine(name+" this name is valid"); //if the conduction is true.
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(name + " this name is not valid please type first later upper case"); //if condition is false.
                Console.ReadLine();
            }
        }

    }
}
