using System;
using System.Collections.Generic;
using System.Text;

namespace SunHomeworkStudent
{
    class StudentProfessorTest
    {
        static void Main(string[] args)
        {
            Person Myper = new Person();
            Myper.Greet();

            Student student = new Student();
            student.Study();
            student.SetAge(15);
            student.ShowAge();
            student.Greet();
           
            Teacher Tech = new Teacher();
            Tech.SetAge(45);
            Tech.Greet();
            Tech.Explain();
        }
    }
}
