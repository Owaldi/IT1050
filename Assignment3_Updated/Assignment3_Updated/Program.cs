﻿namespace Assignment3_Updated
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");

            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);
            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt", Mike);

            //John.SetStudentGrade(Jane, 96);
            //John.SetStudentGrade(Joe, 85);
            //Mike.SetStudentGrade(Melissa, 90);
            //Mike.SetStudentGrade(Matt, 92);

            //Jane.PrintNameGradeAndTeacher();
            //Joe.PrintNameGradeAndTeacher();
            //Melissa.PrintNameGradeAndTeacher();
            //Matt.PrintNameGradeAndTeacher();
        }
    }
}