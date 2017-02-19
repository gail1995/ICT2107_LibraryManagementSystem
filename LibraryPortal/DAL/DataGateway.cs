using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LibraryPortal.DAL
{
    public class DataGateway<T> : IDataGateway<T> where T : class
    {
        internal LibraryManagementContext db = new LibraryManagementContext();
        internal DbSet<T> data = null;

        public DataGateway()
        {
            this.data = db.Set<T>();
        }

        public T Delete(int id)
        {
            T obj = data.Find(id);
            data.Remove(obj);
            db.SaveChanges();
            return obj;
        }

        public void Insert(T obj)
        {
            data.Add(obj);
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<T> SelectAll()
        {
            return data;
        }

        public T SelectById(int id)
        {
            T obj = data.Find(id);
            return obj;
        }

        public void Update(T obj, int id)
        {
            T obj2 = data.Find(id);
            db.Entry(obj2).CurrentValues.SetValues(obj);
            db.SaveChanges();
        }
    }
}