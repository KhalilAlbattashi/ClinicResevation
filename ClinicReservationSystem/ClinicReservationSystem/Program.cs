using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

namespace ClinicReservationSystem
{
    class Program
    {
        
        
        public static void Main(string[] args)
        {
            Clinic clinic = new Clinic();

            // Create doctors
            Doctor doctor1 = new Doctor("Dr. Smith", "General Practitioner");
            Doctor doctor2 = new Doctor("Dr. Jones", "Pediatrician");

            // Create patients
            Patient patient1 = new Patient("John Doe", 30, "123-456-7890");
            Patient patient2 = new Patient("Jane Doe", 20, "987-654-3210");
            Patient patient3 = new Patient("Jo Smith", 30, "123-456-7890");


            // Register patients and doctors
            clinic.RegisterDoctors(doctor1);
            clinic.RegisterDoctors(doctor2);

            
            //Patient patient4 = new Patient(name, age, number);
            clinic.RegisterPatient(patient1);
            clinic.RegisterPatient(patient2);
            clinic.RegisterPatient(patient3);
            // Display the list of doctors and registered patients
            clinic.DisplayDoctors();
            clinic.DisplayPatients();
            DateTime d = DateTime.Parse("Friday, 29 May 2015");
            DateTime d1 = DateTime.Parse("Wednesday, 31 May 2023");

            


            //Console.WriteLine(d.DayOfWeek.ToString());
            
            

            clinic.OnAppointmentBooked += Clinic_AppointmentBookedEvent;
            clinic.AddAppointment(patient1, doctor1, d1);

            //Appointment b = new Appointment(patient2, doctor2, d1);
            //Console.ForegroundColor = ConsoleColor.White;
        }

        private static void Clinic_AppointmentBookedEvent(Appointment a)
        {
            //Console.WriteLine(a);
            Console.WriteLine($"appointment created successfully \n" +
                $"patient name : {a.Patient.name} with the doctor: {a.PatientDoctor.name} on {a.date.ToString()}");
        }
    }

    
}