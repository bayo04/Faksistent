using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faksistent.Faculties.Dto
{
    [AutoMapTo(typeof(Faculty))]
    public class UpdateFacultyDto : CreateFacultyDto, IEntityDto<long>
    {
        public long Id { get; set; }
    }
}
