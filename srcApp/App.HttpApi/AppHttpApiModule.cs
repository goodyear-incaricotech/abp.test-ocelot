using Localization.Resources.AbpUi;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.TenantManagement;

namespace App
{
    [DependsOn(
        typeof(AppApplicationContractsModule),
        typeof(AbpFeatureManagementHttpApiModule)
        )]
    public class AppHttpApiModule : AbpModule
    {
    }
}
