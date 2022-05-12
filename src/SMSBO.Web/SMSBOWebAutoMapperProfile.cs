using SMSBO.Teachers.Dtos;
using SMSBO.Web.Pages.Teachers.Teacher.ViewModels;
using AutoMapper;

namespace SMSBO.Web;

public class SMSBOWebAutoMapperProfile : Profile
{
    public SMSBOWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
            CreateMap<TeacherDto, CreateEditTeacherViewModel>();
            CreateMap<CreateEditTeacherViewModel, CreateUpdateTeacherDto>();
    }
}
