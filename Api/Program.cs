using Api.Models.DapperContext;
using Api.Repositories.BottomGridRep;
using Api.Repositories.Category;
using Api.Repositories.PopulerLocationRep;
using Api.Repositories.ProductRep;
using Api.Repositories.ServiceRep;
using Api.Repositories.WhoWeAreRepository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRep, CategoryRep>();
builder.Services.AddTransient<IServiceRep, ServiceRep>();
builder.Services.AddTransient<IProductRep, ProductRep>();
builder.Services.AddTransient<IBottomGridRep, BottomGridRep>();
builder.Services.AddTransient<IWhoWeAreDetailRep, WhoWeAreDetailRep>();
builder.Services.AddTransient<IPopularLocationRep, PopularLocationRep>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();