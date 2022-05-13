using System;
using Volo.Abp.Application.Dtos;

namespace SMSBO.OfficeStaffs.Dtos
{
    [Serializable]
    public class OfficeStaffDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string ContextNo { get; set; }

        public int Age { get; set; }

        public Position Position { get; set; }

        public string Address { get; set; }
    }
}