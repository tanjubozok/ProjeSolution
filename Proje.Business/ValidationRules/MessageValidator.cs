using FluentValidation;
using Proje.Entity.Concrete;

namespace Proje.Business.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.SenderMail).NotEmpty().WithMessage("Mail boş geçemezsiniz.");
            RuleFor(x => x.SenderMail).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.SenderMail).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız.");

            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Mail boş geçemezsiniz.");
            RuleFor(x => x.ReceiverMail).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.ReceiverMail).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız.");

            RuleFor(x => x.Subject).NotEmpty().WithMessage("Başlık boş geçemezsiniz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter girişi yapınız.");

            RuleFor(x => x.Content).NotEmpty().WithMessage("Mesaj alanını boş geçemezsiniz.");
            RuleFor(x => x.Content).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Content).MaximumLength(1000).WithMessage("Lütfen en fazla 1000 karakter girişi yapınız.");
        }
    }
}
