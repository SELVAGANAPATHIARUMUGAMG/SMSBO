using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SMSBO.OfficeStaffs
{
    public class OfficeStaff : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string ContextNo { get; set; }
        public int Age { get; set; }
        public Position Position { get; set; }
        public string Address { get; set; }

        protected OfficeStaff()
        {
        }

        public OfficeStaff(
            Guid id,
            string name,
            string contextNo,
            int age,
            Position position,
            string address
        ) : base(id)
        {
            Name = name;
            ContextNo = contextNo;
            Age = age;
            Position = position;
            Address = address;
        }
    }
}
