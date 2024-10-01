using System;
using System.Linq;

namespace Helping_Handers.Models
{
    public class AidVolunteer
    {
        public int vol_ID { get; set; }
        public string vol_firstName { get; set; }
        public string vol_lastName { get; set; }
        public string vol_email { get; set; }
        public string vol_password { get; set; }
        public int vol_age { get; set; }
        public string vol_type { get; set; }
        public string vol_contact { get; set; }
        public string vol_reason { get; set; }
        public string vol_country { get; set; }
    }
}