using FirstWebApi.Models;
using FluentValidation;

namespace FirstWebApi.Validator
{
    public class StudentFluentValidator : AbstractValidator<Student>
    {
        public StudentFluentValidator()
        {
            RuleFor(s => s.studentName).NotEmpty().WithMessage("Enter the name").Length(0, 10).WithMessage("The length of name should be between 0-10");
            RuleFor(s => s.studentAge).GreaterThanOrEqualTo(18).WithMessage("The age should be greater than 18");
            RuleFor(s => s.studentId).NotNull().WithMessage("Enter the id");
        }
    }
}
