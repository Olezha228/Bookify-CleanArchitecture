namespace Bookify.API.Controllers.Bookings.DTO;

public record ReserveBookingRequest(
    Guid ApartmentId, 
    Guid UserId, 
    DateOnly StartDate, 
    DateOnly EndDate);