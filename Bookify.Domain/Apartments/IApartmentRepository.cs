﻿namespace Bookify.Domain.Apartments;

public interface IApartmentRepository
{
    Task<Apartment?> GetByIdAsync(ApartmentId id, CancellationToken cancellationToken = default);
}
