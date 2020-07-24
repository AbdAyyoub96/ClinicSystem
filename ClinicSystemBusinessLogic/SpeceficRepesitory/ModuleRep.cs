using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessClinicSystem.Entity;
using DataAccessClinicSystem.Context;
using DataAccessClinicSystem.Genirec;
using System.Data.Entity;

namespace ClinicSystemBusinessLogic.SpeceficRepesitory
{
    public class ModuleRep : IModule
    {
        
        public void Insert(Module mod)
        {
            IGeneric<Module> modu = new Generic<Module>();
            modu.Insert(mod);
        }
        public void Update(Module mod)
        {
            IGeneric<Module> modu = new Generic<Module>();
            modu.Update(mod);
        }

        public List<Module> Loadmodules()
        {
            ClinicSystemContext con = new ClinicSystemContext();
            List<Module> SubModules = (from a in con.Modules
                                       where a.SubModule == 0
                                       select a).ToList<Module>();
            return SubModules;
        }

        public List<Module> LoadMain()
        {
            ClinicSystemContext con = new ClinicSystemContext();
            List<Module> MainModules = (from a in con.Modules
                                       select a).ToList<Module>();
            return MainModules;
        }

        public void Delete(int x)
        {
            IGeneric<Module> modu = new Generic<Module>();
            modu.Delete(x);
        }
        public Module Load(int x)
        {
            IGeneric<Module> modu = new Generic<Module>();
            return modu.Load(x);
        }
    }
}
