using System;
using SMSBO.Permissions;
using SMSBO.Marks.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Marks
{
    public class Mark11AppService : CrudAppService<Mark11, Mark11Dto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMark11Dto, CreateUpdateMark11Dto>,
        IMark11AppService
    {
        protected override string GetPolicyName { get; set; } = SMSBOPermissions.Mark11.Default;
        protected override string GetListPolicyName { get; set; } = SMSBOPermissions.Mark11.Default;
        protected override string CreatePolicyName { get; set; } = SMSBOPermissions.Mark11.Create;
        protected override string UpdatePolicyName { get; set; } = SMSBOPermissions.Mark11.Update;
        protected override string DeletePolicyName { get; set; } = SMSBOPermissions.Mark11.Delete;

        private readonly IMark11Repository _repository;
        
        public Mark11AppService(IMark11Repository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
