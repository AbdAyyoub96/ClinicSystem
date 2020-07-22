using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessClinicSystem.Entity;
namespace ClinicSystemBusinessLogic.SpeceficRepesitory
{
   public interface IModule
    {
        List<Module> Loadmodules();
        void Insert(Module mod);
        void Update(Module mod);
        List<Module> LoadMain();
        void Delete(int x);
    }
}
