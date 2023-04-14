using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystem
{
    abstract internal class Teacher : Person
    {
        public string designation { get; }
        private List<Course> courses;

        public Teacher(int id, string name, Department dept) : base(id, name, dept)
        {
            courses = new List<Course>();
        }

        public void assignCourse(Course course)
        {
            courses.Add(course);
        }

        public void removeCourse(Course course)
        {
            courses.Remove(course);
        }

        public List<Course> getCourseList()
        {
            List<Course> list = new List<Course>();
            foreach (Course course in courses) list.Add(course);
            return list;
        }
    }
}
