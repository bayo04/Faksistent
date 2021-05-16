using Abp.AutoMapper;
using System;

namespace Faksistent.Faculties.Dto
{
    [AutoMapTo(typeof(Faculty))]
    public class CreateFacultyDto
    {
        public string Name { get; set; }

        public string ShortName { get; set; }

        public string Location { get; set; }
    }
}
