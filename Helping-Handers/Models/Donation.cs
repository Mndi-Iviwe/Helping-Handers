using System;
using System.Linq;

namespace Helping_Handers.Models
{
    public class Donation
    {
        public int donate_ID { get; set; }
        public string donar_name { get; set; }
        public DateTime donate_date { get; set; }
        public string donate_category { get; set; }
        public string donate_quant { get; set; }
        public string donate_note { get; set; }
    }
}