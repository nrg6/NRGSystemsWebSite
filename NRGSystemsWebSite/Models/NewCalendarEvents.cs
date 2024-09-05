﻿namespace NRGSystemsWebSite.Models
{
    public class NewCalendarEvents
    {
        public int CalendarEventId { get; set; }
        public int NumberOfEvents { get; set; }
        public bool IsEmpty { get; set; }
        public string DateBookingMade { get; set; }
        public string BookingDate { get; set; }
        public string StartTime { get; set; }
        public string Duration { get; set; }
        public string Goal { get; set; }
        public int BookingClientId { get; set; }
    }
}
