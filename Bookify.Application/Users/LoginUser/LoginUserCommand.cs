using Bookify.Application.Abstractions.Messaging;
using Bookify.Application.Users.LoginUser.DTO;

namespace Bookify.Application.Users.LoginUser;

public sealed record LoginUserCommand(string Email, string Password)
    : IСommand<AccessTokenResponse>;
