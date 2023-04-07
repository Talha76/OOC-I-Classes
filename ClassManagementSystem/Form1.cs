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

        private string getDeptName(int deptCode)
        {
            foreach (Department dept in deptList)
            {
                if (dept.code == deptCode) return dept.name;
            }
            return null;
        }

        private void addDept_Click(object sender, EventArgs e)
        {
            string deptName = addDeptName.Text;
            int deptCode = int.Parse(addDeptCode.Text);

            deptList.Add(new Department(deptName, deptCode));

            MessageBox.Show("Department saved!");
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(addStudentId.Text);
            string name = addStudentName.Text;
            int deptCode = int.Parse(addStudentDeptCode.Text);
            int section = int.Parse(addStudentSection.Text);

            studentList.Add(new Student(id, name, deptCode, section));

            MessageBox.Show("Student admitted!");
        }

        private void showStudentsButton_Click(object sender, EventArgs e)
        {
            int deptCode = int.Parse(showStudentsDeptCode.Text);

            studentsListbox.Items.Clear();
            studentsListbox.Items.Add("Student ID\tName\tDepartment\tSection");
            foreach (Student student in studentList)
            {
                if (student.deptCode == deptCode)
                {
                    studentsListbox.Items.Add(student.id + "\t" + student.name + "\t" + getDeptName(student.deptCode) + "\t" + student.section);
                }
            }
        }
    }
}
