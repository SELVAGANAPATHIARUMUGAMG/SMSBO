using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SMSBO.Marks.Dtos
{
    public class StudentLookupDto : EntityDto<Guid>
    {
        public string Name { get; set; }

    }
}
