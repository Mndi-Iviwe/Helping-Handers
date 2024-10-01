using System;
using System.Linq;

namespace Helping_Handers.Models
{
    public class AidUser
    {
        public int user_Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int age { get; set; } 
    }
}