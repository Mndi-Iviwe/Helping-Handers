using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Helping_Handers.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Helping_User class
public class Helping_User : IdentityUser
{
    [Key]
    public int user_Id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public int age { get; set; }
}

