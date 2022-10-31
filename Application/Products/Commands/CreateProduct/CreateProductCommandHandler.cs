using Application.Common.Interfaces;
using Backend.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Commands.CreateProduct;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
{
    private readonly IApplicationDbContext<Product> applicationDbContext;

    public CreateProductCommandHandler(IApplicationDbContext<Product> applicationDbContext)
    {
        this.applicationDbContext = applicationDbContext;
    }
    public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await applicationDbContext.EntityDbSet.AddAsync(request.product);
        await applicationDbContext.SaveChangesAsync(cancellationToken);
        return product.Entity;
    }
}
