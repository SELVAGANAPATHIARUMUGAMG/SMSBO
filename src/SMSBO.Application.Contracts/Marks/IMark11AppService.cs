using System;
using SMSBO.Marks.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Marks
{
    public interface IMark11AppService :
        ICrudAppService< 
            Mark11Dto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateMark11Dto,
            CreateUpdateMark11Dto>
    {

    }
}