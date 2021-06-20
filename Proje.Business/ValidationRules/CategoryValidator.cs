using FluentValidation;
using Proje.Entity.Concrete;

namespace Proje.Business.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adınız boş geçemezsiniz.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız.");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Kategori açıklama boş geçemezsiniz.");
            RuleFor(x => x.Description).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Lütfen en fazla 200 karakter girişi yapınız.");
        }
    }
}
