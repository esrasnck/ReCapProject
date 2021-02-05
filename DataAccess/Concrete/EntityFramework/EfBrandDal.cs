using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfBrandDal:IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            };
        }

        public void Delete(Brand entity)
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            };
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);

            };
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
                if (filter == null)
                {
                    return context.Set<Brand>().ToList();
                }
                else
                {
                    return context.Set<Brand>().Where(filter).ToList();
                }

            };
        }

        public void Update(Brand entity)
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            };
        }
    }
}
