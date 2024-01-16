using BookStore.BL;
using BookStore.Models.Models;
using FluentValidation;

namespace BookStore.Validators
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator() 
        { 
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(2);
            RuleFor(x => x.Id)
                .NotEmpty()
                .GreaterThan(0);
            RuleFor(x => x.BirthDay)
                .NotEmpty()
                .NotNull();
        }
    }
}
