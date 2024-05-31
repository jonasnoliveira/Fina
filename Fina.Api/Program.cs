using Fina.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//db sql server
const string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=fina-db;Integrated Security=True;";

//db postgres
//const string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=PostgreSQL;";

// Add services to the container.
// sql server
builder.Services.AddDbContext<AppDbContext>(
    x => x.UseSqlServer(connectionString));

// Add services to the container.
// postgres
//builder.Services.AddDbContext<AppDbContext>(
    //x => x.UseNpgsql(connectionString));

var app = builder.Build();
app.MapGet("/", () => "Hello World!");

app.Run();
