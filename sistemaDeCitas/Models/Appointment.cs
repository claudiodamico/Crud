using System;
using System.ComponentModel.DataAnnotations;

namespace sistemaDeCitas.Models
{
    public class Appointment
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }


        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Hour")]
        public DateTime Hour { get; set; }
    }
}
