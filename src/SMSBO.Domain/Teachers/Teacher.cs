using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SMSBO.Teachers
{
    public class Teacher : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public string ContextNumber { get; set; }
        public string EmailID { get; set; }
        protected Teacher() { }


        public Teacher(
            Guid id,
            string name,
            int age,
            DateTime dOB,
            string contextNumber,
            string emailID
        ) : base(id)
        {
            Name = name;
            Age = age;
            DOB = dOB;
            ContextNumber = contextNumber;
            EmailID = emailID;
        }
    }
}
