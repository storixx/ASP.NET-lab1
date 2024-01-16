using System.Text.Json;
using WebApplication1;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Завдання 1
var myCompany = new Company
{
    Name = "Storix Corp",
    Address = "Random street, 123",
    EmployeeCount = 35
};

app.Run(async (context) =>
{
    string json = JsonSerializer.Serialize(myCompany);
    context.Response.ContentType = "application/json";
    await context.Response.WriteAsync(json);
});

// Завдання 2
/*
app.Run(async (context) =>
{
    Random random = new Random();
    int randomNumber = random.Next(0, 101);
    await context.Response.WriteAsync(randomNumber.ToString());
});
*/

app.Run();