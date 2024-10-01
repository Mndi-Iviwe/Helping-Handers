using System;
using System.Linq;

namespace Helping_Handers.Models
{
    public class IncidentReport
    {
        public int incident_ID { get; set; }
        public string incident_description { get; set; }
        public string incident_country { get; set; }
        public string incident_magnitude { get; set; }
        public string incident_risk { get; set; }
        public int Num_volunteers { get; set; }
    }
}