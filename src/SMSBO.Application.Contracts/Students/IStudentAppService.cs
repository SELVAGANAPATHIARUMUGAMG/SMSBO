using System;
using SMSBO.Students.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Students
{
    public interface IStudentAppService :
        ICrudAppService< 
            StudentDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateStudentDto,
            CreateUpdateStudentDto>
    {

    }
}