using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassManagementSystem
{
    public partial class Form1 : Form
    {
        List<Student> studentList;
        List<Department> deptList;
        List<Teacher> teacherList;
        List<Course> courseList;

        public Form1()
        {
            InitializeComponent();
            studentList = new List<Student>();
            deptList = new List<Department>();
            teacherList = new List<Teacher>();
            courseList = new List<Course>();
        }

        private Department getDept(int deptCode)
        {
            foreach (Department dept in deptList)
            {
                if (dept.code == deptCode) return dept;
            }
            return null;
        }

        private Course getCourse(int courseCode)
        {
            foreach (Course course in courseList)
            {
                if (course.code == courseCode) return course;
            }
            return null;
        }

        private Teacher getTeacher(int teacherId)
        {
            foreach (Teacher teacher in teacherList)
            {
                if (teacher.id == teacherId) return teacher;
            }
            return null;
        }

        private Student getStudent(int id)
        {
            foreach (Student student in studentList)
            {
                if (student.id == id) return student;
            }
            return null;
        }

        private void addDept_Click(object sender, EventArgs e)
        {
            if (addDeptName.Text.Length == 0)
            {
                MessageBox.Show("Please insert Department name!");
                return;
            }
            if (addDeptCode.Text.Length == 0)
            {
                MessageBox.Show("Please insert Department code!");
                return;
            }
            foreach (char ch in addDeptCode.Text)
            {
                if (ch < '0' || ch > '9')
                {
                    MessageBox.Show("Please insert proper department code!");
                    return;
                }
            }

            string deptName = addDeptName.Text;
            int deptCode = int.Parse(addDeptCode.Text);

            deptList.Add(new Department(deptName, deptCode));

            MessageBox.Show("Department saved!");
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            if (addStudentId.Text.Length == 0)
            {
                MessageBox.Show("Please insert student id!");
                return;
            }
            if (addStudentName.Text.Length == 0)
            {
                MessageBox.Show("Please insert student name!");
                return;
            }
            if (addStudentDeptCode.Text.Length == 0)
            {
                MessageBox.Show("Please insert department code!");
                return;
            }
            if (addStudentSection.Text.Length == 0)
            {
                MessageBox.Show("Please insert student section!");
                return;
            }
            foreach (char ch in addStudentId.Text)
            {
                if (ch < '0' || ch > '9')
                {
                    MessageBox.Show("Please insert proper Student ID!");
                    return;
                }
            }
            foreach (char ch in addStudentDeptCode.Text)
            {
                if (ch < '0' || ch > '9')
                {
                    MessageBox.Show("Please insert proper department code!");
                    return;
                }
            }
            foreach (char ch in addStudentSection.Text)
            {
                if (ch < '0' || ch > '9')
                {
                    MessageBox.Show("Please insert proper Student Section!");
                    return;
                }
            }

            // User Data
            int id = int.Parse(addStudentId.Text);
            string name = addStudentName.Text;
            int deptCode = int.Parse(addStudentDeptCode.Text);
            int section = int.Parse(addStudentSection.Text);

            // Our task
            if (getDept(deptCode) != null)
            {
                studentList.Add(new Student(id, name, getDept(deptCode), section));
                MessageBox.Show("Student admitted!");
            } else
            {
                MessageBox.Show("No department found with this code!");
            }
        }

        private void showStudentsButton_Click(object sender, EventArgs e)
        {
            int deptCode = int.Parse(showStudentsDeptCode.Text);

            studentsListbox.Items.Clear();
            studentsListbox.Items.Add("ID\tName\tDepartment\tSection");
            foreach (Student student in studentList)
            {
                if (student.dept.code == deptCode)
                {
                    studentsListbox.Items.Add(student.id + "\t" + student.name + "\t" + student.dept.name + "\t\t" + student.section);
                }
            }
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            if (addTeacherId.Text.Length == 0)
            {
                MessageBox.Show("Insert teacher id");
                return;
            }
            if (addTeacherName.Text.Length == 0)
            {
                MessageBox.Show("Insert teacher name");
                return;
            }
            if (addTeacherDeptCode.Text.Length == 0)
            {
                MessageBox.Show("Insert Department Code");
                return;
            }
            if (addTeacherDesignation.Text.Length == 0)
            {
                MessageBox.Show("Insert teacher designation");
                return;
            }

            foreach (char ch in addTeacherId.Text)
            {
                if (ch < '0' || ch > '9')
                {
                    MessageBox.Show("Insert proper teacher id");
                    return;
                }
            }
            foreach (char ch in addTeacherDeptCode.Text)
            {
                if (ch < '0' || ch > '9')
                {
                    MessageBox.Show("Insert proper department code");
                    return;
                }
            }

            // Main task
            string name = addTeacherName.Text;
            int id = int.Parse(addTeacherId.Text);
            string designation = addTeacherDesignation.Text;
            int deptCode = int.Parse(addTeacherDeptCode.Text);

            if (getDept(deptCode) == null)
            {
                MessageBox.Show("Department doesn't exist!");
                return;
            }

            if (designation == "Lecturer")
            {
                teacherList.Add(new Lecturer(id, name, getDept(deptCode)));
            }
            else
            {
                teacherList.Add(new Professor(id, name, getDept(deptCode)));
            }

            MessageBox.Show("Teacher added.");
        }

        private void showTeachersButton_Click(object sender, EventArgs e)
        {
            if (showTeachersDeptCode.Text.Length == 0)
            {
                MessageBox.Show("Insert proper dept code.");
                return;
            }
            foreach (char ch in showTeachersDeptCode.Text)
            {
                if (ch < '0' || ch > '9')
                {
                    MessageBox.Show("Insert proper dept code");
                    return;
                }
            }

            int deptCode = int.Parse(showTeachersDeptCode.Text);

            showTeachersListbox.Items.Clear();
            showTeachersListbox.Items.Add("Name\tID\tDesignation");
            foreach (Teacher teacher in teacherList)
            {
                if (teacher.dept.code == deptCode)
                {
                    string data = teacher.name + "\t" + teacher.id + "\t" + teacher.GetType().Name;
                    showTeachersListbox.Items.Add(data);
                }
            }
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            if (addCourseName.Text.Length == 0)
            {
                MessageBox.Show("Insert Proper Course Name.");
                return;
            }
            if (addCourseCode.Text.Length == 0)
            {
                MessageBox.Show("Insert Proper Course Code.");
                return;
            }
            foreach (char ch in addCourseCode.Text)
            {
                if (ch < '0' || ch > '9')
                {
                    MessageBox.Show("Insert proper course code");
                    return;
                }
            }

            string name = addCourseName.Text;
            int code = int.Parse(addCourseCode.Text);

            courseList.Add(new Course(code, name));

            MessageBox.Show("Course Added");
        }

        private void assignCourseTeacherButton_Click(object sender, EventArgs e)
        {
            if (assignCourseTeacherId.Text.Length == 0)
            {
                MessageBox.Show("Insert proper teacher id.");
                return;
            }
            if (assignCourseCode.Text.Length == 0)
            {
                MessageBox.Show("Insert proper teacher id.");
                return;
            }
            foreach (char ch in assignCourseTeacherId.Text)
            {
                if (ch < '0' || ch > '9')
                {
                    MessageBox.Show("Insert proper course code");
                    return;
                }
            }
            foreach (char ch in assignCourseCode.Text)
            {
                if (ch < '0' || ch > '9')
                {
                    MessageBox.Show("Insert proper course code");
                    return;
                }
            }

            int teacherId = int.Parse(assignCourseTeacherId.Text);
            int courseCode = int.Parse(assignCourseCode.Text);

            if (getTeacher(teacherId) == null)
            {
                MessageBox.Show("Teacher doesn't exist.");
                return;
            }
            if (getCourse(courseCode) == null)
            {
                MessageBox.Show("Course doesn't exist.");
            }

            if (getTeacher(teacherId) is Lecturer)
            {
                if (courseCode % 2 == 1)
                {
                    MessageBox.Show("Lecturers can't take theory courses.");
                    return;
                }
            }

            getTeacher(teacherId).addCourse(getCourse(courseCode));

            MessageBox.Show("Course assigned to teacher.");
        }

        private void showAssignedCoursesButton_Click(object sender, EventArgs e)
        {
            if (showAssignedCoursesTeacherId.Text.Length == 0)
            {
                MessageBox.Show("Please insert proper teacher id");
                return;
            }
            foreach (char ch in assignCourseCode.Text)
            {
                if (ch < '0' || ch > '9')
                {
                    MessageBox.Show("Insert proper teacher id");
                    return;
                }
            }

            int id = int.Parse(showAssignedCoursesTeacherId.Text);

            if (getTeacher(id) == null)
            {
                MessageBox.Show("Teacher doesn't exist");
                return;
            }

            assignedCourseListbox.Items.Clear();
            assignedCourseListbox.Items.Add("Name\tCode\tType");

            List<Course> teacherCourses = getTeacher(id).getCourseList();
            foreach (Course course in teacherCourses)
            {
                string data = course.name + "\t" + course.code + "\t";
                if (course.code % 2 == 0) data += "Lab";
                else data += "Theory";
                assignedCourseListbox.Items.Add(data);
            }
        }

        private void enrollCourseStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(enrollCourseStudentId.Text);
                int courseCode = int.Parse(enrollCourseCode.Text);

                if (getStudent(id) == null)
                    throw new StudentNotFoundException();
                if (getCourse(courseCode) == null)
                    throw new ApplicationException("Course Not Found.");

                getStudent(id).addCourse(getCourse(courseCode));

                MessageBox.Show("Student enrolled in this course.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showEnrolledCourses_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(showEnrolledCoursesStudentId.Text);

                enrolledCourseListbox.Items.Clear();
                enrolledCourseListbox.Items.Add("Name\tCode");

                if (getStudent(id) == null)
                    throw new StudentNotFoundException();

                List<Course> courses = getStudent(id).getCourseList();

                foreach (Course course in courses)
                {
                    enrolledCourseListbox.Items.Add(course.name + "\t" + course.code);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
