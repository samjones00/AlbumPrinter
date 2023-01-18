using AlbumPrinter.Domain.Commands;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlbumPrinter.DependencyInjection;
public static class Endpoints
{
    public static void AddEndpoints(this WebApplication app)
    {
        app.MapPost("/order", (CreateOrderCommand request) =>
        {
            if(request is null)
            {
                return Results.BadRequest();
            }

            var command = CreateOrderCommand.Create(request.OrderId, request.ProductType, request.Quantity);

            throw new NotImplementedException();
        })
        .WithName("Create Order");
    }
}