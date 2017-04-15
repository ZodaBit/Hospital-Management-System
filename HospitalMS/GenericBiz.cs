using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMS
{
    public class GenericBiz<T> where T : class
    {
        public virtual Response<T> Add(T entity)
        {
            try
            {
                using (HMSgeneralentity db = new HMSgeneralentity())
                {
                    db.Set<T>().Add(entity);
                    db.SaveChanges();
                };
                return new SucessResponse<T>(entity);
            }
            catch(Exception ex)
            {
                return new FailureResponse<T>(ex);
            }
        }

        public virtual Response<T> Update(T entity)
        {
            try
            {
                using (HMSgeneralentity db = new HMSgeneralentity())
                {
                    if (db.Entry(entity).State == EntityState.Detached)
                        db.Set<T>().Attach(entity);

                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                };
                return new SucessResponse<T>(entity);
            }
            catch (Exception ex)
            {
                return new FailureResponse<T>(ex);
            }
        }

        public virtual Response<T> Delete(T entity)
        {
            try
            {
                using (HMSgeneralentity db = new HMSgeneralentity())
                {
                    db.Set<T>().Remove(entity);
                    db.SaveChanges();
                };
                return new SucessResponse<T>(entity);
            }
            catch (Exception ex)
            {
                return new FailureResponse<T>(ex);
            }
        }

        public virtual Response<T> Delete(int Id)
        {
            try
            {
                using (HMSgeneralentity db = new HMSgeneralentity())
                {
                    db.Set<T>().Remove(db.Set<T>().Find(Id));
                    db.SaveChanges();
                };
                return new SucessResponse<T>();
            }
            catch (Exception ex)
            {
                return new FailureResponse<T>(ex);
            }
        }

        public virtual IEnumerable<T> Get(params string[] includes)
        {
            using (HMSgeneralentity db = new HMSgeneralentity())
            {
                var query = db.Set<T>() as IQueryable<T>;

                foreach (string include in includes)
                {
                    query = query.Include(include);
                }

                return query.ToList();
            }

        }

        public virtual T Find<T>(int Id, params string[] includes) where T : class, IEntityWithId
        {
            using (HMSgeneralentity db = new HMSgeneralentity())
            {
                IQueryable<T> entityQuery = db.Set<T>();

                foreach (var include in includes)
                {
                    entityQuery = entityQuery.Include(include);
                }

                return entityQuery.SingleOrDefault(e => e.Id == Id);
            }
        }
    }
}
