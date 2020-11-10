using ModuleCommons;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Module1
{
    public interface IModule1AppService : IApplicationService, IModuleAppService
    {
    }
}
