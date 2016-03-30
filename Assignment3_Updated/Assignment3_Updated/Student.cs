namespace Assignment3_Updated
{
    class Student
    {
        public string Name;
        public int Grade;
        public Instructor Teacher;

        public Student(string s, Instructor i)
        {
            this.Name = s;
            this.Teacher = i;
            this.Grade = 0;
        }

        public void SetGrade(int grade)
        {
            this.Grade = grade;
        }

        public void PrintNameGradeAndTeacher()
        {
            System.Console.WriteLine(this.Name + this.Grade);
            this.Teacher.Print();
        }
    }
}