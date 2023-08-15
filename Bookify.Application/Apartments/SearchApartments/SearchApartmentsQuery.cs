using Bookify.Application.Abstractions.Messaging;
using Bookify.Application.Apartments.SearchApartments.DTO;

namespace Bookify.Application.Apartments.SearchApartments;

public sealed record SearchApartmentsQuery(
    DateOnly StartDate,
    DateOnly EndDate): IQuery<IReadOnlyList<ApartmentResponse>>;