using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessClinicSystem.Entity
{
   public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("country")]
        public int Country_id { get; set; }
        public Country country { get; set; }
        public List<NewPatint> patints { get; set; }
    }
}
