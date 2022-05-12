using System;
using SMSBO.Teachers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Teachers
{
    public interface ITeacherAppService :
        ICrudAppService< 
            TeacherDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateTeacherDto,
            CreateUpdateTeacherDto>
    {

    }
}