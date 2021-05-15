using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Faksistent.Faculties.Dto
{
    [AutoMapFrom(typeof(Faculty))]
    public class FacultyDto : IEntityDto<long>
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public string Location { get; set; }
    }
}
