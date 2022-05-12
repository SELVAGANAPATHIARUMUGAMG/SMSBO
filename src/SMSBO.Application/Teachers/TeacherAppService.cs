using System;
using SMSBO.Permissions;
using SMSBO.Teachers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SMSBO.Teachers
{
    public class TeacherAppService : CrudAppService<Teacher, TeacherDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateTeacherDto, CreateUpdateTeacherDto>,
        ITeacherAppService
    {
        protected override string GetPolicyName { get; set; } = SMSBOPermissions.Teacher.Default;
        protected override string GetListPolicyName { get; set; } = SMSBOPermissions.Teacher.Default;
        protected override string CreatePolicyName { get; set; } = SMSBOPermissions.Teacher.Create;
        protected override string UpdatePolicyName { get; set; } = SMSBOPermissions.Teacher.Update;
        protected override string DeletePolicyName { get; set; } = SMSBOPermissions.Teacher.Delete;

        private readonly ITeacherRepository _repository;
        
        public TeacherAppService(ITeacherRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
