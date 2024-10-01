using System;
using System.Linq;

namespace Helping_Handers.Models
{
    public class Food
    {
        public int food_ID { get; set; }
        public string food_name { get; set; }
        public string food_type { get; set; }
        public DateTime food_expiry { get; set; }
    }
}