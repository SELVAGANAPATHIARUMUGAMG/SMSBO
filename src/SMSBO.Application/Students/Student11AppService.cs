using System;
using SMSBO.Permissions;
using SMSBO.Students.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Students
{
    public class Student11AppService : CrudAppService<Student11, Student11Dto, Guid, PagedAndSortedResultRequestDto, CreateUpdateStudent11Dto, CreateUpdateStudent11Dto>,
        IStudent11AppService
    {
        protected override string GetPolicyName { get; set; } = SMSBOPermissions.Student11.Default;
        protected override string GetListPolicyName { get; set; } = SMSBOPermissions.Student11.Default;
        protected override string CreatePolicyName { get; set; } = SMSBOPermissions.Student11.Create;
        protected override string UpdatePolicyName { get; set; } = SMSBOPermissions.Student11.Update;
        protected override string DeletePolicyName { get; set; } = SMSBOPermissions.Student11.Delete;

        private readonly IStudent11Repository _repository;
        
        public Student11AppService(IStudent11Repository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
