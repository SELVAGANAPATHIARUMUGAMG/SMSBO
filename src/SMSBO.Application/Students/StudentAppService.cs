using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SMSBO.Marks;
using SMSBO.Marks.Dtos;
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
        private readonly IMarkRepository _markRepository;

        public StudentAppService(IStudentRepository repository, IMarkRepository markRepository) : base(repository)
        {
            _repository = repository;
            _markRepository = markRepository;
        }
        public async Task<List<MarkDto>> GetMarkOfStudentAsync(Guid id)
        {
            var marklList = await _markRepository.GetListAsync();

            List<MarkDto> deviceDetailsOfCustomer = new List<MarkDto>();

            foreach (Mark mark in marklList)
            {
                if (mark.StudentId == id)
                {
                    /// converts to the DeviceDetailDto using the object to object mapper. 
                    var devicedetailDto = ObjectMapper.Map<Mark, MarkDto>(mark);
                    deviceDetailsOfCustomer.Add(devicedetailDto);
                }
            }

            return deviceDetailsOfCustomer;
        }
    }
}
