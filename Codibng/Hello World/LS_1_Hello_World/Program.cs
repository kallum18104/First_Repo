#region ""
using System;

namespace LS_1_Hello_World
{
    class Program
    {
        #endregion


        static void Main(string[] args)
        {
            Console.WriteLine("Where are we?");
            
            string UserInput = Console.ReadLine();


            if ((UserInput == "Totton") | (UserInput == "totton"))
            {
                Console.WriteLine("Correct! We are in " + UserInput);
            }
            else
            {
                Console.WriteLine("no... we're in totton");
            }
        }
#region "" 
    }
}
#endregion