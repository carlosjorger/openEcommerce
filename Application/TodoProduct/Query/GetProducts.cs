using MediatR;
using Backend.Domain.Models;
namespace Application.Products.Query;
public record GetProducts():IRequest<List<Product>>;