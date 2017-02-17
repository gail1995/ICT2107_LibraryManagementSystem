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
        T SelectById(String id);
        void Insert(T obj);
        void Update(T obj, String id);
        T Delete(String id);
        void Save();
    }
}