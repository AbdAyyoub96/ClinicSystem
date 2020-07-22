using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessClinicSystem.Entity
{
   public class User
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Profile_picture { get; set; }
        public int Is_Doctor { get; set; }
        [ForeignKey("speciality")]
        public int Specialty_id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public string Confirm_Password { get; set; }
        public DateTime Effective_Date { get; set; }
        public DateTime Expiry_Date { get; set; }
        public int Status { get; set; }
        public DateTime Status_Date { get; set; }
        [ForeignKey("group")]
        public int Group_id {get;set;}
        public Group group { get; set; }
        public Speciality speciality { get; set; }
        public List<NewResrvation> resrvations { get; set; }
        public List<NewVisit> visits { get; set; }



    }
}
