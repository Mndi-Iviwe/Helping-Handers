using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Helping_Handers.Models
{
    public class Food
    {
        [Key]
        public int food_ID { get; set; }
        public string food_name { get; set; }
        public string food_type { get; set; }
        public string food_handling { get; set; }
        public DateTime food_expiry { get; set; }
    }
}