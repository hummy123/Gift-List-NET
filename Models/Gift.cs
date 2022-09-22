namespace GiftList.Models
{
    public class Gift
    {
        public int GiftId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int CreatedByUserId { get; set; }
        public bool IsFulfilled { get; set; } = false;
        public int FulfilledByUserId { get; set; }
        public bool HasBeenThankedFor { get; set; } = false;
    }
}
