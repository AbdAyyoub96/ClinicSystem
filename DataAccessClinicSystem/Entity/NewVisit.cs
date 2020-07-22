using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccessClinicSystem.Entity
{
   public class NewVisit
    {
        public int Id { get; set; }
        public int Visit_Type { get; set; }
        public string Visit_Reson { get; set; }
        public string Doctor_report { get; set; }
        public string Bp_Systolic { get; set; }
        public string Bp_Diastolic { get; set; }
        public string Tempruture { get; set; }
        public string Respority_rate { get; set; }
        public string Heigth { get; set; }
        public string plus { get; set; }
        public string Weigth { get; set; }
        [ForeignKey("patint")]
        public int Patint_id { get; set; }
        [ForeignKey("user")]
        public int User_id { get; set; }
        public NewPatint patint { get; set; }
        public User user { get; set; }
        public List<Symptoms> symptoms { get; set; }
        public List<TestOrder> testOrders { get; set; }
        public List<Diognostics> diognostics { get; set; }
        public List<Precviption> precviptions { get; set; }

    }
}
