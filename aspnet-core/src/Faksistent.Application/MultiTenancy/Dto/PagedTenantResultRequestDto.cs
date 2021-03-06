using Abp.Application.Services.Dto;

namespace Faksistent.MultiTenancy.Dto
{
    public class PagedTenantResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }

        public bool? IsActive { get; set; }

        public long? FacultyId { get; set; }

        public int DurationInSemesters { get; set; }
    }
}

