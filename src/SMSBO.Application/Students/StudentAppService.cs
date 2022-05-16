using System;
using SMSBO.Permissions;
using SMSBO.Students.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Students
{
    public class StudentAppService : CrudAppService<Student, StudentDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateStudentDto, CreateUpdateStudentDto>,
        IStudentAppService
    {
        protected override string GetPolicyName { get; set; } = SMSBOPermissions.Student.Default;
        protected override string GetListPolicyName { get; set; } = SMSBOPermissions.Student.Default;
        protected override string CreatePolicyName { get; set; } = SMSBOPermissions.Student.Create;
        protected override string UpdatePolicyName { get; set; } = SMSBOPermissions.Student.Update;
        protected override string DeletePolicyName { get; set; } = SMSBOPermissions.Student.Delete;

        private readonly IStudentRepository _repository;
        
        public StudentAppService(IStudentRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
