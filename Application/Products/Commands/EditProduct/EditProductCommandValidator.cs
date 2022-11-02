using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Commands.EditProduct
{
    //field name is required, price must be great than 0
    public class EditProductCommandValidator: AbstractValidator<EditProductCommand>
    {
        public EditProductCommandValidator()
        {
            RuleFor(v => v.product.Name).NotEmpty().WithMessage("name is required");
            RuleFor(v => v.product.Price).GreaterThan(0).WithMessage("price must not be less than or equal than 0");
        }
    }
}
