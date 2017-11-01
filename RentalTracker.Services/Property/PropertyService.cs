using System;
using System.Collections.Generic;
using System.Linq;
using Common.Model;
using RentalTracker.DAL.Context;

namespace RentalTracker.Services.Property
{
    public class PropertyService : IPropertyService
    {
        public int Save(PropertyModel model)
        {
            try
            {
                using (var context = new RentalTrackerEntities())
                {
                    DAL.Context.Property entity;

                    if (model.Id <= 0)
                    {
                        entity = context.Properties.Create();
                        entity.Created = DateTime.Now;
                        context.Properties.Add(entity);
                    }
                    else
                    {
                        entity = context.Properties.Single(x=>x.Id == model.Id);

                    }

                    entity.PropertyName = model.PropertyName;
                    entity.Address = model.Address;
                    entity.Address2 = model.Address2;
                    entity.City = model.City;
                    entity.State = model.State;
                    entity.ZipCode = model.ZipCode;
                    entity.OwnerName = model.OwnerName;
                    
                    return context.SaveChanges();
                }

            }
            catch(Exception ex)
            {
                //log ex
                throw;
            }
        }

        public IEnumerable<PropertyModel> GetAll()
        {
            try
            {
                using (var context = new RentalTrackerEntities())
                {
                    return context.Properties.Select(x => new PropertyModel
                    {
                        Id = x.Id,
                        PropertyName = x.PropertyName,
                        Address = x.Address,
                        Address2 = x.Address2,
                        City = x.City,
                        State = x.State,
                        ZipCode = x.ZipCode,
                        OwnerName = x.OwnerName
                    }).ToList();
                }
            }
            catch(Exception ex)
            {
                //log ex
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var context = new RentalTrackerEntities())
                {
                    foreach (var t in context.Tenants.Where(x=>x.PropertyId == id))
                    {
                        context.Tenants.Remove(t);
                    }

                    var p = context.Properties.Single(x => x.Id == id);

                    context.Properties.Remove(p);

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
