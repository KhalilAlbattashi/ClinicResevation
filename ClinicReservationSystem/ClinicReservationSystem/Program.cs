using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

namespace ClinicReservationSystem
{
    class Program
    {
        
        
        public static void Main(string[] args)
        {
            Clinic clinic = new Clinic();
            clinic.OnAppointmentBooked += Clinic_AppointmentBookedEvent;
            // Create doctors
            Doctor doctor1 = new Doctor("Dr. Smith", "General Practitioner");
            Doctor doctor2 = new Doctor("Dr. Jones", "Pediatrician");
            Doctor doctor3 = new Doctor("Dr. James", "Orthopedics");
            Doctor doctor4 = new Doctor("Dr. Camron", "Family medicine");
            Doctor doctor5 = new Doctor("Dr. Mazin", "Dermatology");
            Doctor doctor6 = new Doctor("Dr. Ahmed", "Neurosurgery");

            clinic.RegisterDoctors(doctor1);
            clinic.RegisterDoctors(doctor2);
            clinic.RegisterDoctors(doctor3);
            clinic.RegisterDoctors(doctor4);
            clinic.RegisterDoctors(doctor5);
            clinic.RegisterDoctors(doctor6);

            Console.WriteLine("1) Display All Available Doctors\n2) Display Patients\n3) Book An Appointment");


            while (true)
            {
                string option = Console.ReadLine();
                

                switch (option)
                {
                    case "1":
                        clinic.DisplayDoctors();
                        break;
                    case "2":
                        clinic.DisplayPatients();
                        break;
                    case "3":
                        Console.WriteLine("Enter The patient name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the Patient Age: ");
                        //string sAge = Console.ReadLine();
                        int Age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Patient Contact Number");
                        string ContactNumber =  Console.ReadLine();
                        Patient patient = new Patient(name, Age, ContactNumber);


                        Console.WriteLine("Enter a date for the appointment dddd, dd MMMM yyyy");
                        string sdate = Console.ReadLine();
                        DateTime date = DateTime.Parse(sdate);

                        

                        Console.WriteLine("Enter the Doctor Number from 1 - 6");
                        //string sDoc = Console.ReadLine();
                        
                        int DocNo = int.Parse(Console.ReadLine());
                        if(DocNo > 0 && DocNo < 7)
                        {
                            clinic.AddAppointment(patient, clinic.GetDoctor(DocNo - 1), date);
                        }
                        else
                        {
                            Console.WriteLine("invalid option");
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
        private static void Clinic_AppointmentBookedEvent(Appointment a)
        {
            //Console.WriteLine(a);
            Console.WriteLine($"appointment created successfully \n" +
                $"patient name : {a.Patient.name} with the doctor: {a.PatientDoctor.name} on {a.date.ToString()}");
        }
    }

    
}