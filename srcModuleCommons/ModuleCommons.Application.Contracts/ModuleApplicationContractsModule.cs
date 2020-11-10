using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;

namespace ModuleCommons
{
    [DependsOn(
        typeof(AbpObjectExtendingModule)
    )]
    public class ModuleApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            ModuleDtoExtensions.Configure();
        }
    }
}
