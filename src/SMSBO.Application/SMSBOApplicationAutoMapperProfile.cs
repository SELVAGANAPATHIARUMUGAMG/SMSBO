using SMSBO.Teachers;
using SMSBO.Teachers.Dtos;
using SMSBO.OfficeStaffs;
using SMSBO.OfficeStaffs.Dtos;
using SMSBO.Vehicledetails;
using SMSBO.Vehicledetails.Dtos;
using AutoMapper;

namespace SMSBO;

public class SMSBOApplicationAutoMapperProfile : Profile
{
    public SMSBOApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

            CreateMap<Teacher, TeacherDto>();
            CreateMap<CreateUpdateTeacherDto, Teacher>(MemberList.Source);

            CreateMap<OfficeStaff, OfficeStaffDto>();
            CreateMap<CreateUpdateOfficeStaffDto, OfficeStaff>(MemberList.Source);
            CreateMap<Vehicledetail, VehicledetailDto>();
            CreateMap<CreateUpdateVehicledetailDto, Vehicledetail>(MemberList.Source);
    }
}
