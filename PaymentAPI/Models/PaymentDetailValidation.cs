using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetailValidation : AbstractValidator<PaymentDetail>
    {
        public PaymentDetailValidation()
        {
            RuleFor(p => p.PaymentDetailId)
                .NotNull()
                .WithMessage("{propertyName} can't be null");

            RuleFor(p => p.CardOwnerName)
                .NotEmpty().WithMessage("{PropertyName} can't be null")
                .Length(2,100).WithMessage("min of 2 string and max 100")
                .Must(NameExpression).WithMessage("name contains invalid characters")
                ;

            RuleFor(p => p.CardNumber)
                .NotEmpty().WithMessage("{PropertyName} can't be null")
                .Length(15).WithMessage("{PropertyName} must be 15 digits")
                ;

            RuleFor(p => p.ExpirationDate)
                .NotEmpty().WithMessage("{PropertyName} can't be null")
                .Length(5).WithMessage("{PropertyName} must be 5 digits in format 12/21")
                ;

            RuleFor(p => p.SecurityCode)
                .NotEmpty().WithMessage("{PropertyName} can't be null")
                .Length(3).WithMessage("{PropertyName} must be 3 digits")
                ;
        }

        protected bool NameExpression( string name )
        {
            name = name.Replace(" ", "");
            name = name.Replace("_", "");
            return name.All(char.IsLetter);
        }

    }

}
