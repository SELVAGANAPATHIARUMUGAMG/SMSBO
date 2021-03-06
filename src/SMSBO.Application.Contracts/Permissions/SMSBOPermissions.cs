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

        public class OfficeStaff
        {
            public const string Default = GroupName + ".OfficeStaff";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Vehicledetail
        {
            public const string Default = GroupName + ".Vehicledetail";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Student
        {
            public const string Default = GroupName + ".Student";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Student11
        {
            public const string Default = GroupName + ".Student11";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Student12
        {
            public const string Default = GroupName + ".Student12";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

       

        public class Mark
        {
            public const string Default = GroupName + ".Mark";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Mark11
        {
            public const string Default = GroupName + ".Mark11";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Mark12
        {
            public const string Default = GroupName + ".Mark12";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
}
