using GoodHambuerger.Application.Models;
using GoodHambuerger.Application.Services;

namespace GoodHambuerger.API.ApiEndpoints;

public static class ItemsEndpoints
{
    public static void MapItemsEndpoints(this WebApplication app)
    {
        app.MapGet("/items", (IItemService service) =>
        {
            var result = service.ListItems();

            return Results.Ok(result.Data);
        })
            .WithName("ListItems")
            .WithOpenApi();

        app.MapGet("/items/sandwiches", (IItemService service) =>
        {
            var result = service.ListSandwichesOnly();

            return Results.Ok(result.Data);
        })
            .WithName("ListItemsSandwiches")
            .WithOpenApi();

        app.MapGet("/items/extras", (IItemService service) =>
        {
            var result = service.ListExtrasOnly();

            return Results.Ok(result.Data);
        })
           .WithName("ListItemsExtras")
           .WithOpenApi();
    }
}
