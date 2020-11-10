using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace ModuleCommons
{
    public interface IModuleAppService : IApplicationService, IRemoteService
    {
        Task<string> GetModule();
    }
}
