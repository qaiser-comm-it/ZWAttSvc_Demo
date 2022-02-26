using Volo.Abp.Modularity;

namespace ZW;

[DependsOn(
    typeof(ZWApplicationModule),
    typeof(ZWDomainTestModule)
    )]
public class ZWApplicationTestModule : AbpModule
{

}
