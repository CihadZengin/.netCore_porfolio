using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        AboutManager abautmanager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values =abautmanager.TGetList();
            return View(values);
        }
    }
}
