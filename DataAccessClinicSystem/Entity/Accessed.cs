using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessClinicSystem.Entity
{
    public class Accessed
    {
        public int Id { get; set; }
        [ForeignKey("group")]
        public int Group_id { get; set; }
        [ForeignKey("module")]
        public int Module_id { get; set; }
        public Group group { get; set; }
        public Module module { get; set; }
    }
}
