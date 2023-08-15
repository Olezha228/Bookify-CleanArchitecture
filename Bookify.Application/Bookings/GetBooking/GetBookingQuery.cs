using Bookify.Application.Abstractions.Messaging;
using Bookify.Application.Bookings.GetBooking.DTO;

namespace Bookify.Application.Bookings.GetBooking;

public sealed record class GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;