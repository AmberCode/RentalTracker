using Common.Model;
using System.Collections.Generic;

namespace RentalTracker.Services.Tenant
{
    public interface ITenantService
    {
        int Save(TenantModel model);
        void Delete(int id);
        IEnumerable<TenantModel> GetByPropertyId(int propertyId);
    }
}
