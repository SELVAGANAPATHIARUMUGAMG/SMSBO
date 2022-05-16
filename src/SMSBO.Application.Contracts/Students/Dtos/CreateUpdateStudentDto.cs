using System;
using System.ComponentModel;
namespace SMSBO.Students.Dtos
{
    [Serializable]
    public class CreateUpdateStudentDto
    {
        public string Name { get; set; }

        public string RegNumber { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public string MobileNumber { get; set; }

        public string EmailID { get; set; }
    }
}