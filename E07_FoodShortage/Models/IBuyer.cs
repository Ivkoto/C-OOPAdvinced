namespace E07_FoodShortage.Models
{
    public interface IBuyer : IPersonable
    {
        int Food { get; }
        void BuyFood();
    }
}