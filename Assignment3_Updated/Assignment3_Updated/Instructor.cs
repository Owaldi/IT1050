namespace Assignment3_Updated
{
    class Instructor
    {
        public string Name;
        public string CourseName;

        public Instructor(string name, string coursename)
        {
            this.Name = name;
            this.CourseName = coursename;
        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

        public void Print()
        {
            System.Console.WriteLine(this.Name);
        }
    }
}