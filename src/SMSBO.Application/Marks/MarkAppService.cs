using System;
using SMSBO.Permissions;
using SMSBO.Marks.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Marks
{
    public class MarkAppService : CrudAppService<Mark, MarkDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMarkDto, CreateUpdateMarkDto>,
        IMarkAppService
    {
        protected override string GetPolicyName { get; set; } = SMSBOPermissions.Mark.Default;
        protected override string GetListPolicyName { get; set; } = SMSBOPermissions.Mark.Default;
        protected override string CreatePolicyName { get; set; } = SMSBOPermissions.Mark.Create;
        protected override string UpdatePolicyName { get; set; } = SMSBOPermissions.Mark.Update;
        protected override string DeletePolicyName { get; set; } = SMSBOPermissions.Mark.Delete;

        private readonly IMarkRepository _repository;
        
        public MarkAppService(IMarkRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
