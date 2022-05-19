using System;
using SMSBO.Permissions;
using SMSBO.Marks.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Marks
{
    public class Mark12AppService : CrudAppService<Mark12, Mark12Dto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMark12Dto, CreateUpdateMark12Dto>,
        IMark12AppService
    {
        protected override string GetPolicyName { get; set; } = SMSBOPermissions.Mark12.Default;
        protected override string GetListPolicyName { get; set; } = SMSBOPermissions.Mark12.Default;
        protected override string CreatePolicyName { get; set; } = SMSBOPermissions.Mark12.Create;
        protected override string UpdatePolicyName { get; set; } = SMSBOPermissions.Mark12.Update;
        protected override string DeletePolicyName { get; set; } = SMSBOPermissions.Mark12.Delete;

        private readonly IMark12Repository _repository;
        
        public Mark12AppService(IMark12Repository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
