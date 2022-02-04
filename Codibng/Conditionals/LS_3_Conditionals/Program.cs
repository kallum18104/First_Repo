#region ""
using System;

namespace LS_3_Conditionals
{
    class Program
    {
        #endregion
        /*
            Welcome to Conditiioals and If statements- Things will begin to get a little more independent from here.

            If statements are what allow for a program to do different things based on what data it has.

            The simple structure of a if statement is as follows:

            if (condition==true)
            {
                //do some code
            }

            You decide what the condition in an if statement is.

            There're multiple operators you can use in an if statement:

            == means does the value on the LEFT EQUAL the value on the RIGHT

            > means the value on the LEFT is GREATER THAN the value on the RIGHT

            < means the value on the LEFT is LESS THAN the value on the RIGHT

            >= means the value on the LEFT is GREATER THAN OR EQUAL to the value on the RIGHT

            <= means the value on the LEFT is LESS THAN OR EQUAL to the value on the RIGHT

            If you want something to happen when something is true and when it is not then we can use the else statement in addition to the if statement.

            if (condition==true)
            {
                //do some code
            }
            else
            {
                //Condition is false so we do this code instead
            }

            Lastly you can have multiple conditions required to enter a if statement:

            if ((condition==true) && (Anothercondition==false))
            {
                //do some code
            }

            if ((condition==true) && (Anothercondition==false))
            {
                //do some code
            }
            
            To join together multiple conditions in an if statement we need to use either the AND symbol ( && ) or the OR symbol ( | )

            && means BOTH conditions must be true to go insde the if statement

            | means EITHER of the conditions must be true to go inside the if statement
        */

        static void Main(string[] args)
        {
            int MyInt = 72389;
            String MyString = "Test";




            if ((MyInt == 5) | (MyInt == 7) | (MyInt >= 70)) 
            {
                Console.WriteLine("Variable MyInt equals 5, 7 or is over 70!");

                if (MyString == "Test")
                {
                    Console.WriteLine("So... MyInt is 5, 7 or over 70 AND MyString is test. Good job!");
                }
            }
            else
            {
                Console.WriteLine("Wow... My variable is NOT 5. I wonder what it is?");
            }
   

            Console.ReadLine();


        }
#region "" 
    }
}
#endregion