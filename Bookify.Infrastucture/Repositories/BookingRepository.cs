﻿using Bookify.Domain.Apartments;
using Bookify.Domain.Bookings;
using Bookify.Domain.Bookings.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastucture.Repositories;

internal sealed class BookingRepository : Repository<Booking, BookingId>, IBookingRepository
{
    private static readonly BookingStatus[] _activeBookingStatuses =
    {
        BookingStatus.Reserved,
        BookingStatus.Confirmed,
        BookingStatus.Completed
    };

    public BookingRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> IsOverlappingAsync(Apartment apartment, DateRange duration, CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<Booking>()
            .AnyAsync(
                booking =>
                    booking.ApartmentId == apartment.Id &&
                    booking.Duration.Start <= duration.End &&
                    booking.Duration.End >= duration.Start &&
                    _activeBookingStatuses.Contains(booking.Status),
                cancellationToken);
    }
}
