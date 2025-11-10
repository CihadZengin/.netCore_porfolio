using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Entityframework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager =new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {

            var values =portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddPortfolio()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPortfolio(Portfolio p)
        {

            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(p);
            if (result.IsValid)
            {
              portfolioManager.TAdd(p);
              return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.GetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditPortfolio(int id)
        {
            var values = portfolioManager.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result=validations.Validate(portfolio);
            if(result.IsValid)
            {
              portfolioManager.TUpdate(portfolio);
              return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
