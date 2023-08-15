using Bookify.Application.Abstractions.Clock;

namespace Bookify.Infrastucture.Clock;
internal class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
