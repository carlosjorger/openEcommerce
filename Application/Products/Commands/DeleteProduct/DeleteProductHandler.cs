using Application.Common.Interfaces;
using Backend.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Commands.DeleteProduct;

public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
{
    private readonly IApplicationDbContext<Product> applicationDb;

    public DeleteProductCommandHandler(IApplicationDbContext<Product> applicationDb)
    {
        this.applicationDb = applicationDb;
    }
    public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine();
        var product = await applicationDb.EntityDbSet.FindAsync(request.id);
        applicationDb.EntityDbSet.Remove(product!);
        await applicationDb.SaveChangesAsync();
        return Unit.Value;
    }
}
