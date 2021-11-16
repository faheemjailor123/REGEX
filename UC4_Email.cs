using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Last_Name_UC2
{
    class check  //create one class.
    {
        public static void firstName(string name)         //declaring the static meythod to take user input.
        {
            string first = "^[A-Z]{1}[a-z]{2,}$";        //write regularExpration.   ^=start  $=end.
            Regex a = new Regex(first);          //class Ststem.regularExpressions.Regex
                                                 //Regex represent an immutable regular expression.

            if (a.IsMatch(name))        //checking the condition with the help of if /else statement.
                                        //IsMatch :indicates whether the regular expression specified in the Regex constructor finds a match in a specified input string.
            {
                Console.WriteLine(name + " this first name is valid .");  //if the conduction is true.
                
            }
            else
            {
                Console.WriteLine(name + " this first name is not valid, please type first word in uppercase. ");    //if condition is false.
                
            }
        }

        public static void LastName(string name)         //declaring the static meythod to take user input.
        {
            string lastname = "^[A-Z]{1}[a-z]{2,}$";        //write regularExpration.   ^=start  $=end.
            Regex a = new Regex(lastname);          //class Ststem.regularExpressions.Regex
                                                    //Regex represent an immutable regular expression.

            if (a.IsMatch(name))        //checking the condition with the help of if /else statement.
                                        //IsMatch :indicates whether the regular expression specified in the Regex constructor finds a match in a specified input string.
            {
                Console.WriteLine(name + " this last name is valid .");  //if the conduction is true.
                
            }
            else
            {
                Console.WriteLine(name + " this last name is not valid ,please type first word in uppercase.");    //if condition is false.
                
            }          
  
        }
       
        public static void Email(string mail)
        {
            string email = @"^[a-zA-Z0-9]+[+-._]?[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]+@[a-zA-Z0-9]+[.]{1}[a-zA-Z]{2,3}[.]?[a-zA-Z]{0,3}$";
         //@ = match one occurrnce of the patterns.
         //? = matches up exactly one character.
         //* = match up to zero more times the precending.

            Regex a = new Regex(email);

            if (a.IsMatch(mail))
            {
                Console.WriteLine(mail +" this mail is valid");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(mail+" this mail is not valid");
                Console.ReadLine();
            }
        }
        

    }
}
