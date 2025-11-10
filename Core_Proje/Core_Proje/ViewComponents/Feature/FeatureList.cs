using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featuremeneger=new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values=featuremeneger.TGetList();
          return View(values);
        }
    }
}
