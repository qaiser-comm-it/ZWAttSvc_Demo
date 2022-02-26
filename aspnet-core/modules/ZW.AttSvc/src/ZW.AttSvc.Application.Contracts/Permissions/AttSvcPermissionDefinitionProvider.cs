using ZW.AttSvc.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ZW.AttSvc.Permissions;

public class AttSvcPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var AttSvcGroup = context.AddGroup(AttSvcPermissions.GroupName, L("Permission:AttSvc"));

        var attendancesPermission = AttSvcGroup.AddPermission(AttSvcPermissions.Attendances.Default, L("Permission:Attendances"));
        attendancesPermission.AddChild(AttSvcPermissions.Attendances.Create, L("Permission:Attendances.Create"));
        attendancesPermission.AddChild(AttSvcPermissions.Attendances.Edit, L("Permission:Attendances.Edit"));
        attendancesPermission.AddChild(AttSvcPermissions.Attendances.Delete, L("Permission:Attendances.Delete"));
        attendancesPermission.AddChild(AttSvcPermissions.Attendances.Get, L("Permission:Attendances.Get"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AttSvcResource>(name);
    }
}
