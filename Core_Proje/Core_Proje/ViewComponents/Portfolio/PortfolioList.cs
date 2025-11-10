using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioManager PortfolioManager =new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = PortfolioManager.TGetList();
            return View(values);
        }
    }
}
