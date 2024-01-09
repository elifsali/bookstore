using BookStore.Models.Models.Request;
using FluentValidation;

namespace BookStore.Validators
{
    public class GetBooksByAuthorRequestValidator : AbstractValidator<GetBooksByAuthorRequest>
    {
        public GetBooksByAuthorRequestValidator() 
        {
            RuleFor(test => test.AuthorId)
                .NotNull()
                .GreaterThan(0)
                .LessThan(10);
            RuleFor(test => test.AfterDate)
                .NotNull()
                .NotEmpty()
                .LessThan(new DateTime(2020, 02, 10));
        }
    }
}
