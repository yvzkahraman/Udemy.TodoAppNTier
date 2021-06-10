using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ToDoAppNTier.Dtos.WorkDtos;

namespace Udemy.ToDoAppNTier.Business.ValidationRules
{
    public class WorkCreateDtoValidator : AbstractValidator<WorkCreateDto>
    {
        public WorkCreateDtoValidator()
        {
            RuleFor(x => x.Definition).NotEmpty().WithMessage("Definition alanı boş olamaz").Must(NotBeYavuz).WithMessage("Definition Yavuz olamaz");
        }

        private bool NotBeYavuz(string arg)
        {
            return arg != "Yavuz";
        }
    }
}
