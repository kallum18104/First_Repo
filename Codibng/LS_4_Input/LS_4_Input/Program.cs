#region ""
using System;

namespace LS_4_Input
{
    class Program
    {
        #endregion
        /*
            Welcome to Input- You may have noticed the Console.ReadLine() statement previously?

            We can use that to take text from the user and assign it to a string like so!

            
        */

        static void Main(string[] args)
        {   
            Console.WriteLine("type init:");

            string userinput = Console.ReadLine();

            Console.WriteLine(userinput);

            Console.ReadLine();

            if (userinput == "")
            {
                Console.WriteLine("emptyness");
            }


        }
#region "" 
    }
}
#endregion