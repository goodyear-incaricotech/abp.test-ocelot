using Microsoft.Extensions.DependencyInjection;
using ModuleCommons;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;

namespace Module2
{
    [DependsOn(
        typeof(Module2ApplicationContractsModule),
        typeof(ModuleHttpApiClientModule),
        typeof(AbpFeatureManagementHttpApiClientModule)
    )]
    public class Module2HttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(Module2ApplicationContractsModule).Assembly,
                RemoteServiceName
            );

            //context.Services.AddHttpClientProxies(
            //    typeof(IModuleAppService).Assembly,
            //    RemoteServiceName
            //);
        }
    }
}
