using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;

namespace Faksistent.Courses.Dto
{
    [AutoMapFrom(typeof(Course))]
    public class CourseDto : IEntityDto<Guid>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public int Semester { get; set; }
    }
}
