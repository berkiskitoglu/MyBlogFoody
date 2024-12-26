using FluentValidation;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.ValidationRules.CategoryValidationRules
{
    public class CreateCategoryValidator : AbstractValidator<Category>
    {
        public CreateCategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Lütfen Kategori Adını Boş Bırakmayınız!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Veri Girişi Yapınız!");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen En Fazla 20 Karakter Veri Girişi Yapınız!");
        }
    }
}
