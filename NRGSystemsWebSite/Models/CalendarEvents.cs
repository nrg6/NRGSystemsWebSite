﻿namespace NRGSystemsWebSite.Models
{
    public class CalendarEvents
    {
        public int CalendarEventId { get; set; }
        public int NumberOfEvents { get; set; }
        public bool IsEmpty { get; set; }
        public DateTime DateBookingMade { get; set; }
        public DateTime BookingDate { get; set; }
        public string StartTime { get; set; }
        public string Duration { get; set; }
        public string Goal { get; set; }
        public int BookingClientId { get; set; }
    }
}

