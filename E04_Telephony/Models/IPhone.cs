namespace E04_Telephony.Models
{
    public interface IPhone
    {
        string Model { get; }
        string Call(string number);
    }
}