using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccessClinicSystem.Entity;

namespace DataAccessClinicSystem.Context
{
    public class ClinicSystemContext:DbContext
    {
        public ClinicSystemContext() : base("name = Clinic")
        {

        }
        public virtual DbSet<Accessed> Accesseds { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Diognostics> Diognostics { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<NewPatint> NewPatints { get; set; }
        public virtual DbSet<NewResrvation> NewResrvations { get; set; }
        public virtual DbSet<NewVisit> NewVisits { get; set; }
        public virtual DbSet<Precviption> Precviptions { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<Symptoms> Symptoms { get; set; }
        public virtual DbSet<TestOrder> TestOrders { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
