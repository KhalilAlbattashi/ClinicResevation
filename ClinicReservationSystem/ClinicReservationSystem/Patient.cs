using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicReservationSystem
{
    public class Patient
    {
        public string name { set; get; }
        public int age { set; get; }
        public string contactNumber { get; set; }

        public Patient(string name, int age, string contactNumber)
        {
            this.name = name;
            this.age = age;
            this.contactNumber = contactNumber;
        }
    }
}
