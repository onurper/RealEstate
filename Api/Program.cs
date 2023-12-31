using Api.Models.DapperContext;
using Api.Repositories.BottomGridRep;
using Api.Repositories.Category;
using Api.Repositories.EmployeeRep;
using Api.Repositories.PopulerLocationRep;
using Api.Repositories.ProductRep;
using Api.Repositories.ServiceRep;
using Api.Repositories.StatisticsRep;
using Api.Repositories.TestimonialRep;
using Api.Repositories.WhoWeAreRep;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRep, CategoryRep>();
builder.Services.AddTransient<IServiceRep, ServiceRep>();
builder.Services.AddTransient<IProductRep, ProductRep>();
builder.Services.AddTransient<ITestimonialRep, TestimonialRep>();
builder.Services.AddTransient<IBottomGridRep, BottomGridRep>();
builder.Services.AddTransient<IWhoWeAreDetailRep, WhoWeAreDetailRep>();
builder.Services.AddTransient<IPopularLocationRep, PopularLocationRep>();
builder.Services.AddTransient<IEmployeeRep, EmployeeRep>();
builder.Services.AddTransient<IStatisticsRep, StatisticsRep>();

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