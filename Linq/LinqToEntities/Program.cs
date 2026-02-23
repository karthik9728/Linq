using LinqToEntities.Models;
using LinqToEntities.Services;

var builder = WebApplication.CreateBuilder(args);

//  Scaffold-DbContext "Host=localhost;Port=5432;Database=EmpManagement;Username=postgres;Password=karthik;TrustServerCertificate=True;" Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir Models -Context EmpManagementContext

// Add services to the container.
builder.Services.AddDbContext<EmpManagementContext>();

builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddControllers();

//builder.Services
//    .AddControllers()
//    .AddNewtonsoftJson(options =>
//    {
//        options.SerializerSettings.ReferenceLoopHandling =
//            Newtonsoft.Json.ReferenceLoopHandling.Ignore;
//    });

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
