using ModelsValidation.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidation.API.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!")
                .Length(2, 15);
            RuleFor(p => p.Brand)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!")
                .Length(2, 15);
            RuleFor(p => p.Price)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!")
                .Length(2, 10);
            
        }
    }
}
