using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DataAccessClinicSystem.Entity;
using ClinicSystemBusinessLogic.SpeceficRepesitory;
using System.Web.Http;

namespace ClinicSystemApi.Controllers
{
    public class ModuleController : ApiController
    {
        [HttpGet]
        [Route("api/Module/SubMoudle")]
        public List<Module> Loadddl()
        {
            IModule module = new ModuleRep();
            return module.Loadmodules();
        }
        [HttpGet]
        [Route("api/Module/MainMoudle")]
        public List<Module> LoadMain()
        {
            IModule module = new ModuleRep();
            return module.LoadMain();
        }
        [HttpPost]
        [Route ("api/Module/Save")]
        public void Save(Module mod)
        {
            IModule modu = new ModuleRep();
            modu.Insert(mod);
        }
        [HttpPost]
        [Route ("api/Module/Update")]
        public void Update(Module mod)
        {
            IModule modu = new ModuleRep();
            modu.Update(mod);
        }
        [HttpPost]
        [Route("api/Module/Deletemod/{id}")]
        public void Delete(int id)
        {
            IModule modu = new ModuleRep();
            modu.Delete(id);
        }

        [HttpGet]
        [Route("api/Module/Load/{id}")]
        public Module Load(int id)
        {
            IModule modu = new ModuleRep();
            return modu.Load(id);
        }

    }
}
