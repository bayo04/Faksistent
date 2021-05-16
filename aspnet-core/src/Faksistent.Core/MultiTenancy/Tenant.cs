using Abp.MultiTenancy;
using Faksistent.Authorization.Users;
using Faksistent.Faculties;
using System.ComponentModel.DataAnnotations.Schema;

namespace Faksistent.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public int DurationInSemesters { get; set; }

        #region ForeignKeys

        public long? FacultyId { get; set; }

        [ForeignKey(nameof(FacultyId))]
        public Faculty Faculty { get; set; }

        #endregion

        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
