using System;
using SMSBO.Permissions;
using SMSBO.Marks.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using SMSBO.Students;
using Volo.Abp.Domain.Repositories;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;

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

        private readonly IStudentRepository _studentRepository;

        public MarkAppService(IRepository<Mark, Guid> repository,
        IStudentRepository revenueRepository) : base(repository)
        {
            _studentRepository = revenueRepository;
        }
        public override async Task<MarkDto> GetAsync(Guid id)
        {
            //Get the IQueryable<Mark> from the repository
            var queryable = await Repository.GetQueryableAsync();

            //Prepare a query to join marks and students
            var query = from mark in queryable
                        join student in await _studentRepository.GetQueryableAsync() on mark.StudentId equals student.Id
                        where mark.Id == id
                        select new { mark, student };

            //Execute the query and get the book with author
            var queryResult = await AsyncExecuter.FirstOrDefaultAsync(query);
            if (queryResult == null)
            {
                throw new EntityNotFoundException(typeof(Mark), id);
            }

            var bookDto = ObjectMapper.Map<Mark, MarkDto>(queryResult.mark);
            bookDto.Name = queryResult.student.Name;
            return bookDto;
        }

        public override async Task<PagedResultDto<MarkDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            //Get the IQueryable<Mark> from the repository
            var queryable = await Repository.GetQueryableAsync();

            //Prepare a query to join mark and authors
            var query = from mark in queryable
                        join student in await _studentRepository.GetQueryableAsync() on mark.StudentId equals student.Id
                        select new { mark, student };

            //Paging
            query = query
                .OrderBy(NormalizeSorting(input.Sorting))
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount);

            //Execute the query and get a list
            var queryResult = await AsyncExecuter.ToListAsync(query);

            //Convert the query result to a list of MarkDto objects
            var markDtos = queryResult.Select(x =>
            {
                var markDto = ObjectMapper.Map<Mark, MarkDto>(x.mark);
                markDto.Name = x.student.Name;
                return markDto;
            }).ToList();

            //Get the total count with another query
            var totalCount = await Repository.GetCountAsync();

            return new PagedResultDto<MarkDto>(
                totalCount,
                markDtos
            );
        }
        public async Task<ListResultDto<StudentLookupDto>> GetAuthorLookupAsync()
        {
            var students = await _studentRepository.GetListAsync();

            return new ListResultDto<StudentLookupDto>(
                ObjectMapper.Map<List<Student>, List<StudentLookupDto>>(students)
            );
        }
        private static string NormalizeSorting(string sorting)
        {
            if (sorting.IsNullOrEmpty())
            {
                return $"mark.{nameof(Mark.StudentId)}";
            }

            if (sorting.Contains("Name", StringComparison.OrdinalIgnoreCase))
            {
                return sorting.Replace(
                    "Name",
                    "student.Name",
                    StringComparison.OrdinalIgnoreCase
                );
            }

            return $"mark.{sorting}";
        }

    }
}
