using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faksistent.Courses.Dto
{
    [AutoMapTo(typeof(Course))]
    public class CreateCourseDto
    {
        public string Name { get; set; }

        public string ShortName { get; set; }

        public int Semester { get; set; }
    }
}
