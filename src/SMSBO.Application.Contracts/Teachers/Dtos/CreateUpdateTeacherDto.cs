using System;
using System.ComponentModel;
namespace SMSBO.Teachers.Dtos
{
    [Serializable]
    public class CreateUpdateTeacherDto
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime DOB { get; set; }

        public string ContextNumber { get; set; }

        public string EmailID { get; set; }
    }
}