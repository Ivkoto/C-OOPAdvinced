using System.Collections.Generic;

public class WeeklyCalendar
{
    private IList<WeeklyEntry> entryes;

    public WeeklyCalendar()
    {
        this.entryes = new List<WeeklyEntry>();
    }

    public IEnumerable<WeeklyEntry> WeeklySchedule => this.entryes;

    public void AddEntry(string weekday, string notes)
    {
        this.entryes.Add(new WeeklyEntry(weekday, notes));
    }
}