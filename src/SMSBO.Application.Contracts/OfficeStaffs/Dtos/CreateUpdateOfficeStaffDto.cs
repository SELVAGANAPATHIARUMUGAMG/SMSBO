using System;
using System.ComponentModel;
namespace SMSBO.OfficeStaffs.Dtos
{
    [Serializable]
    public class CreateUpdateOfficeStaffDto
    {
        public string Name { get; set; }

        public string ContextNo { get; set; }

        public int Age { get; set; }

        public Position Position { get; set; } = Position.Clerk;

        public string Address { get; set; }
    }
}