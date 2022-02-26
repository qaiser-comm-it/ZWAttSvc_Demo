using Volo.Abp.Settings;

namespace ZW.Settings;

public class ZWSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ZWSettings.MySetting1));
    }
}
