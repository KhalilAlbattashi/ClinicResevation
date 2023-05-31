namespace ClinicReservationSystem
{
    public class Appointment
    {
       public Patient Patient { get; set; }
        public Doctor PatientDoctor { get; set; }
        
        public DateTime date { get; set; }
        public Appointment(Patient patient, Doctor doctor, DateTime date) {
            if (validateDate(date))
            {
            this.Patient = patient;
            this.PatientDoctor = doctor;
            }
            else
            {
                Console.WriteLine("invalid operation please choose another day ");
                return;
            }
        }

        public bool validateDate(DateTime date)
        {
            if(date.DayOfWeek.ToString() == "Friday" ||  date.DayOfWeek.ToString() == "Saturday")
            {
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine("Cannot Book an Appointment on Weekend Days");
                return false;
            }
            else
            {
                this.date = date;
                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine("Appointment Booked Successfully");
                return true;
            }
        }

    }
}
