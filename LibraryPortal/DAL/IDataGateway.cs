using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryPortal.Models;

namespace LibraryPortal.DAL
{
    interface IDataGateway<T> where T:class
    {
        IEnumerable<T> SelectAll();
        T SelectById(int id);
        void Insert(T obj);
        void Update(T obj, int id);
        T Delete(int id);
        void Save();
    }
}