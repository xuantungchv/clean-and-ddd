using Microsoft.AspNetCore.Mvc;
using TungTest.Application.Services.AuthenticationServices;
using TungTest.Contracts.Authentication;

namespace TungTest.API.Controller;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;
    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest registerRequest)
    {
        var rs = _authenticationService.Register(registerRequest.FirstName,registerRequest.LastName,registerRequest.Email,registerRequest.Password);
        var response = new AuthenticationResponse(
            rs.id,
           rs.firstName,
           rs.lastName,
           rs.email,
           rs.token
        );
        return Ok(response);
    }
    [HttpPost("login")]
    public IActionResult Login(LoginRequest loginRequest)
    {
        var rs = _authenticationService.Login(loginRequest.Email,loginRequest.Password);
        var response = new AuthenticationResponse(
            rs.id,
           rs.firstName,
           rs.lastName,
           rs.email,
           rs.token
        );
        return Ok(response);
    }
}