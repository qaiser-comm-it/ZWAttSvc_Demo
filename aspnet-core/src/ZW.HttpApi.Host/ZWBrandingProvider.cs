using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ZW;

[Dependency(ReplaceServices = true)]
public class ZWBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ZW";
}
