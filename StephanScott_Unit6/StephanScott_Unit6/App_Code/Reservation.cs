using System;

namespace StephanScott_Unit6
{
    public class Reservation

    {
        public Reservation()
        {
        }

        public DateTime ArrivalD { get; set; }

        public DateTime DepD { get; set; }

        public int numDays { get; set; }

        public int numberOfPeople { get; set; }

        public string BedSize { get; set; }

        public string SpecReq { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string PreferredMethod { get; set; }
    }
}