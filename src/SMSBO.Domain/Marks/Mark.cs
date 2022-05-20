using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SMSBO.Marks
{
    public class Mark : FullAuditedEntity<Guid>
    {
        public ExamTypes ExamType { get; set; }
        [Range(0,100)]
        public int Tamil { get; set; }
        [Range(0, 100)]
        public int English { get; set; }
        [Range(0, 100)]
        public int Maths { get; set; }
        [Range(0, 100)]
        public int Science { get; set; }
        [Range(0, 100)]
        public int SocialScience { get; set; }
        public  Guid StudentId { get; set; }

        protected Mark() { }

        public Mark(
            Guid id,
            ExamTypes examType,
            int tamil,
            int english,
            int maths,
            int science,
            int socialScience,
            Guid studentId
        ) : base(id)
        {
            ExamType = examType;
            Tamil = tamil;
            English = english;
            Maths = maths;
            Science = science;
            SocialScience = socialScience;
            StudentId = studentId;
        }
    }
}
