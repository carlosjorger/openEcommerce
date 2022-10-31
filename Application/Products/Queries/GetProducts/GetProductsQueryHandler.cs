using MediatR;
using Backend.Domain.Models;
using Application.Common.Interfaces;

namespace Application.Products.Queries.GetProducts;

public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<Product>>
{
    private readonly IApplicationDbContext<Product> _context;

    public GetProductsQueryHandler(IApplicationDbContext<Product> context)
    {
        _context = context;
    }
    public Task<List<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_context.EntityDbSet.ToList());
    }
}