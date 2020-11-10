using Volo.Abp.Account;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.TenantManagement;

namespace Module2
{
    [DependsOn(
        typeof(Module2ApplicationContractsModule),
        typeof(AbpFeatureManagementHttpApiModule)
        )]
    public class Module2HttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options
                    .ConventionalControllers
                    .Create(typeof(Module2ApplicationModule).Assembly,
                    opt =>
                    {
                        opt.RootPath = "M2Root";
                    });
            });
        }
    }
}
