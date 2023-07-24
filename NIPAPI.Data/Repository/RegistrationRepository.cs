using NIPAPI.Application.Interfaces;
using NIPAPI.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPAPI.Data.Repository
{
    public class RegistrationRepository : GenericRepository<Registration>, IRegistrationRepository
    {
        public RegistrationRepository(NIPAPIDbContext context) : base(context)
        {
        }
    }
}
