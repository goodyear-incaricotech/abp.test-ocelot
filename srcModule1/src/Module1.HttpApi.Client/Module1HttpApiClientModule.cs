using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;

namespace Module1
{
    [DependsOn(
        typeof(Module1ApplicationContractsModule),
        typeof(ModuleCommons.ModuleHttpApiClientModule),
        typeof(AbpFeatureManagementHttpApiClientModule)
    )]
    public class Module1HttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(Module1ApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
