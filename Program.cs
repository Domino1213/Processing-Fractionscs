//This is a simple program that uses
//the 'Smile Method' or the 'XD' method to
//add and subtract fractions.
//It also can divide and multiply fractions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing_Fractionscs
{
    class Processing
    {
        //Make the variables that will hold the
        //the numerators and denominators of both
        //of the fractions.
        public int num1;
        public int denom1;
        public int num2;
        public int denom2;

        //Make the object that adds the fractions.
        public void Add()
        {
            //Get the values for the first fraction.
            Console.WriteLine("Enter First Numerator=>");
            num1 = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Enter First Denominator=>");
            denom1 = Convert.ToInt32(Console.ReadLine());

            //Get the values for the second fraction.
            Console.WriteLine("Enter Second Numerator=>");
            num2 = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Enter Second Denominator=>");
            denom2 = Convert.ToInt32(Console.ReadLine());

            //Get the values for when the two numerators
            //get added together.
            int addNum1 = denom2 * num1;
            int addNum2 = denom1 * num2;

            //Get value for the denominator and
            //numerator.
            int denom = denom1 * denom2;
            int num = addNum1 + addNum2;

            Console.WriteLine(num);
            Console.WriteLine("---");
            Console.WriteLine(denom);
            Console.ReadLine();
        }

        //Make the object that subtracts the fractions.
        public void Sub()
        {
            //Get the values for the first fraction.
            Console.WriteLine("Enter First Numerator=>");
            num1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter First Denominator=>");
            denom1 = Convert.ToInt32(Console.ReadLine());

            //Get the values for the second fraction.
            Console.WriteLine("Enter Second Numerator=>");
            num2 = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Enter Second Denominator=>");
            denom2 = Convert.ToInt32(Console.ReadLine());

            //Get the values for when the two numerators
            //get added together.
            int subNum1 = denom2 * num1;
            int subNum2 = denom1 * num2;

            //Get value for the denominator and
            //numerator.
            int denom = denom1 * denom2;
            int num = subNum1 - subNum2;

            Console.WriteLine(num);
            Console.WriteLine("---");
            Console.WriteLine(denom);
            Console.ReadLine();
        }

        //We make the object for multiplying.
        public void Mul()
        {
            //We ask for thge values of the first
            //fraction.
            Console.WriteLine("Enter First Numerator=>");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Denominator=>");
            denom1 = Convert.ToInt32(Console.ReadLine());

            //We ask for thge values of the second
            //fraction.
            Console.WriteLine("Enter Second Numerator=>");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Denominator=>");
            denom2 = Convert.ToInt32(Console.ReadLine());

            //We multiply the two 4 of the values
            //together.
            int num = num1 * num2;
            int denom = denom1 * denom2;

            Console.WriteLine(num);
            Console.WriteLine("---");
            Console.WriteLine(denom);
            Console.ReadLine();
        }

        //We make the object for dividing.
        public void Div()
        {
            //We ask for thge values of the first
            //fraction.
            Console.WriteLine("Enter First Numerator=>");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Denominator=>");
            denom1 = Convert.ToInt32(Console.ReadLine());

            //We ask for thge values of the second
            //fraction.
            Console.WriteLine("Enter Second Numerator=>");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Denominator=>");
            denom2 = Convert.ToInt32(Console.ReadLine());

            //We do the same thing we do with
            //multiplying but we flip the 
            //second fraction.
            int num = num1 * denom2;
            int denom = denom1 * num2;

            Console.WriteLine(num);
            Console.WriteLine("---");
            Console.WriteLine(denom);
            Console.ReadLine();
        }
    }

    class Program
    {
        public bool myNameIJeff = true;
        static void Main(string[] args)
        {
            //Make the processing variable so that
            //we can call our objects.
            Processing pro = new Processing();

            //Make a variable that is always set to
            //true so that our loop will run forever.
            bool foreverLoop = true;

            //Make a loop.
            do
            {
                //Ask if the user wants to add, subtract, multiply
                //or divide two fractions. It also asks if you want
                //to exit the program.
                Console.WriteLine("Add, subtract, multiply or divide (a, s, m, d exit) =>");
                string chooseOption = Convert.ToString(Console.ReadLine());
                //Decides wether to add, subtract, multiply,
                //divide or exit.
                if (chooseOption == "a")
                {
                    pro.Add();
                    Console.Clear();
                }
                else if (chooseOption == "s")
                {
                    pro.Sub();
                    Console.Clear();
                }
                else if (chooseOption == "m")
                {
                    pro.Mul();
                    Console.Clear();
                }
                else if (chooseOption == "d")
                {
                    pro.Div();
                    Console.Clear();
                }
                else if (chooseOption == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            } while (foreverLoop == true);
            //While foreverLoop is true this loop runs forever.
        }
    }
}
