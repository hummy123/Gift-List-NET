namespace GiftList.Models
{
    public interface IUserRepository
    {
        public bool Login(string email, string password);
    }
}
