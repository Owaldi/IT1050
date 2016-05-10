using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            int C;
            bool T = true;
            Course C1 = new Course(); C = C1.GetCourseInfo();
            Console.WriteLine();
            Student[] arraylistofStudents = new Student[C];


            while (T == true)
            {

                for (int i = 0; i < C; i++)
                {
                    arraylistofStudents[i] = new Student();
                    Console.Write("Student Name:");
                    arraylistofStudents[i].SName = Console.ReadLine();
                    Console.Write("Student Number:");
                    arraylistofStudents[i].SNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                System.Console.Write(" Would you like to start again enter true or false? ");
                T = bool.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("+-----------------------------------------------+");
            C1.PrintCourseInfo();
            Console.WriteLine("+-----------------------------------------------+");
            Console.WriteLine();


            for (int i = 0; i < C; i++)
            {
                Console.WriteLine("+-----------------------------------------------+");
                Console.Write("Student Name: " + arraylistofStudents[i].SName + ", ");
                Console.WriteLine("Student Number: " + arraylistofStudents[i].SNumber);
                Console.WriteLine("+-----------------------------------------------+");
            }

            Console.Write("Press Enter to finish...");
            Console.ReadKey();
        }
    }
}
