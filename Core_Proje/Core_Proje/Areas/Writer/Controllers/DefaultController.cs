using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]

    public class DefaultController : Controller
    {
        AnnouncementsManager announcementsManager = new AnnouncementsManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values = announcementsManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult announcementDetails(int id)
        {
            Announcement announcement = announcementsManager.GetByID(id);
            return View(announcement);
        }
    }
}
