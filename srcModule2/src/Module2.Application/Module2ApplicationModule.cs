using Microsoft.Extensions.DependencyInjection;
using ModuleCommons;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;

namespace Module2
{
    [DependsOn(
        typeof(Module2ApplicationContractsModule)
        )]
    public class Module2ApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<Module2ApplicationModule>();
            });

            context.Services.AddTransient<IModuleAppService>(provider => provider.GetService<Module2AppService>());
        }
    }
}
