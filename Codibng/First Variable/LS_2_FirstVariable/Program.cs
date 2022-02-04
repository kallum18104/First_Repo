#region ""
using System;

namespace LS_2_FirstVariable
{
    class Program
    {
        #endregion
        /*
            Welcome to your first variable- to start run the program by pressing the green play button OR by pressing F5.

            You will see a window with text showing the different datatypes a variable can be.

            Once you see it close it and try changing the variables to output something else.
        */

        static void Main(string[] args)
        {
            //String variable
            
            Console.WriteLine("String init:");

            string MyString = "Still a string init";   //  <-- change this variable to get different results

            Console.WriteLine(MyString);            

            //Int variable
            
            Console.WriteLine("int init:");

            int MyInt = 68; //  <-- change the number to get different results

            Console.WriteLine(MyInt);

            //Float variable

            float MyFloat = 41.9f;  //  <-- change the number to get different results

            Console.WriteLine("float init:");

            Console.WriteLine(MyFloat);

            //Boolean variable

            bool MyBool = false;    //  <-- Booleans can only be true or false

            Console.WriteLine("bool init:");

            Console.WriteLine(MyBool);

            int My2ndInt = 4;

            int MyInt3 = MyInt + My2ndInt;

            Console.WriteLine("What a brilliant 2nd int below me man");

            Console.WriteLine(My2ndInt);
            
            Console.WriteLine("and here's a third!");

            Console.WriteLine(MyInt3);

            bool MyBool2 = true;

            string MyString2 = ("Write your name in the string defined as 'MyName' ");

            string MyName = ("Tarrin");

            bool MyBool3 = true;
            string MyString3 = ("password");
            int MyInt4 = 42;
            float MyFloat2 = 68.9f;

            if ((MyBool==false) && (MyBool2 == true))
            {
                Console.WriteLine("Wow, the first is false and the second is true! Now... Make the 2nd int to be UNDER 5!");
                if ((MyBool == false) && MyBool2 == true)
                {
                    if (My2ndInt <= 5)
                    {
                        Console.WriteLine("Good job! You modified the 2nd integer to be under (or equal to) 5 and you have also done the bools.");
                        if (MyString2 == "Write your name in the string defined as 'MyName' ")
                        {
                            Console.WriteLine("How about changing the code as to make MyString2 say your name!");
                            if (MyName == "YourNameHere")
                            {
                                Console.WriteLine("Change me to your name!");
                            }
                            else
                            {
                                Console.WriteLine("Wacky name!");
                                Console.WriteLine("Okay... Now's time for the big stuff. I want you to change MyBool3 to be true, MyString3 to say 'password' MyInt4 to be 42 and MyFloat2 to be 68.9... Then, you'll unlock what you seek.");
                                if (MyInt4 == 42 && MyString3 == ("password"))
                                {
                                    if (MyBool3 == true && MyFloat2 == 68.9f)
                                    {
                                        Console.WriteLine("Wow... You did it! The truth you seek is right here child: https://www.youtube.com/watch?v=fC7oUOUEEi4");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("no... no... no... not quite. Double check...");
                                }
                            }
                        }



                    }

                    
                }
            }
            else
            {
                Console.WriteLine("Somethings out of whack here... Make sure that MyBool is false and MyBool2 is true. Then come back to me...");
            }

           

            /*
             Try creating your own variables- make an int and add it to MyInt to change its number eg 

                int My2ndInt=5;

                MyInt=My2ndInt;

                MyInt=MyInt+My2ndInt;            

                MyInt+=My2ndInt;

                MyInt=MyInt-My2ndInt;

                MyInt-=My2ndInt;

                MyInt=MyInt*My2ndInt;

                MyInt*=My2ndInt;

                MyInt=MyInt/My2ndInt;

                MyInt/=My2ndInt;

             */

            Console.ReadLine();


        }
#region "" 
    }
}
#endregion