using Module1;
using ModuleCommons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace App
{
    public class AppAppService : ApplicationService
    {
        private readonly IEnumerable<IModuleAppService> services;
        private readonly IModule1AppService module1AppService;

        public AppAppService(IEnumerable<IModuleAppService> services)
        {
            this.services = services;
            //this.module1AppService = module1AppService;
        }

        public string Get() => "App";
        public string GetModule() => "App";
        public async Task<string> GetValues()
        {
            var result = "|";

            foreach (var service in services)
            {
                result += ";" + await service.GetModule();
            }

            return result;
        }
    }
}
