using System;
using System.ComponentModel;
namespace SMSBO.Marks.Dtos
{
    [Serializable]
    public class CreateUpdateMarkDto
    {
        public ExamTypes ExamType { get; set; }

        public int Tamil { get; set; }

        public int English { get; set; }

        public int Maths { get; set; }

        public int Science { get; set; }

        public int SocialScience { get; set; }
    }
}