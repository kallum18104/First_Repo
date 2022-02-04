#region ""
using System;

namespace LS_7_Functions
{
    class Program
    {
        #endregion
        /*
            Lesson 7 Functions-

            Functions are a very important and useful tool in programming.

            Functions allow you to call lines of code with only the name of the function.
            
            To declare a function you type this:
        
            static void MyFunction()
            {
                //do code here

            
            }

            To call a function in Main simply call the function name


            
         */

        static void Main(string[] args)
        {
            Outputhello();





            CountToTen();


            Console.ReadLine();


        }

        static void Outputhello()
        {
            Console.WriteLine("\nI'm being written by function Outputhello!\n");


        }

        

        static void myfunction()
        {
            Console.WriteLine("I came from a function!");
        }

        static string NameString()
        {

            Console.WriteLine("This comes from the string function!");
            return "kallum";
        }


        static void CountToTen()
        {
            for (int i=0; i<=10; i++)
            {
                Console.WriteLine(i);
            }

        }







        #region ""
    }
}
#endregion
