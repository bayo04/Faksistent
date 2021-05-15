using Faksistent.Faculties.Dto;
using Faksistent.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faksistent.Faculties
{
    public interface IFacultyAppService : IBaseAppService<FacultyDto, long, FacultyRequestDto, CreateFacultyDto, UpdateFacultyDto>
    {
    }
}
