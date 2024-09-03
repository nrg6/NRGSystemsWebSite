using NRGSystemsWebSite.Models;

namespace NRGSystemsWebSite.Services
{
    public interface ICalendarFunctionServices
    {
        Task<bool> CreateACalendarEvent(CalendarEvents exercise);
        Task<string> EditACalendarEvent(CalendarEvents exercise);
        Task<List<CalendarEvents>> GetAllCalendarEvent();
        Task<CalendarEvents> GetACalendarEvent(DateTime bookingDated);
        Task<CalendarEvents> GetClientsCalendarEvents(int BookingClientsId);
        Task<string> DeleteACalendarEvent(int CalendarEventId);
    }
}
