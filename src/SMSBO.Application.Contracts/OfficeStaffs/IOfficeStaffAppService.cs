using System;
using SMSBO.OfficeStaffs.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.OfficeStaffs
{
    public interface IOfficeStaffAppService :
        ICrudAppService< 
            OfficeStaffDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            
            CreateUpdateOfficeStaffDto>
    {

    }
}