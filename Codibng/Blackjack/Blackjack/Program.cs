using System;
using System.Collections.Generic;

using System.Text;


namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "Unnamed";
            int firstCardScore, secondCardScore, totalCardScore;
            const float initialMoney = 100.00f;
            float playerMoney = initialMoney;



            
            Console.Title = "Blackjack but bad";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("\n ----- ");
            Console.Write("\n |A  | ");
            Console.Write("\n |   | ");
            Console.Write("\n |  A| ");
            Console.Write("\n ----- ");

            Console.ResetColor();

            Console.Write("\nWelcome to Blackjack!");
            Console.Write("\nThis program was created by Kallum!\n");
            Console.Write("\nWhat's your name? :)\n");

            username = Console.ReadLine();

            Console.WriteLine("\nGot it, " + username);
            Console.WriteLine("\nAt the moment, you have £" + playerMoney);
            Console.WriteLine("Press any key to continue to the betting phase!");
            Console.ReadKey();
            float my_float = 0.0f;
            betMoney(username, ref playerMoney,out my_float);

            Console.ReadLine();

            int[] blackjack_array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

           


        }

       
        static void betMoney(string Username, ref float Playermoney, out float betfloat)
        {

            betfloat = 0.0f;
            string stringToBet;
            float moneyToBet;

            Console.WriteLine("\nOkay, before we begin " + Username);
            Console.WriteLine("you need to bet some money!");
            Console.WriteLine("\nYou have £" + Playermoney);
            Console.WriteLine("How much would you like to bet?");

            stringToBet = Console.ReadLine();

            float floatToBet = Convert.ToSingle(stringToBet);

            if (floatToBet > Playermoney)
            {
                Console.WriteLine("You dont have that much! nerd");
                betMoney(Username, ref Playermoney, out betfloat);
            }
            else
            {
                Playermoney = Playermoney -= floatToBet;
                betfloat = floatToBet;

                Console.WriteLine("You NOW have £" + Playermoney);
                Console.WriteLine("Okay, press any key to go back to the game!");
                Console.ReadLine();


            }
            
            static void initialDraw()
            {
                Random rnd = new Random();

            }

            Console.ReadLine();

        }






    }


}

