using System;
using Volo.Abp.Application.Dtos;

namespace SMSBO.Marks.Dtos
{
    [Serializable]
    public class Mark11Dto : FullAuditedEntityDto<Guid>
    {
        public int Tamil { get; set; }

        public int English { get; set; }

        public int Maths { get; set; }

        public int Science { get; set; }

        public int SocialScience { get; set; }
    }
}