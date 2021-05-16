using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Faksistent.Faculties.Dto
{
    [AutoMapTo(typeof(Faculty))]
    public class UpdateFacultyDto : CreateFacultyDto, IEntityDto<long>
    {
        public long Id { get; set; }
    }
}
