using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessClinicSystem.Entity
{
   public class Precviption
    {
        public int Id { get; set; }
        public string Drag_Name { get; set; }
        public string Strength { get; set; }
        public string Dirction_for_use { get; set; }
        public string Quantity { get; set; }
        public string Treatment_Details { get; set; }
        [ForeignKey("visit")]
        public int Visit_id { get; set; }
        public NewVisit visit { get; set; }



    }
}
