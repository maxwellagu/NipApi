using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIPAPI.Application.DTO.Course
{
    public abstract class BaseCourseDTO
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Teacher { get; set; }
    }
}
