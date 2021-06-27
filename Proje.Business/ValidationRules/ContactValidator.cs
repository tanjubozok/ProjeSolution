using FluentValidation;
using Proje.Entity.Concrete;

namespace Proje.Business.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Adınızı boş geçemezsiniz.");
            RuleFor(x => x.Username).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Username).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız.");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Eposta boş geçemezsiniz.");
            RuleFor(x => x.Email).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Email).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız.");

            RuleFor(x => x.Subject).NotEmpty().WithMessage("Başlık boş geçemezsiniz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız.");

            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj alanını boş geçemezsiniz.");
            RuleFor(x => x.Message).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Message).MaximumLength(1000).WithMessage("Lütfen en fazla 1000 karakter girişi yapınız.");
        }
    }
}
