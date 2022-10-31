using Application.Common.Interfaces;
using Backend.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Commands.EditProduct;

public class EditProductCommandHandler : IRequestHandler<EditProductCommand>
{
    private readonly IApplicationDbContext<Product> applicationDbContext;

    public EditProductCommandHandler(IApplicationDbContext<Product> applicationDbContext)
    {
        this.applicationDbContext = applicationDbContext;
    }
    public async Task<Unit> Handle(EditProductCommand request, CancellationToken cancellationToken)
    {
        applicationDbContext.EntityDbSet.Attach(request.product);
        applicationDbContext.Entry(request.product).State = EntityState.Modified;
        await applicationDbContext.SaveChangesAsync();
        return Unit.Value;
    }
}
