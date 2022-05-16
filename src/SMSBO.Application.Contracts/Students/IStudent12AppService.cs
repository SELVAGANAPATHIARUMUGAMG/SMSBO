using System;
using SMSBO.Students.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Students
{
    public interface IStudent12AppService :
        ICrudAppService< 
            Student12Dto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateStudent12Dto,
            CreateUpdateStudent12Dto>
    {

    }
}