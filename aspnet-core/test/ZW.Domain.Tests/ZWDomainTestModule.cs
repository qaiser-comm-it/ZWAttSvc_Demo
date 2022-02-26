using ZW.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ZW;

[DependsOn(
    typeof(ZWEntityFrameworkCoreTestModule)
    )]
public class ZWDomainTestModule : AbpModule
{

}
