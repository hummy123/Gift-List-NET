namespace GiftList.Models
{
    public interface IFaqReposity
    {
        IEnumerable<Faq> GetFaqsByGiftId { get; }
    }
}
