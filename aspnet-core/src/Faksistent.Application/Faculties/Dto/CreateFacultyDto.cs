using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
