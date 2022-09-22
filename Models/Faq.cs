namespace GiftList.Models
{
    public class Faq
    {
        public int FaqID { get; set; }
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public int AskedByUserId { get; set; }
        public int GiftId { get; set; }
    }
}
