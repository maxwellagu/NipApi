using NIPAPI.Application.Interfaces;
using NIPAPI.Data.Data;
using NIPAPI.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPAPI.Data.Repository
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(NIPAPIDbContext context) : base(context)
        {
        }
    }
}
