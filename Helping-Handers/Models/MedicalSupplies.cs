using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Helping_Handers.Models
{
    public class MedicalSupplies
    {
        [Key]
        public int med_ID { get; set; }
        public string med_name { get; set; }
        public string med_type { get; set; }
        public int med_quant { get; set; }
        public string med_manufacturer { get; set; }
    }
}