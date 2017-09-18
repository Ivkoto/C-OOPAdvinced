using System;

public class WeeklyEntry : IComparable<WeeklyEntry>
{
    private WeekDay day;

    public WeeklyEntry(string weekday, string notes)
    {
        Enum.TryParse(weekday, out this.day);
        //this.Day = (WeekDay)Enum.Parse(typeof(WeekDay), weekday);
        this.Notes = notes;
    }

    public WeekDay Day
    {
        get { return this.day; }
        private set { this.day = value; }
    }

    public string Notes { get; private set; }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;

        var comparision = this.day.CompareTo(other.day);
        return comparision != 0 ? comparision : this.Notes.CompareTo(other.Notes);
    }

    public override string ToString() => $"{this.Day} - {this.Notes}";
}