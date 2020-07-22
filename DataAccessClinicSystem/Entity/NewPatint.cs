using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessClinicSystem.Entity
{
    public class NewPatint
    {
        public int Id { get; set; }
        public  string FirstName  { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public int Marital { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [ForeignKey("country")]
        public int Country_id { get; set; }
        [ForeignKey("city")]
        public int City_id { get; set; }
        public string Adress { get; set; }
        public Country country { get; set; }
        public City city { get; set; }
        public List<NewResrvation> resrvations { get; set; }
        public List<NewVisit> visits { get; set; }

    }
}
