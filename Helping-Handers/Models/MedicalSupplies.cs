using System;
using System.Linq;

namespace Helping_Handers.Models
{
    public class MedicalSupplies
    {
        public int med_ID { get; set; }
        public string med_name { get; set; }
        public string med_type { get; set; }
        public string med_manufacturer { get; set; }
        public DateTime med_expiry { get; set; }
    }
}