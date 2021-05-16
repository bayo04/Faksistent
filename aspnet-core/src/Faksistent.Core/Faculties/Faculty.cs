using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faksistent.Faculties
{
    public class Faculty : FullAuditedEntity<long>
    {
        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [Required]
        [MaxLength(16)]
        public string ShortName { get; set; }

        [MaxLength(64)]
        public string Location { get; set; }

        [MaxLength(64)]
        public string University { get; set; }
    }
}
