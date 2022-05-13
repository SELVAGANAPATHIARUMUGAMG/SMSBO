using System;
using Volo.Abp.Application.Dtos;

namespace SMSBO.Vehicledetails.Dtos
{
    [Serializable]
    public class VehicledetailDto : FullAuditedEntityDto<Guid>
    {
        public int Number { get; set; }

        public string RNumber { get; set; }

        public string StartFrom { get; set; }

        public string End { get; set; }

        public int NoOfSheets { get; set; }
    }
}