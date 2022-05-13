using System;
using SMSBO.Permissions;
using SMSBO.OfficeStaffs.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.OfficeStaffs
{
    public class OfficeStaffAppService : CrudAppService<OfficeStaff, OfficeStaffDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOfficeStaffDto, CreateUpdateOfficeStaffDto>,
        IOfficeStaffAppService
    {
        protected override string GetPolicyName { get; set; } = SMSBOPermissions.OfficeStaff.Default;
        protected override string GetListPolicyName { get; set; } = SMSBOPermissions.OfficeStaff.Default;
        protected override string CreatePolicyName { get; set; } = SMSBOPermissions.OfficeStaff.Create;
        protected override string UpdatePolicyName { get; set; } = SMSBOPermissions.OfficeStaff.Update;
        protected override string DeletePolicyName { get; set; } = SMSBOPermissions.OfficeStaff.Delete;

        private readonly IOfficeStaffRepository _repository;
        
        public OfficeStaffAppService(IOfficeStaffRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
