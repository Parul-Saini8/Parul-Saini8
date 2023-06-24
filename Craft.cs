using System;
using System.ComponentModel.DataAnnotations;

namespace Fitness_Tracker.Models
{
    public class Craft
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        public string Creator { get; set; }

        public int Quantity { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[A-Z][a-zA-Z\s]*$")]
        public string Category { get; set; }

        // Additional properties related to your Fitness Tracker theme
        // ...

    }
}