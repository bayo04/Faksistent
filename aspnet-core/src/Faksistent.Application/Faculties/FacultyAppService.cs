using Abp.Authorization;
using Abp.Domain.Repositories;
using Faksistent.Faculties.Dto;
using Faksistent.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faksistent.Faculties
{
    [AbpAllowAnonymous]
    public class FacultyAppService : BaseAppService<Faculty, FacultyDto, long, FacultyRequestDto, CreateFacultyDto, UpdateFacultyDto>, IFacultyAppService
    {
        public FacultyAppService(IRepository<Faculty, long> repository) : base(repository)
        {
        }
    }
}
