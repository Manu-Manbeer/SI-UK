using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SI_UK_Third
{
  public  class StudentService: IService
    {

        #region IService Members

        public void Serve()
        {
            Student _FirstStudent = new Student();
            Student _SecondStudent = new Student();
            Student _ThirdStudent = new Student();
            Student _ForthStudent = new Student();
            Student _FifthStudent = new Student();

            Student _AddStudent = new Student(); //FOR ADDING TWO STUDENT DETAILS 

            double[] _StudentInput = new double[5]; //STORE USER INPUT FROM THE CONSOLE

            double[] _StudentCGPA = new double[5]; //FOR STORE CGPA CALCULATION OF STUDENT

            try
            {

                Console.WriteLine("\n\t---------------Student Details Here-------------");

                Console.WriteLine("\n\t Please Enter details for first Student");
                _StudentInput = _FirstStudent.StudentUserInput();
                _FirstStudent.DispalyStudent();

                _StudentCGPA[0] = _FirstStudent.CalculateStudentCGPA(_StudentInput);

                Console.WriteLine("\n\t Please Enter details for Second Student");
                _StudentInput = _SecondStudent.StudentUserInput();
                _SecondStudent.DispalyStudent();

                _StudentCGPA[1] = _SecondStudent.CalculateStudentCGPA(_StudentInput);

                Console.WriteLine("\n\t-------------Adding Two Student 1 & Student 2------");

                _AddStudent = _FirstStudent + _SecondStudent;
                _AddStudent.DispalyStudent();
                Console.WriteLine("\n\t-------------Continue to adding other Student Details------");

                Console.WriteLine("\n\t Please Enter details for Third Student");
                _StudentInput = _ThirdStudent.StudentUserInput();
                _ThirdStudent.DispalyStudent();

                _StudentCGPA[2] = _ThirdStudent.CalculateStudentCGPA(_StudentInput);

                Console.WriteLine("\n\t Please Enter details for Four Student");
                _StudentInput = _ForthStudent.StudentUserInput();
                _ForthStudent.DispalyStudent(); 

                _StudentCGPA[3] = _ForthStudent.CalculateStudentCGPA(_StudentInput);

                Console.WriteLine("\n\t Please Enter details for Fifth Student");
                _StudentInput = _FifthStudent.StudentUserInput();
                _FifthStudent.DispalyStudent();

                _StudentCGPA[4] = _FifthStudent.CalculateStudentCGPA(_StudentInput);

                Console.WriteLine("\n\t------------Student Selection for Valedictorian-------------");

                Student.CompareStudentGPA(_StudentCGPA[0], _StudentCGPA[1], _StudentCGPA[2], _StudentCGPA[3], _StudentCGPA[4]);
            }
            catch (Exception e)
            {
                Console.Write("Please try after some time");
            }

            Console.ReadKey();
        }

        #endregion
    }
}
