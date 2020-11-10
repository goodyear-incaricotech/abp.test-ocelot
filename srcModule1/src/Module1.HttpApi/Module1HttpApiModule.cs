using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.TenantManagement;

namespace Module1
{
    [DependsOn(
        typeof(Module1ApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule)
        )]
    public class Module1HttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options
                    .ConventionalControllers
                    .Create(typeof(Module1ApplicationModule).Assembly,
                    opt =>
                    {
                        opt.RootPath = "M1Root";
                    });
            });
        }
    }
}
