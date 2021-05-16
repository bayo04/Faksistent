using Faksistent.Courses.Dto;
using Faksistent.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faksistent.Courses
{
    public interface ICourseAppService : IBaseAppService<CourseDto, Guid, CourseRequestDto, CreateCourseDto, UpdateCourseDto>
    {
    }
}
