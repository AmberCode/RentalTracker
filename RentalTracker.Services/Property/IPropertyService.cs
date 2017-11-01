using Common.Model;
using System.Collections.Generic;

namespace RentalTracker.Services.Property
{
    public interface IPropertyService
    {
        int Save(PropertyModel model);
        void Delete(int id);
        IEnumerable<PropertyModel> GetAll();
    }
}
