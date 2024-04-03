using TungTest.Application;
var builder = WebApplication.CreateBuilder(args);{
builder.Services.AddApplication();
builder.Services.AddControllers();
}
// Add services to the container.

var app = builder.Build();{

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

}

