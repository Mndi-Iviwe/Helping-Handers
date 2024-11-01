using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using NuGet.Protocol;

namespace Helping_Handers.Areas.Identity.Data;

    public class Helping_Manager : IdentityUser
    {
        [Key]
        public int mgr_Id = 2002;
        public string mgr_Username = "IviweTheManager";
        public string mgr_Email = "HanderManager@hhmail.com";
        public string mgr_Password = "TheStrawHatPirates3000";
        public bool is_Manager = true;
    }

