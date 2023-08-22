namespace Bookify.API.Controllers.Users.DTO;

public sealed record RegisterUserRequest(
    string Email,
    string FirstName,
    string LastName,
    string Password);