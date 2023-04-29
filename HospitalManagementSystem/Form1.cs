using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Form1 : Form
    {
        List<Patient> patients;
        public Form1()
        {
            InitializeComponent();
            patients = new List<Patient>();
        }

        private void admitPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string name = PatientName.Text;
                int id = int.Parse(PatientID.Text);
                string disease = PatientDisease.Text;
                DateTime admissionDate = DateTime.Parse(PatientAdmissionDate.Text);

                patients.Add(new Patient(name, id, disease, admissionDate));
                MessageBox.Show("Patient Admitted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
