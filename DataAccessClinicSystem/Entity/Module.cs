using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessClinicSystem.Entity
{
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Order { get; set; }
        public string Path { get; set; }
        public int SubModule { get; set; }
        public List<Accessed> accesseds { get; set; }


    }
}
