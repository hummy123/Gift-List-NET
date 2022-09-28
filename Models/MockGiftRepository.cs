namespace GiftList.Models
{
    public class MockGiftRepository : IGiftRepository
    {
        public IEnumerable<Gift> AllGifts => new List<Gift> { };
        public Gift? GetGiftById(int id)
        {
            return null;
        }
    }
}
