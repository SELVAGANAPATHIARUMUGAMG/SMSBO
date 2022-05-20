using System;
using Volo.Abp.Application.Dtos;

namespace SMSBO.Marks.Dtos
{
    [Serializable]
    public class MarkDto : FullAuditedEntityDto<Guid>
    {
        public ExamTypes ExamType { get; set; }

        public int Tamil { get; set; }

        public int English { get; set; }

        public int Maths { get; set; }

        public int Science { get; set; }

        public int SocialScience { get; set; }
        public Guid StudentId { get; set; }
        public string Name { get; set; }
    }
}