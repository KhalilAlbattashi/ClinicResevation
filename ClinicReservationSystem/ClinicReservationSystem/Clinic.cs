using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicReservationSystem
{
    public class Clinic
    {
        public delegate void AppointmentBookedDelegate(Appointment a);
        public event AppointmentBookedDelegate OnAppointmentBooked;

        private List<Doctor> doctors = new List<Doctor>();
        private List<Patient> patients = new List<Patient>();
        private List<Appointment> appointments = new List<Appointment>();
        
        public void RegisterPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public void RegisterDoctors(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public void AddAppointment(Patient p, Doctor doc, DateTime d)
        {
           var ap = new Appointment(p, doc, d);
            appointments.Add(ap);
            if(OnAppointmentBooked != null)
            {
                OnAppointmentBooked(ap);
            }
        }
        public void DisplayDoctors()
        {
            int count = 0;
            Console.WriteLine("--------------Available Doctors--------------");
            foreach (Doctor doctor in doctors)
            {
                Console.WriteLine($"{count + 1}. Doctor Name: {doctor.name}, Specialization: {doctor.specialization}");
                count++;
            }
            Console.WriteLine("---------------------------------------------");

        }

        public Doctor GetDoctor(int index)
        {
                return doctors[index];
        }
            

        public void DisplayPatients()
        {
            Console.WriteLine("--------------Registered Patients--------------");
            Console.WriteLine("Patient Name\tPatient Age\tPatient Phone Number");
            foreach (Patient patient in patients)
            {
                Console.WriteLine($"{patient.name}\t{patient.age}\t{patient.contactNumber}");
            }
            Console.WriteLine("-----------------------------------------------");
        }

        public void BookingAppointment(Appointment a) {
            OnAppointmentBooked?.Invoke(a);
        }


       
    }
}
