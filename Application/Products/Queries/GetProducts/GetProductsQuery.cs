using MediatR;
using Backend.Domain.Models;

namespace Application.Products.Queries.GetProducts;
public record GetProductsQuery() : IRequest<List<Product>>;