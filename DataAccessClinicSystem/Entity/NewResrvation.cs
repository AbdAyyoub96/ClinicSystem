using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessClinicSystem.Entity
{
   public class NewResrvation
    {
        public int Id { get; set; }
        [ForeignKey("patint")]
        public int Patint_id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int Status { get; set; }
        [ForeignKey("user")]
        public int User_id { get; set; }
        public NewPatint patint { get; set; }
        public User user { get; set; }
    }
}
