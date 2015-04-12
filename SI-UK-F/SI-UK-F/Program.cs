using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SI_UK_F
{
    class Program
    {
        //THIS IS CONSOLE APPLICATION FOR USR ENTER MIN 05 VALUES AND SORT THEM IN ASSCENDING ORDER
        static void Main(string[] args)
        {
            Console.WriteLine("\t You should only Enter Numeric Values Only and Minimum 05 Values \n");
            Console.Write("\t How many values you want to enter:");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine()); //Read User enter input 

                if (a < 5) //CHECKING HERE THE NUMBER OF VALUES USER WANT TO SORT IF LESS THEN 5 THEN  DISPLAY MESSAGE AND BREAK
                {
                    
                    Console.WriteLine("minimum five numbers you have to enter");

                }
                else 
                {
                    int[] _Array = new int[a]; //CREATE THE ARRAY BASED ON VALUE CHOOSEN BY THE USER
                    int Current = 1;
                    for (int i = 0; i < a; i++)
                    {
                        Console.Write("Enter  Value for {0}:Number  \t",Current);
                        _Array[i] = Convert.ToInt32(Console.ReadLine()); //ASSIGN THE VALUES TO THE ARRAY 
                        Current++;
                    }

                    Array.Sort(_Array); //USE INBUILD METHOD TO SORT THE ARRARY 
                    Program.DisplayShortArray(_Array); // HERE ACCESS THE METHOD TO DISPLAY ARRARY VALUES AFTER SORTING 

                }

            }
            catch (Exception ex) // IF USER ENTER OTHER THEN NUMERIC VALUES THEN EXCEPTION OCCURES AND MESSAGE DISPLAY TO USER
            {
                Console.WriteLine("Only numeric Values allowed");
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        static void DisplayShortArray(int[] _Array) //METHOD TO DISPLAY ARRARY AFTER SORTING 
        {
            Console.WriteLine("\n \t After sorting values are:");

            foreach (int i in _Array)
            {
                Console.Write("\t{0}", i);
            }
           
        }
    }
}
