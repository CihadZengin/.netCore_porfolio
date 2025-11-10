using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Humanizer;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.ViewComponents
{
    [Area("Writer")]
    public class Notification : ViewComponent
    {
        AnnouncementsManager announcementManager = new AnnouncementsManager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = announcementManager.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}
