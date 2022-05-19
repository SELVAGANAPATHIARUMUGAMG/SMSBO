using SMSBO.Teachers;
using SMSBO.Teachers.Dtos;
using SMSBO.OfficeStaffs;
using SMSBO.OfficeStaffs.Dtos;
using SMSBO.Vehicledetails;
using SMSBO.Vehicledetails.Dtos;
using SMSBO.Students;
using SMSBO.Students.Dtos;
using SMSBO.Marks;
using SMSBO.Marks.Dtos;
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
            CreateMap<Student, StudentDto>();
            CreateMap<CreateUpdateStudentDto, Student>(MemberList.Source);
            CreateMap<Student11, Student11Dto>();
            CreateMap<CreateUpdateStudent11Dto, Student11>(MemberList.Source);
            CreateMap<Student12, Student12Dto>();
            CreateMap<CreateUpdateStudent12Dto, Student12>(MemberList.Source);
            
            CreateMap<Mark, MarkDto>();
            CreateMap<CreateUpdateMarkDto, Mark>(MemberList.Source);
            CreateMap<Mark11, Mark11Dto>();
            CreateMap<CreateUpdateMark11Dto, Mark11>(MemberList.Source);
            CreateMap<Mark12, Mark12Dto>();
            CreateMap<CreateUpdateMark12Dto, Mark12>(MemberList.Source);
    }
}
