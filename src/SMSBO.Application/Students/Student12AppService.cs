using System;
using SMSBO.Permissions;
using SMSBO.Students.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Students
{
    public class Student12AppService : CrudAppService<Student12, Student12Dto, Guid, PagedAndSortedResultRequestDto, CreateUpdateStudent12Dto, CreateUpdateStudent12Dto>,
        IStudent12AppService
    {
        protected override string GetPolicyName { get; set; } = SMSBOPermissions.Student12.Default;
        protected override string GetListPolicyName { get; set; } = SMSBOPermissions.Student12.Default;
        protected override string CreatePolicyName { get; set; } = SMSBOPermissions.Student12.Create;
        protected override string UpdatePolicyName { get; set; } = SMSBOPermissions.Student12.Update;
        protected override string DeletePolicyName { get; set; } = SMSBOPermissions.Student12.Delete;

        private readonly IStudent12Repository _repository;
        
        public Student12AppService(IStudent12Repository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
