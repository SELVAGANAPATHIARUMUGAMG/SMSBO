using System;
using SMSBO.Students.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Students
{
    public interface IStudent11AppService :
        ICrudAppService< 
            Student11Dto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateStudent11Dto,
            CreateUpdateStudent11Dto>
    {

    }
}