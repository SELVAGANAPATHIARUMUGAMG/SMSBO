using System;
using System.ComponentModel;
namespace SMSBO.Marks.Dtos
{
    [Serializable]
    public class CreateUpdateMark12Dto
    {
        public int Language { get; set; }

        public int English { get; set; }

        public int Maths { get; set; }

        public int Physcics { get; set; }

        public int Chemistry { get; set; }

        public int ComputerScience { get; set; }
    }
}