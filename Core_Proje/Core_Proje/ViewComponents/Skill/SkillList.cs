using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager SkillManager = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = SkillManager.TGetList();
            return View(values);
        }
    }
}
