using System;
using System.ComponentModel;
namespace SMSBO.Vehicledetails.Dtos
{
    [Serializable]
    public class CreateUpdateVehicledetailDto
    {
        public int Number { get; set; }

        public string RNumber { get; set; }

        public string StartFrom { get; set; }

        public string End { get; set; }

        public int NoOfSheets { get; set; }
    }
}