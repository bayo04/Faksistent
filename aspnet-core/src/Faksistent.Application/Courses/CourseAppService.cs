using Abp.Authorization;
using Abp.Domain.Repositories;
using Faksistent.Authorization;
using Faksistent.Courses.Dto;
using Faksistent.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faksistent.Courses
{
    [AbpAuthorize(PermissionNames.Courses)]
    public class CourseAppService : BaseAppService<Course, CourseDto, Guid, CourseRequestDto, CreateCourseDto, UpdateCourseDto>, ICourseAppService
    {
        public CourseAppService(IRepository<Course, Guid> repository) : base(repository)
        {
        }

        [AbpAuthorize(PermissionNames.Courses_Create)]
        public override Task<CourseDto> CreateAsync(CreateCourseDto input)
        {
            return base.CreateAsync(input);
        }

        [AbpAuthorize(PermissionNames.Courses_Update)]
        public override Task<CourseDto> UpdateAsync(UpdateCourseDto input)
        {
            return base.UpdateAsync(input);
        }
    }
}
