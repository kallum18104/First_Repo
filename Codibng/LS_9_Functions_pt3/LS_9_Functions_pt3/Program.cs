#region ""
using System;

namespace LS_9_Functions_pt3
{
    class Program
    {
        #endregion
        /*
            Lesson 9 Functions Part 3-
            default parametres 
            pass by reference
            Functions parametres dont have to be mandatory if you provide a default value.

            static void Outputnumber(int My_int)
            {
                Console.WriteLine(My_int);
            }
            
            If you called this function with no parametre you would get an error
        
            static void Outputnumber(int My_int=5)
            {
                Console.WriteLine(My_int);
            }

            If you called this function with no parametre My_int would be assigned 5.
            


            We can also pass parametres in 2 different ways.

            1. The first way is by passing along as a value (This is what we've been doing so far).

            2. The second way is by passing through reference. 
            (Rather than the function having a copy of your variabe it changes it directly- 
            use debugger to see it in action)
            
            To accompolish this you declare your function with a parametre as before

            static void Outputnumber(int My_int)
            {
                Console.WriteLine(My_int);
            }

            where we declared our parametre we place the ref keyword before the datatype.

            static void Outputnumber(ref int My_int=5)
            {
                Console.WriteLine(My_int);
            }
            
            Passing by reference parametres cannot have a default value and will throw an error if you tried.

            
            Lastly functions can be what is known as "overloaded"

            As you may have noticed, "Console.Writeline()" can take both a string or an integer as its parametre

            This is because the function has 2 declarations- one asking for a string variable and one asking for an int variable!
            
            To make a second declaration for your funciton simply reuse its name and give it different parametres

            static void Outputnumber(int My_num)    //declaration 1
            {
                Console.Write("The number passed through was: ");

                Console.WriteLine(My_num);
                //Write whatever number is passed

            }

            static void Outputnumber(float My_num)    //declaration 2
            {
                Console.Write("The number passed through was: ");

                Console.WriteLine(My_num);
                //Write whatever number is passed

            }
            
            A function can have as many overloads as you give it.

            
         */

        static void Main(string[] args)
        {
            Outputnumber(3);

            Outputnumber();

            int main_int = 0;

            addnumber_value(main_int);

            Console.WriteLine("main_int equals after function call: " + main_int);

            addnumber_ref(ref main_int);

            Console.WriteLine("main_int equals after function call: "+main_int);

            Outputnumber(3.9f);

            Console.ReadLine();

            onetoten();
        }

        static void Outputnumber(int My_num = 50)
        {
            Console.Write("The number passed through was: ");

            Console.WriteLine(My_num);
            //Write whatever number is passed

        }
        static void Outputnumber(float My_num )
        {
            Console.Write("The number passed through was: ");

            Console.WriteLine(My_num);
            //Write whatever number is passed

        }
       


        static void addnumber_ref(ref int My_int)
        {
            My_int += 5;
            //Write whatever number is passed

        }

        static void addnumber_value(int My_int)
        {
            My_int += 5;
            //Write whatever number is passed

        }

        static void onetoten()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }





        #region ""
    }
}
#endregion
