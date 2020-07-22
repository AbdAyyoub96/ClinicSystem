﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccessClinicSystem.Genirec
{
  public interface IGeneric <T> where T :class
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        T Load(int id);
        List<T> LoadAll();

    }
}
