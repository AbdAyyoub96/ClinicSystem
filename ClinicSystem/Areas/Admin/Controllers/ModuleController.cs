using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using DataAccessClinicSystem.Entity;
using System.Net.Http;
using Newtonsoft.Json;

namespace ClinicSystem.Areas.Admin.Controllers
{
    public class ModuleController : Controller
    {
        // GET: Admin/Module
        public async Task<ActionResult> ModuleList()
        {
            VMmodule vm = new VMmodule();
            List<Module> moduleList = new List<Module>();
            string ApiUrl = "http://localhost/ClinicSystemApi/api/Module/MainMoudle";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ApiUrl);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.GetAsync(ApiUrl);
            if(responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                moduleList = JsonConvert.DeserializeObject<List<Module>>(responseData);
            }
            vm.Mod = moduleList;
            return View("ModuleList",vm);
        }
        public ActionResult NewModule()
        {
            return View();
        }
    }
}