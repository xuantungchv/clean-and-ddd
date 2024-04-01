namespace TungTest.Application.Services.AuthenticationServices;
public  interface IAuthenticationService  
{
    AuthenticationResult Register(string firstName,string lastName,string email, string passWord);
    AuthenticationResult Login(string email, string passWord);
}