using Volo.Abp.Reflection;

namespace ZW.AttSvc.Permissions;


public class AttSvcPermissions
{
    public const string GroupName = "AttSvc";

    public static class Attendances
    {
        public const string Default = GroupName + ".Attendances ";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
        public const string Get = Default + ".Get";
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AttSvcPermissions));
    }
}

