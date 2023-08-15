using Bookify.Domain.Apartments;

namespace Bookify.Infrastucture.Repositories;
internal sealed class ApartmentRepository : Repository<Apartment, ApartmentId>, IApartmentRepository
{
    public ApartmentRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
