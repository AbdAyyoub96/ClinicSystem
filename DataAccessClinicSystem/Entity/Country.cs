using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessClinicSystem.Entity
{
   public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NewPatint> newPatints { get; set; }
        public List<City> cities { get; set; }
    }
}
