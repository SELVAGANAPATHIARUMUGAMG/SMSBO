using System;
using Volo.Abp.Application.Dtos;

namespace SMSBO.Teachers.Dtos
{
    [Serializable]
    public class TeacherDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime DOB { get; set; }

        public string ContextNumber { get; set; }

        public string EmailID { get; set; }
    }
}