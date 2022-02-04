#region ""
using System;

namespace LS_8_Functions_pt2
{
    class Program
    {
        #endregion
        /*
            Lesson 8 Functions Part 2-

            You may have noticed that this visual studios solution contains multiple projects-

            That is something you can do in visual studios!
            on the right tab click "Solution Explorer" and you will see lessons 7 and 8 listed- 

            To access the file containing the code click on the file program.cs- 

            to build a different project click on the name of the project up top (and middle)
            and select the other one!

            Functions not only can return a datatype they are also able to take in one!.

            These are called "parametres".

            To have a function ask for a parametre we have our function declaration like before

            static void Myfunction()
            {
                //do code here
            }
            
            and inside the brackets after your funciton name "Myfunction()"

            You state the datatype of your variable (int,string) and give the 
            parametre a name like so!

            static void Myfunction_par(int My_parametre_int)
            {
                Console.WriteLine(My_parametre_int);
               
            }
            
            remember "Console.WriteLine()"?

            That function was asking for a string variable this entire time! 
            Which was why we were passing text in quotation marks before- thats what a string is!

            Your not limited to one parametre per function you can do multiple:

            static void Myfunction_par2(int My_parametre_int,int My_parametre_int2,string My_parametre_string)
            {
                Console.WriteLine(My_parametre_int);
                Console.WriteLine(My_parametre_int2);
                Console.WriteLine(My_parametre_string);
                
            }
            
            With this in mind to make use of our functions in code we would type out its name as before
            and include a value that matches the datatype its asking for as a parametre:

            Myfunction_par(5);
            
            Myfunction_par2(2,8,"String variable text");
            
            With all this in mind its time to start doing it ourselves.
            
         */

        static void Main(string[] args)
        {
            //This funciton requires an int
            Outputnumber(5);
            Outputnumber(8);
            Outputnumber(234);

            OutputSentance("this is a string.");

            addNumbers(3);

            countToN(100);
            
            Console.ReadLine();
        }

        static void Outputnumber(int My_int)
        {
            Console.Write("The number passed through was: ");

            Console.WriteLine(My_int);
            //Write whatever number is passed

        }

        static void OutputSentance(string my_string)
        {
            Console.Write("The string passed through was: ");

            Console.WriteLine(my_string);
        }

        static void addNumbers(int myInt2)
        {
            int myInt4;
            int myInt3;
            myInt3 = 5;
            myInt4 = myInt3 += myInt2;
            Console.WriteLine(myInt4);
        }


        static void countToN(int countInt)
        {
            for(int i=0; i<=countInt; i++)
            {
                Console.WriteLine(i);
                calledBy();
            }

        }

        static void calledBy()
        {
            Console.WriteLine("I was called by another function!");
        }




        #region ""
    }
}
#endregion
