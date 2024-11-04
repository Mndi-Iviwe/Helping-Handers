using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Helping_Handers.Models
{
    public class Clothing
    {
        [Key]
        public int clothe_ID { get; set; }
        public string clothe_type { get; set; }
        public string clothe_gender { get; set; }
        public string clothe_size { get; set; }
    }
}