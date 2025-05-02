using GoodHambuerger.Application.Models;
using GoodHambuerger.Application.Services;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace GoodHambuerger.API.ApiEndpoints;

public static class OrdersEntpoints
{
    public static void MapOrdersEndpoints(this WebApplication app)
    {
        app.MapPost("/orders", (OrderItemsInputModel model, IOrderService service) =>
        {
            var result = service.CreateOrder(model);

            if (result.IsSuccess)
            {
                return Results.Created(string.Empty, result);
            }

            return Results.BadRequest(result);
        })
            .WithName("SendOrder")
            .WithOpenApi();

        app.MapGet("/orders", (IOrderService service) =>
        {
            var result = service.ListOrders();

            return Results.Ok(result.Data);
        })
            .WithName("ListOrders")
            .WithOpenApi();

        app.MapPut("/orders", (OrderItemsUpdateInputModel model, IOrderService service) =>
        {
            var result = service.UpdateOrder(model);

            if (result.IsSuccess)
            {
                return Results.NoContent();
            }

            return Results.BadRequest(result.Message);
        });

        app.MapDelete("/orders/{id:int}", (int id, IOrderService service) =>
        {
            var result = service.DeleteOrder(id);

            if (result.IsSuccess)
            {
                return Results.NoContent();
            }

            return Results.NotFound(result.Message);
        });
            
    }
}
