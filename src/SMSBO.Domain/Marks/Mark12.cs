using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SMSBO.Marks
{
    public class Mark12 : FullAuditedEntity<Guid>
    {
        [Range(0, 100)]
        public int Language { get; set; }
        [Range(0, 100)]
        public int English { get; set; }
        [Range(0, 100)]
        public int Maths { get; set; }
        [Range(0, 100)]
        public int Physcics { get; set; }
        [Range(0, 100)]
        public int Chemistry { get; set; }
        [Range(0, 100)]
        public int ComputerScience { get; set; }
        protected Mark12() { }

        public Mark12(
            Guid id,
            int language,
            int english,
            int maths,
            int physcics,
            int chemistry,
            int computerScience
        ) : base(id)
        {
            Language = language;
            English = english;
            Maths = maths;
            Physcics = physcics;
            Chemistry = chemistry;
            ComputerScience = computerScience;
        }
    }
}
