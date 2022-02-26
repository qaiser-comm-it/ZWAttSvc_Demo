using ZW.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ZW.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ZWEntityFrameworkCoreModule),
    typeof(ZWApplicationContractsModule)
    )]
public class ZWDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
