using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Helping_Handers.Models
{
    public class IncidentAssignment
    {
        [Key]
        public int assign_ID { get; set; }
        public string? assign_role { get; set; }
        public DateTime assign_date { get; set; }
    }
}