using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SI_UK_Third
{
  //CLASS CONTAINS INFORMATION ABOUT STUDENT
  public  class Student : IStudent
  {
      #region VariabletoforStudentInformation
          private int _StudentID; 
          private int _StudentRollNo;
          private string _StudentName;
          private string _StudentDOB;
          private string _StudentEmail;
          private double _StudentGPA;
      #endregion
        
      #region DefaultConstructor
          public Student() //CONSTRUCTOR TO INIT... DEFAULT GPA
      {
          _StudentGPA = 3.0; 
      }
          #endregion

    #region CopyConstructor
      public Student(Student _Student) //COPY CONSTRUCTOR (CREATE AN OBJECT BY COPYING VARIABLES FROM ANOTHER OBJECT)
      {
          _StudentID = _Student._StudentID;
          _StudentRollNo = _Student._StudentRollNo;
          _StudentName = _Student._StudentName;
          _StudentDOB = _Student._StudentDOB;
          _StudentEmail = _Student._StudentEmail;
          _StudentGPA = _Student._StudentGPA; 
      }
    #endregion

    #region enumStudent
      public enum studentGPA //ENUM FOR STORING STUDENTGPA 
      {
          one = 1,
          two = 2,
          three = 3,
          four = 4
      };
     #endregion

     public double[] _StuArray = new double[5]; 

     public double[] StudentUserInput()
     {
         Console.Write("\n \tEnter Student ID:");
         _StudentID = Convert.ToInt32(Console.ReadLine());

         Console.Write("\n \tEnter Student RollNumber:");
         _StudentRollNo = Convert.ToInt32(Console.ReadLine());

         Console.Write("\n \tEnter Student Name:");
         _StudentName = Console.ReadLine();

         Console.Write("\n \tEnter Student DOB:");
         _StudentDOB = Console.ReadLine();

         Console.Write("\n \tEnter Student Email:");
         _StudentEmail=Console.ReadLine();

         int _UserChoiceGPA; //THIS VARIABLE FOR STORE USER CHOICE FOR GPA WHICH COMES FROM ENUM
         int _StudentSemester = 1; //THIS VARIBALE FOR TRACKING WHICH SEMESTE INFORMATION USER ENTERING

         Console.WriteLine("\n\t Enter 1 for CGPA-1, 2 for CGPA-2,3 for CGPA-3 and 4 for CGPA-4 \n");
         for (int i = 0; i < 5; i++)
         {
             Console.WriteLine("\n\t Enter Student CGPA for Semester:{0}",_StudentSemester);
           
             _UserChoiceGPA = Convert.ToInt32(Console.ReadLine());

             switch (_UserChoiceGPA) //USE SWITCH WHICH WORKES BASED ON USER INPUT  FOR CGPA
             {
                 case 1:
                     _StuArray[i] = (double)studentGPA.one;
                     break;
                 case 2:
                     _StuArray[i] = (double)studentGPA.two;
                     break;
                 case 3:
                     _StuArray[i] = (double)studentGPA.three;
                     break;
                 case 4:
                     _StuArray[i] = (double)studentGPA.four;
                     break;
                 default:
                     _StuArray[i] = (double)studentGPA.three;
                     break;                
             } 
             _StudentSemester++;
         }

         return _StuArray;
     }

     #region CalculateStudentGPA
     public double CalculateStudentCGPA(double[] _StudentInput)
     {
         double CGPA = 0;
         for (int i = 0; i < 5; i++)
         {
             CGPA = CGPA + _StudentInput[i];
         }
         CGPA = CGPA / 5; //Formula for calculate GPA total divide by number of calss 
         _StudentGPA = CGPA;

         return CGPA;
     }
     #endregion


    #region CompareStudentGPA 
     public static void CompareStudentGPA(double studentGAP1, double studentGAP2, double studentGAP3, double studentGAP4, double studentGAP5)
     {
         if ((studentGAP1 > studentGAP2) && (studentGAP1 > studentGAP3) && (studentGAP1 > studentGAP4) && (studentGAP1 > studentGAP5))
         {
             Console.WriteLine("---Student having heighest GPA is : {0}",studentGAP1);
         }
         if ((studentGAP2 > studentGAP1) && (studentGAP2 > studentGAP3) && (studentGAP2 > studentGAP4) && (studentGAP2 > studentGAP5))
         {
             Console.WriteLine("---Student having heighest GPA is : {0}", studentGAP2);
         }
         if ((studentGAP3 > studentGAP1) && (studentGAP3 > studentGAP2) && (studentGAP3 > studentGAP4) && (studentGAP3 > studentGAP5))
         {
             Console.WriteLine("---Student having heighest GPA is : {0}", studentGAP3);
         }
         if ((studentGAP4 > studentGAP1) && (studentGAP4 > studentGAP2) && (studentGAP4 > studentGAP3) && (studentGAP4 > studentGAP5))
         {
             Console.WriteLine("---Student having heighest GPA is : {0}", studentGAP4);
         }
         if ((studentGAP5 > studentGAP1) && (studentGAP5 > studentGAP2) && (studentGAP5 > studentGAP3) && (studentGAP5 > studentGAP4))
         {
             Console.WriteLine("---Student having heighest GPA is : {0}", studentGAP5);
         }
      }
      #endregion

   #region DisplayStudentInformatioin
     public void DispalyStudent() 
     {
         Console.WriteLine("\t------------Student Details------------------");

         Console.WriteLine("\t Student ID is: {0}",_StudentID);
         Console.WriteLine("\t Student RollNumber is: {0}", _StudentRollNo);
         Console.WriteLine("\t Student Name is: {0}", _StudentName);
         Console.WriteLine("\t Student DateofBirth is: {0}", _StudentDOB);
         Console.WriteLine("\t Student EmailID is: {0}", _StudentEmail);
         Console.WriteLine("\t Student CGPA is: {0}", _StudentGPA);
         
         Console.WriteLine("\t---------------------------------------------");
     }
   #endregion

   #region AddTwoStudentDetails
        public static Student operator +(Student _first, Student _Second)
        {
            Student _AddStudent = new Student();
            _AddStudent._StudentID = _first._StudentID + _Second._StudentID;
            _AddStudent._StudentRollNo = _first._StudentRollNo + _Second._StudentRollNo;
            _AddStudent._StudentName = string.Concat(_first._StudentName, _Second._StudentName);
            _AddStudent._StudentDOB = string.Concat(_first._StudentDOB,_Second._StudentDOB);
            _AddStudent._StudentEmail = string.Concat(_first._StudentEmail, _Second._StudentEmail);
            _AddStudent._StudentGPA = _first._StudentGPA +_Second._StudentGPA;

            return _AddStudent;

        } 
    #endregion
  } 
}
