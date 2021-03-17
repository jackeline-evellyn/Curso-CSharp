using System;
using System.Collections.Generic;
using System.Text;

namespace _144._Solucao_personalizada_2.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Error in reservation: Reservation dates for updates must be future dates";

            }
            
            if (checkOut <= checkIn)
            {
                return "Error in reservation: Check-out date must be after check-in";
            }
            else
            {
                CheckIn = checkIn;
                CheckOut = checkOut;
                return null;
            }
        }
        public override string ToString()
        {
            return " Room "
                + RoomNumber
                + " , check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + " , check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}

