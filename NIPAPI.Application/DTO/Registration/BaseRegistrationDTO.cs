using System.ComponentModel.DataAnnotations;

namespace NIPAPI.Application.DTO.Registration
{
    public abstract class BaseRegistrationDTO
    {
        [Required] 
        public int CourseId { get; set; }
        [Required]
        public int UserId { get; set; }
        public DateTime Date { get; set; }
    }
}
