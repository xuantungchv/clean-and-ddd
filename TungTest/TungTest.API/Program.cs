using TungTest.Application.Services.AuthenticationServices;

var builder = WebApplication.CreateBuilder(args);{

builder.Services.AddScoped<IAuthenticationService,AuthenticationService>();
builder.Services.AddControllers();
}
// Add services to the container.

var app = builder.Build();{

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

}

