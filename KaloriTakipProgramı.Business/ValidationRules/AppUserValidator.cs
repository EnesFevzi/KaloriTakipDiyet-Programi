using FluentValidation;
using KaloriTakipProgramı.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Business.ValidationRules
{
	public class AppUserValidator:AbstractValidator<AppUser>
	{
        public AppUserValidator()
        {
			RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen Adınızı giriniz");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("Lütfen Soyadınızı giriniz");
			RuleFor(x => x.Age).NotEmpty().WithMessage("Lütfen Yaşınızı giriniz");
			RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir Ad giriniz");
			RuleFor(x => x.Name).MinimumLength(8).WithMessage("lütfen 8 karakterden daha uzun bir Ad giriniz");
			RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir Soyadı giriniz");
			RuleFor(x => x.Surname).MinimumLength(8).WithMessage("lütfen 8 karakterden daha uzun bir Soyadı giriniz");
		}
    }
}
