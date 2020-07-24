using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccessClinicSystem.Context;
namespace DataAccessClinicSystem.Genirec
{
    public class Generic<T> : IGeneric<T> where T : class
    {
        public void Delete(object id)
        {
            ClinicSystemContext con = new ClinicSystemContext();
            T del = con.Set<T>().Find(id);
            con.Set<T>().Remove(del);
            con.SaveChanges();
        }

        public void Insert(T obj)
        {
            ClinicSystemContext con = new ClinicSystemContext();
            con.Set<T>().Add(obj);
            con.SaveChanges();
        }

        public T Load(int id)
        {
            ClinicSystemContext con = new ClinicSystemContext();
            return con.Set<T>().Find(id);
            
        }

        public List<T> LoadAll()
        {
            ClinicSystemContext con = new ClinicSystemContext();
            return con.Set<T>().ToList<T>();
        }

        public void Update(T obj)
        {
            ClinicSystemContext con = new ClinicSystemContext();
            con.Set<T>().Attach(obj);
            con.Entry(obj).State = EntityState.Modified;
            con.SaveChanges();
        }
    }

}
