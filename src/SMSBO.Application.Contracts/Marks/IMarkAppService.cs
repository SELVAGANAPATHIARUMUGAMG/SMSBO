using System;
using System.Threading.Tasks;
using SMSBO.Marks.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Marks
{
    public interface IMarkAppService :
        ICrudAppService< 
            MarkDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateMarkDto,
            CreateUpdateMarkDto>
    {
        Task<ListResultDto<StudentLookupDto>> GetAuthorLookupAsync();
    }
}