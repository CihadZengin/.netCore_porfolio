using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Alanı Boş Geçilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Görsel Alanı Boş Geçilemez");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Değer Alanı Boş Geçilemez");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Değer Alanı Boş Geçilemez");
            RuleFor(x => x.Image2).NotEmpty().WithMessage("Değer Alanı Boş Geçilemez");
            RuleFor(x => x.Image3).NotEmpty().WithMessage("Değer Alanı Boş Geçilemez");
            RuleFor(x => x.Image4).NotEmpty().WithMessage("Değer Alanı Boş Geçilemez");
            RuleFor(x => x.Platform).NotEmpty().WithMessage("Değer Alanı Boş Geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Alanı Boş Geçilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Değer Alanı Boş Geçilemez");
            RuleFor(x => x.Status).NotEmpty().WithMessage("Değer Alanı Boş Geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje Adı En Az 5 Karakterden Oluşmak Zorundadır");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje Adı En Fazla 100 Karakterden Oluşmak Zorundadır");
        }
    }
}
