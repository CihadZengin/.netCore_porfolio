using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Proje.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperienceManager ExperienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(ExperienceManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            ExperienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
        public IActionResult GetById(int ExperienceID)
        {
            var v = ExperienceManager.GetByID(ExperienceID);
            var values= JsonConvert.SerializeObject(v);
            return Json(values);

        }
        public IActionResult DeleteExperience(int id)
        {
            var v = ExperienceManager.GetByID(id);
            ExperienceManager.TDelete(v);
            return NoContent();
        }

        [HttpGet]
        public IActionResult UpdateExperience(int ExperienceID)
        {
            var values = ExperienceManager.GetByID(ExperienceID);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateExperience([FromBody]Experience ex)
        {
            ExperienceManager.TUpdate(ex);
            var values = JsonConvert.SerializeObject(ex);
            return Json(values);
        }

    }
}
