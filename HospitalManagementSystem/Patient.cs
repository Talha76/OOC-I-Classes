using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    internal class Patient
    {
        public string name { get; }
        public int id { get; }
        public string disease { get; }
        public DateTime admissionDate { get; }

        public Patient(string name, int id, string disease, DateTime admissionDate)
        {
            this.name = name;
            this.id = id;
            this.disease = disease;
            this.admissionDate = admissionDate;
        }
    }
}
