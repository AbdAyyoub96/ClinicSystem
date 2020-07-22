using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessClinicSystem.Entity
{
   public class TestOrder
    {
        public int Id { get; set; }
        public string Test_Name { get; set; }
        public string Test_Details { get; set; }
        public string Test_Report { get; set; }
        [ForeignKey("visit")]
        public int Visit_id { get; set; }
        public NewVisit visit { get; set; }

    }
}
