#region ""
using System;

namespace LS_9_Functions_pt3
{
    class Program
    {
        #endregion
      

        static void Main(string[] args)
        {
            float myFloat = 1.03f;

            counttoten(ref myFloat);

            overload("this is a string!");

            Console.ReadLine();
        }

        

        static void counttoten(ref float my_float)
        {
            float addtofloat = 1.03f;

            while (my_float <=100)
            {
                my_float += addtofloat;
                Console.WriteLine(my_float);
                overload("this is a string!");
            }
        }

        static void overload(int myInt)
        {
            Console.WriteLine(myInt);
        }

        static void overload(string myString)
        {
            Console.WriteLine(myString);
        }






        #region ""
    }
}
#endregion
