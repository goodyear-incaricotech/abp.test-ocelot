
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Aspects;
using Volo.Abp.Auditing;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Uow;
using Volo.Abp.Validation;

namespace Module1
{
    public class Module1AppService : ApplicationService, IModule1AppService
    {
        public string Get() => "Module1";
        public Task<string> GetModule() => Task.FromResult("Module1");
    }
}
