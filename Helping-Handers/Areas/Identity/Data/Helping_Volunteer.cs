using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Helping_Handers.Areas.Identity.Data;

public class Helping_Volunteer : IdentityUser
    {

    [Key]
    public int vol_Id { get; set; }
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

