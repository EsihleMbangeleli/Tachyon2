
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Tachyon.Models
{
    public class ManageFile
    {
        [Key]
        public int ManageFileID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Surname { get; set;}
        public string? Gender { get; set;}
        [Required]
        [DisplayName("Date Of Birth")]
        public DateTime  DateOFBirth { get; set; }
        [Required]
        public string? Race { get; set; }

    }
}
