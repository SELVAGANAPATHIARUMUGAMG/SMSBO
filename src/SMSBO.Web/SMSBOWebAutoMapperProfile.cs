using SMSBO.Teachers.Dtos;
using SMSBO.Web.Pages.Teachers.Teacher.ViewModels;
using SMSBO.OfficeStaffs.Dtos;
using SMSBO.Web.Pages.OfficeStaffs.OfficeStaff.ViewModels;
using SMSBO.Vehicledetails.Dtos;
using SMSBO.Web.Pages.Vehicledetails.Vehicledetail.ViewModels;
using AutoMapper;

namespace SMSBO.Web;

public class SMSBOWebAutoMapperProfile : Profile
{
    public SMSBOWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
            CreateMap<TeacherDto, CreateEditTeacherViewModel>();
            CreateMap<CreateEditTeacherViewModel, CreateUpdateTeacherDto>();
            CreateMap<OfficeStaffDto, CreateEditOfficeStaffViewModel>();
            CreateMap<CreateEditOfficeStaffViewModel, CreateUpdateOfficeStaffDto>();
            CreateMap<VehicledetailDto, CreateEditVehicledetailViewModel>();
            CreateMap<CreateEditVehicledetailViewModel, CreateUpdateVehicledetailDto>();
    }
}
