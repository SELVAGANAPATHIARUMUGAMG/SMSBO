using SMSBO.Teachers;
using SMSBO.Teachers.Dtos;
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
    }
}
