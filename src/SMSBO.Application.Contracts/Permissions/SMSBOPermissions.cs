namespace SMSBO.Permissions;

public static class SMSBOPermissions
{
    public const string GroupName = "SMSBO";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

        public class Teacher
        {
            public const string Default = GroupName + ".Teacher";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
}
