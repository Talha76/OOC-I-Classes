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
        public Form1()
        {
            InitializeComponent();
            studentList = new List<Student>();
            deptList = new List<Department>();
        }

        private Department getDept(int deptCode)
        {
            foreach (Department dept in deptList)
            {
                if (dept.code == deptCode) return dept;
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
                // ch >= '0' && ch <= '9'
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
        }
    }
}
