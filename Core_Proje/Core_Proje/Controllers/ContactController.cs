using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messageManager.TGetList();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var values = messageManager.GetByID(id);
            messageManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ContactDetails(int id)
        {
            var values =messageManager.GetByID(id);
            return View(values);
        }
    }
}
