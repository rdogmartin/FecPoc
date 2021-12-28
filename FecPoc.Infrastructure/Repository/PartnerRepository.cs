using FecPoc.Core.Aggregates;

namespace FecPoc.Infrastructure.Repository;

public class PartnerRepository : Repository<Partner, FecContext>
{
    public PartnerRepository(FecContext context) : base(context)
    {

    }
    // We can add new methods specific to the partner repository here in the future
}