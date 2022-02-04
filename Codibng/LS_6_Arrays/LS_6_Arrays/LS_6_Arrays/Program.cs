#region ""

using System;





namespace LS_6_Arrays
{
    class Program
    {

        #endregion
        /*
            Welcome to lesson 6 Arrays!

            Arrays allow for a variable to hold more than one of the same datatype.
            
            Any datatype can use arrays (ints,floats,strings).

            An example of an array declaration is:

            int [] my_int_array = {0,1,2};

            there are three values in the array and to access each one you list the position the value is stored in i.e

            my_int_array[0] would be value 0

            my_int_array[1] would be value 1

            my_int_array[2] would be value 2

            Arrays Start counting their first position at 0.

            
            
         */

        static void Main(string[] args)
        {

            int[] blackjack_array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Random rnd = new Random();
            int index = rnd.Next(blackjack_array.Length);

            Console.WriteLine("Your first card is " + index);

            Random rnd2 = new Random();
            int index2 = rnd.Next(blackjack_array.Length);

            Console.WriteLine("Your second card is " + index2);

            int firstTotal = index + index2;

            Console.WriteLine("So far, your total is " + firstTotal);

            Console.WriteLine("To hit again, press [H]. To stand, press [S]");


            string userinput = Console.ReadLine();

            Console.WriteLine(userinput);

            if ((userinput == "h") | (userinput == "H"))
            {
                Random rnd3 = new Random();
                int index3 = rnd.Next(blackjack_array.Length);

                Console.WriteLine("You got " + index3);
                int secondTotal = firstTotal + index3;
                Console.WriteLine("Your new total is: " + secondTotal);

                if (secondTotal == 21)
                {
                    Console.WriteLine("Blackjack!");
                }

                if (secondTotal > 21)
                {
                    Console.WriteLine("Bust!");
                }
                else
                {
                    userinput = null;
                    Console.WriteLine("To hit again, press [H]. To stand, press [S]");

                    string userinput2 = Console.ReadLine();

                    Console.WriteLine(userinput2);


                    if ((userinput2 == "h") | (userinput2 == "H"))
                    {
                        Random rnd4 = new Random();
                        int index4 = rnd.Next(blackjack_array.Length);

                        Console.WriteLine("You got " + index4);
                        int thirdTotal = secondTotal + index4;
                        Console.WriteLine("Your new total is: " + thirdTotal);

                        if (thirdTotal == 21)
                        {
                            Console.WriteLine("Blackjack!");
                        }

                        if (thirdTotal > 21)
                        {
                            Console.WriteLine("Bust!");
                        }
                        else
                        {
                            userinput = null;
                            Console.WriteLine("To hit again, press [H]. To stand, press [S]");

                            string userinput3 = Console.ReadLine();

                            Console.WriteLine(userinput3);


                            if ((userinput3 == "h") | (userinput3 == "H"))
                            {
                                userinput = null;
                                Random rnd5 = new Random();
                                int index5 = rnd.Next(blackjack_array.Length);

                                Console.WriteLine("You got " + index5);
                                int fourthTotal = thirdTotal + index5;
                                Console.WriteLine("Your new total is: " + fourthTotal);

                                if (fourthTotal > 21)
                                {
                                    Console.WriteLine("Bust!");
                                }
                                else
                                {
                                    Console.WriteLine("To hit again, press [H]. To stand, press [S]");

                                    string userinput4 = Console.ReadLine();

                                    Console.WriteLine(userinput4);


                                    if ((userinput4 == "h") | (userinput4 == "H"))
                                    {
                                        userinput = null;
                                        Random rnd6 = new Random();
                                        int index6 = rnd.Next(blackjack_array.Length);

                                        Console.WriteLine("You got " + index6);
                                        int fithTotal = fourthTotal + index6;
                                        Console.WriteLine("Your new total is: " + fithTotal);
                                    }


                                }


                            }

                            if ((userinput == "s") | (userinput == "S"))
                            {
                                Console.WriteLine("you stood ya baffoon");
                            }
                        }


                    }

                    if ((userinput == "s") | (userinput == "S"))
                    {
                        Console.WriteLine("You stood at " + firstTotal);
                    }

                    #region ""
                }
            }
        }
    }
}

#endregion