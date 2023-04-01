using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace newHealth.Models
{
    public partial class Books
    {   [Key]
        [Required]
        public long HealthId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Website { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string City { get; set; }
    }
}
