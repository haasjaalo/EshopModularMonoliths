using Catalog;
using Basket;
using Ordering;
var builder = WebApplication.CreateBuilder(args);
// Ajouter des services au container
builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);

var app = builder.Build();

// Configure the HTTP Request pipeline

app
    .UseCatalogModule()
    .UseBasketModule()
    .UseOrderingModule();

