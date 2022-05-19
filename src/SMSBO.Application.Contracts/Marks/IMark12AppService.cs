using System;
using SMSBO.Marks.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Marks
{
    public interface IMark12AppService :
        ICrudAppService< 
            Mark12Dto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateMark12Dto,
            CreateUpdateMark12Dto>
    {

    }
}