using FluentValidation;
using Proje.Entity.Concrete;

namespace Proje.Business.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Adınızı boş geçemezsiniz.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız.");

            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadınızı boş geçemezsiniz.");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız.");
            RuleFor(x => x.Surname).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız.");

            RuleFor(x => x.About).NotEmpty().WithMessage("Hakkında alanını boş geçemezsiniz.");
            RuleFor(x => x.About).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.About).MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter girişi yapınız.");

            RuleFor(x => x.Title).NotEmpty().WithMessage("Ünvan alanını boş geçemezsiniz.");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Title).MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter girişi yapınız.");

            RuleFor(x => x.Email).NotEmpty().WithMessage("E-posta alanını boş geçemezsiniz.");
            RuleFor(x => x.Email).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Email).MaximumLength(100).WithMessage("Lütfen en fazla 200 karakter girişi yapınız.");
        }
    }
}
