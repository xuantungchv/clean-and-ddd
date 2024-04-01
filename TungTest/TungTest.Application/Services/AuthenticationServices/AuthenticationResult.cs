namespace TungTest.Application.Services.AuthenticationServices;
public record AuthenticationResult(
    Guid id,
    string firstName,
    string lastName,
    string email,
    string token
);