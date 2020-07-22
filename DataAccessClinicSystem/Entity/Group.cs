using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessClinicSystem.Entity
{
   public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime StatusDate { get; set; }
        public List<Accessed> accesseds { get; set; }
        public List<User> users { get; set; }

    }
}
