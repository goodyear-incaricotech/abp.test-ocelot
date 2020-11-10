using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;

namespace ModuleCommons
{
    [DependsOn(
        typeof(ModuleApplicationContractsModule),
        typeof(AbpFeatureManagementHttpApiClientModule)
    )]
    public class ModuleHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(IModuleAppService).Assembly,
                RemoteServiceName
            );
        }
    }
}
