using ModelsValidation.Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidation.API.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!")
                .Length(2, 25)
                .Must(IsValidName).WithMessage("{PropertyName} should be all letters.");

            RuleFor(p => p.Address)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!")
                .Length(2, 100)
                .Must(IsValidName).WithMessage("{PropertyName} should be all letters.");

            RuleFor(p => p.Email)
                .EmailAddress();
        }
        private bool IsValidName(string name)
        {
            return name.All(Char.IsLetter);
        }
    }
}
