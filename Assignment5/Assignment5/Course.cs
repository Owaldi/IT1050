using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Course
    {
        
      public string CName;
      public int CRNNumber;
      public int ListOfStudents;

         public int GetCourseInfo()
        {
           System.Console.Write("Course Name?");
           CName = System.Console.ReadLine();
           Console.Write("Course Number?");
           CRNNumber = int.Parse(System.Console.ReadLine());
           Console.Write("How many students? ");
           ListOfStudents = int.Parse(System.Console.ReadLine());
           return ListOfStudents;
        }


         public void PrintCourseInfo()
         {
             Console.WriteLine("Course Name:" + CName);
             Console.WriteLine("Course Number:" + CRNNumber);
             Console.WriteLine("List Students:" + ListOfStudents);
             Console.WriteLine();
         }
    }
}
