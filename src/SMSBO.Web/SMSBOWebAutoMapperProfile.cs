using SMSBO.Teachers.Dtos;
using SMSBO.Web.Pages.Teachers.Teacher.ViewModels;
using SMSBO.OfficeStaffs.Dtos;
using SMSBO.Web.Pages.OfficeStaffs.OfficeStaff.ViewModels;
using SMSBO.Vehicledetails.Dtos;
using SMSBO.Web.Pages.Vehicledetails.Vehicledetail.ViewModels;
using SMSBO.Students.Dtos;
using SMSBO.Web.Pages.Students.Student.ViewModels;
using SMSBO.Web.Pages.Students.Student11.ViewModels;
using SMSBO.Web.Pages.Students.Student12.ViewModels;
using SMSBO.Marks.Dtos;
using SMSBO.Web.Pages.Marks.Mark.ViewModels;
using SMSBO.Marks.Dtos;
using SMSBO.Web.Pages.Marks.Mark11.ViewModels;
using SMSBO.Marks.Dtos;
using SMSBO.Web.Pages.Marks.Mark12.ViewModels;
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
            CreateMap<StudentDto, CreateEditStudentViewModel>();
            CreateMap<CreateEditStudentViewModel, CreateUpdateStudentDto>();
            CreateMap<Student11Dto, CreateEditStudent11ViewModel>();
            CreateMap<CreateEditStudent11ViewModel, CreateUpdateStudent11Dto>();
            CreateMap<Student12Dto, CreateEditStudent12ViewModel>();
            CreateMap<CreateEditStudent12ViewModel, CreateUpdateStudent12Dto>();
            
            CreateMap<MarkDto, CreateEditMarkViewModel>();
            CreateMap<CreateEditMarkViewModel, CreateUpdateMarkDto>();
            CreateMap<Mark11Dto, CreateEditMark11ViewModel>();
            CreateMap<CreateEditMark11ViewModel, CreateUpdateMark11Dto>();
            CreateMap<Mark12Dto, CreateEditMark12ViewModel>();
            CreateMap<CreateEditMark12ViewModel, CreateUpdateMark12Dto>();
    }
}
