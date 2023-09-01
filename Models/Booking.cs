using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tachyon.Models
{
    public class Booking
    {
        
           [Key]
            public int id { get; set; }
            public string? name { get; set; }
            public string? lastname { get; set; }
            public string? email { get; set; }
            public DateTime? datetimevalue { get; set; }
            public string? subsystem { get; set; }

        }
    }
