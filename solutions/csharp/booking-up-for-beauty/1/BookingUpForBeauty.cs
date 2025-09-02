static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        int hour = appointmentDate.Hour;
        return hour >= 12 && hour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        String time = appointmentDate.ToString("h:mm:ss tt");

        String date = appointmentDate.ToString("M/d/yyyy");
        
        return $"You have an appointment on {date} {time}.";

    }

    public static DateTime AnniversaryDate()
    {
        String year = DateTime.Now.Year.ToString();
        return DateTime.Parse($"9/15/{year} 00:00:00");
    }
}
