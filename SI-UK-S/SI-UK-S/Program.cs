using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SI_UK_S
{
    //THIS IS CONSOLE APPLICATION WHICH IS ACCEPTING VALUE FOR STUDENT ARRARY(ROLL NUMBER AND MARKS) AND THEN DISPLAY STUDENT HIGEST MARKS
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nThis Console Application Accept User Input from User for Student(RollNumber and Marks)\n");

            Console.WriteLine(" User Must have to inter details (with RollNumber and Markes Obtain) for 05 Students");

            int [] _StudentRollNumber= new int[5]; //This Array store Student RollNumber
            int [] _StudentMarks = new  int[5];   //This Array store Student Markes respect to RollNumber

            int Number = 1; //This variable for only to track the number of student when user enter the details

            Console.WriteLine("\n \t--- Please enter the detait for the Student ---- \n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\t Enter Roll Number for the Student: {0} ", Number);
                _StudentRollNumber[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\t Enter Marks for the Student: {0} ", Number);
                _StudentMarks[i] = Convert.ToInt32(Console.ReadLine()); 

                Number++; 
            }

            Array.Sort(_StudentMarks, _StudentRollNumber);

            Console.WriteLine("Student RollNumber {0} having Heighest Markes {1} ",_StudentRollNumber[4],_StudentMarks[4]);
            Console.ReadKey();  
        }
    }
}
