using Bookify.Application.Abstractions.Email;

namespace Bookify.Infrastucture.Email;
internal class EmailService : IEmailService
{
    public Task SendAsync(Domain.Users.ValueObjects.Email recipient, string subject, string body)
    {
        return Task.CompletedTask;
    }
}
