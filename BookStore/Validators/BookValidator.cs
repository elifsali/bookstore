using BookStore.Models.Models;
using BookStore.Models.Models.Request;
using FluentValidation;

namespace BookStore.Validators
{
    public class BookValidator: AbstractValidator<Book>
    {
        public BookValidator() 
        {
            RuleFor(x => x.AuthorId)
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.Title)
                .NotEmpty()
                .MinimumLength(2);
            RuleFor(x => x.Id)
                .NotEmpty()
                .GreaterThan(0);
            RuleFor(x => x.RelaseDate)
                .NotNull()
                .NotEmpty()
                .LessThan(new DateTime(2000, 01, 01));
        }
    
    }
}
