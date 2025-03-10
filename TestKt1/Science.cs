using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKt1
{
    class Science : IDivisions
    {
        static List<Student> students = new List<Student>();

        public Science()
        {

        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void ShowStudents()
        {
            foreach (var item in students)
            {
                item.StudentInfo();
            }
        }
    }
}
