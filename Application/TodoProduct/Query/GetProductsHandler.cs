using MediatR;
using Backend.Domain.Models;
using Application.Common.Interfaces;

namespace Application.Products.Query;

public class GetProductsHandler : IRequestHandler<GetProducts, List<Product>>
{
    private readonly IApplicationDbContext<Product> _context;

    public GetProductsHandler(IApplicationDbContext<Product> context)
    {
        _context = context;
    }
    public Task<List<Product>> Handle(GetProducts request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_context.EntityDbSet.ToList());
    }
}