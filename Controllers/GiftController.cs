using Microsoft.AspNetCore.Mvc;
using GiftList.Models;

namespace GiftList.Controllers
{
    public class GiftController : Controller
    {
        private readonly IGiftRepository _giftRepository;

        public GiftController(IGiftRepository giftRepository)
        {
            _giftRepository = giftRepository;
        }

        public IActionResult List()
        {
            return View(_giftRepository.AllGifts);
        }
    }
}
