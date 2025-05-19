using Microsoft.EntityFrameworkCore;
using Monday.Repository.Implementation;
using Monday.Repository.Interfaces;
using Monday.Services.Implementation;
using Monday.Services.Interface;
using Monday.Services.Interface.Monday.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Create services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAddressService, AddressService>();
//builder.Services.AddScoped<ICheckoutProductService, CheckoutProductService>();
builder.Services.AddScoped<ICheckoutService, CheckoutService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IPaymentMethodService, PaymentMethodService>();


builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<ICheckoutProductRepository, CheckoutProductRepository>();
builder.Services.AddScoped<ICheckoutRepository, CheckoutRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IJobRepository, JobRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();


builder.Services.AddDbContext<DbContextMonday>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
