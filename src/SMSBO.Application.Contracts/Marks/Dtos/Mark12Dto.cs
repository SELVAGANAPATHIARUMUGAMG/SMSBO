using System;
using Volo.Abp.Application.Dtos;

namespace SMSBO.Marks.Dtos
{
    [Serializable]
    public class Mark12Dto : FullAuditedEntityDto<Guid>
    {
        public int Language { get; set; }

        public int English { get; set; }

        public int Maths { get; set; }

        public int Physcics { get; set; }

        public int Chemistry { get; set; }

        public int ComputerScience { get; set; }
    }
}