using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);

            return RedirectToAction("Index");

        }
        public ActionResult DeleteSkill(int id)
        {
            var values = skillManager.GetByID(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditSkill(int id)
        {
            var values =skillManager.GetByID(id);
           return View(values);
        }
        [HttpPost]
        public ActionResult EditSkill(Skill skill)
        {
          skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
