using BusinessLayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Core_Proje.Views.Shared.Components.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        TestimonialManager TestimonialManager= new TestimonialManager(new EfTestimonialDal());
     
        public IViewComponentResult Invoke()
        {
            var values = TestimonialManager.TGetList();
            return View(values);
        }
    }
}
