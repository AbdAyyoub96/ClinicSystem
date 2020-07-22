using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessClinicSystem.Entity
{
   public class Speciality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> users { get; set; }
    }
}
