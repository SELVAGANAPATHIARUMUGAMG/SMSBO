using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SMSBO.Students
{
    public class Student : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string EmailID { get; set; }
        protected Student() { }

        public Student(
            Guid id,
            string name,
            string regNumber,
            int age,
            string address,
            string mobileNumber,
            string emailID
        ) : base(id)
        {
            Name = name;
            RegNumber = regNumber;
            Age = age;
            Address = address;
            MobileNumber = mobileNumber;
            EmailID = emailID;
        }
    }
}
