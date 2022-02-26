using ZW.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ZW.Permissions;

public class ZWPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ZWPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ZWPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ZWResource>(name);
    }
}
