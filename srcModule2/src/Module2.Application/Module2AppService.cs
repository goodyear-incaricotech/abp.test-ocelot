
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace Module2
{
    public class Module2AppService : ApplicationService, IModule2AppService
    {
        public string Get() => "Module2";
        public Task<string> GetModule() => Task.FromResult("Module2");
    }
}
