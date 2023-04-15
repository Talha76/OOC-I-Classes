using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManagementSystem
{
    abstract internal class Person
    {
        public int id { get; }
        public string name { get; }
        public Department dept { get; }
        private List<Course> courses;

        public Person(int id, string name, Department dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
            this.courses = new List<Course>();
        }

        public void addCourse(Course course)
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
