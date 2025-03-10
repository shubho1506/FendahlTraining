﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKt1
{
    class Arts : IDivisions
    {
        private List<Student> students = new List<Student>();

        public Arts()
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
