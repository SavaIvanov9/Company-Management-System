namespace CompanyManagementSystem.WebServices.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RegisterModel : LogInModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [MaxLength(30)]
        public string Email { get; set; }

        public long? ManagerId { get; set; }

        [Required]
        public long PositionId { get; set; }

        public virtual IEnumerable<long> TeamIds { get; set; }
    }
}
