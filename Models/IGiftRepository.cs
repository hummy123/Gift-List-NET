namespace GiftList.Models
{
    public interface IGiftRepository
    {
        public IEnumerable<Gift> AllGifts { get; }
        public Gift? GetGiftById(int giftId);
    }
}
