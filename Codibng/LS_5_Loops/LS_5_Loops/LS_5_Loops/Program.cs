#region ""

using System;





namespace LS_5_Loops
{
    class Program
    {

        #endregion
        /*
            Welcome to lesson 5 loops!

            Loops are a way for the programmer to execute a piece of code numerous times without needing to 
            retype the same line over and over.

            There are multiple types of loops you can use and within this tutorial we will focus on the 2 most commonly used.

            The first we'll use is the WHILE loop example syntax:

            while (condition==true)
            {
                //do code here 
            }
            
            The while loop will continuously execute the code until the condition is no longer true.
        
            The next loop you'll commmonly use is the FOR loop. Example syntax:

            for (var i=0;i<=5;i++)
            {
                //do code here
            }
            
            The for loop is compromised of three pieces:

            1. the beginning statement (var i=0;) sets the beginning variable to a starting value
            
            2. The middle statement (i<=5;) is the condition- while its still true the for loop will repeat its code.

            3. The last statement (i++) is the iterator- when each loop is completed this statement is executed.

            With all this in mind look at this again:

            for (var i=0;i<=5;i++)
            {
                //do code here
            }

            So our variable i starts at 0 and checks if i is less than or equal to 5 which it is so it will execute the code.

            then after the code inside is executed we add 1 to i (0+1=1) which makes i now 1.

            The for loop checks if i is less than or equal to 5 which it still is so we go through the for loop again.

            When i reaches 6 the for loop will check that i is less than or equal to 5 which it is not- the for loop completes and the 
            program continues on.           
         */

        static void Main(string[] args)
        {
            //while loop code

            Console.WriteLine("Beginning the while loop\n");

            int MyInt_While = 0;
            int MyInt_CountDown = 10;

            while (MyInt_While <=10)
            {
                Console.WriteLine("MyInt_While is: " + MyInt_While.ToString());
                MyInt_While += 1;
            }

            Console.WriteLine("\nFinished the while loop");

            //Console.ReadLine();

            int MyInt_For = 0;

            for (var i = 0; i <= 20; i++)
            {
                Console.WriteLine("MyInt_For is: " + MyInt_For.ToString());
                MyInt_For += 1;
            }

            Console.WriteLine("\nFinished the for loop.\n");

            while ((MyInt_CountDown <= 10) && (MyInt_CountDown >=0)) 
            {
                Console.WriteLine("Counting down from: " + MyInt_CountDown.ToString());
                MyInt_CountDown -= 1;
            }

            Console.WriteLine("\nFinished Countdown from ten.\n");

            for (var u = 9; u >= 4; u--)
            {
                Console.WriteLine("variable u = " + u);
            }
        }
#region ""
    }
}
#endregion