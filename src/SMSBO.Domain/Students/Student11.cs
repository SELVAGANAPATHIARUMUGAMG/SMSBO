using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SMSBO.Students
{
    public class Student11 : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public int Age { get; set; }
        public Departments Department { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string EmailID { get; set; }
        protected Student11() { }

        public Student11(
            Guid id,
            string name,
            string regNumber,
            int age,
            Departments department,
            string address,
            string mobileNumber,
            string emailID
        ) : base(id)
        {
            Name = name;
            RegNumber = regNumber;
            Age = age;
            Department = department;
            Address = address;
            MobileNumber = mobileNumber;
            EmailID = emailID;
        }
    }
}
