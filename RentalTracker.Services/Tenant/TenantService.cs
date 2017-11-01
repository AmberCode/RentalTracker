using System;
using System.Collections.Generic;
using System.Linq;
using Common.Model;
using RentalTracker.DAL.Context;

namespace RentalTracker.Services.Tenant
{
    public class TenantService : ITenantService
    {
        public int Save(TenantModel model)
        {
            try
            {
                using (var context = new RentalTrackerEntities())
                {
                    DAL.Context.Tenant entity;

                    if (model.Id <= 0)
                    {
                        entity = context.Tenants.Create();
                        context.Tenants.Add(entity);
                    }
                    else
                    {
                        entity = context.Tenants.Single(x => x.Id == model.Id);
                    }

                    entity.PropertyId = model.PropertyId;
                    entity.Name = model.Name;
                    entity.StartDate = model.StartDate;
                    entity.EndDate = model.EndDate;
                    entity.RentalPrice = model.RentalPrice;

                    return context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                //log ex
                throw;
            }
        }

        public IEnumerable<TenantModel> GetByPropertyId(int propertyId)
        {
            try
            {
                using (var context = new RentalTrackerEntities())
                {
                    return context.Tenants.Where(x => x.PropertyId == propertyId).Select(x => new TenantModel
                    {
                        Id = x.Id,
                        PropertyId = x.PropertyId,
                        Name = x.Name,
                        StartDate = x.StartDate,
                        EndDate = x.EndDate,
                        RentalPrice = x.RentalPrice
                    }).ToList();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var context = new RentalTrackerEntities())
                {
                    var t = context.Tenants.Single(x => x.Id == id);

                    context.Tenants.Remove(t);

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                //log ex
                throw;
            }
        }
    }
}
