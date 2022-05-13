using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SMSBO.Vehicledetails
{
    public class Vehicledetail :FullAuditedEntity<Guid>
    {
        public int Number { get; set; }
        public string RNumber { get; set; }
        public string StartFrom { get; set; }
        public string End { get; set; }
        public int NoOfSheets { get; set; }
        protected Vehicledetail() { }

        public Vehicledetail(
            Guid id,
            int number,
            string rNumber,
            string startFrom,
            string end,
            int noOfSheets
        ) : base(id)
        {
            Number = number;
            RNumber = rNumber;
            StartFrom = startFrom;
            End = end;
            NoOfSheets = noOfSheets;
        }
    }
}
