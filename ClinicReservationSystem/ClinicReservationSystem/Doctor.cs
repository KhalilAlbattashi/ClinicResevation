

namespace ClinicReservationSystem
{
    public class Doctor
    {
        public string name { get; set; }
        public string specialization { get; set; }

        public Doctor(string name, string specialization)
        {
            this.name = name;
            this.specialization = specialization;
        }
    }
}
