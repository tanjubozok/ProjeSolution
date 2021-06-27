using FluentValidation;
using Proje.Entity.Concrete;

namespace Proje.Business.ValidationRules
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("kullanıcı adınız boş geçemezsiniz.");
            RuleFor(x => x.Username).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Username).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız.");

            RuleFor(x => x.Password).NotEmpty().WithMessage("şifre boş geçemezsiniz.");
            RuleFor(x => x.Password).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Password).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız.");
        }
    }
}
