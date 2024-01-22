using System;
using System.Collections.Generic;

namespace setExercise.Entities
{
    internal class Professor
    {
        public string name { get; set; }
        private HashSet<Student> students = new HashSet<Student>();

        public Professor(string name)
        {
            this.name = name;
        }

        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public int totalStudents()
        {
            return students.Count;
        }
    }
}
