
using System.Security.Claims;
using WebAppProject.Areas.Identity.Data;

namespace WebAppProject.Model
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public DateTime RegisterDate { get; set; }
        public string InGameTime { get; set; } = string.Empty;
        public DateTime LastLogin { get; set; }
        public int DebugRequest { get; set; }
        public int AccountPermissions { get; set; }
        public string Character_1_Nickname { get; set; } = string.Empty;
        public int Character_1_Lvl { get; set; }
        public string Character_1_Class { get; set; } = string.Empty;
        public string Character_1_Kingdom { get; set; } = string.Empty;
        public string Character_1_InGameTime { get; set; } = string.Empty;
        public string Character_1_Sex { get; set; } = string.Empty;
        public string Character_2_Nickname { get; set; } = string.Empty;
        public int Character_2_Lvl { get; set; }
        public string Character_2_Class { get; set; } = string.Empty;
        public string Character_2_Kingdom { get; set; } = string.Empty;
        public string Character_2_InGameTime { get; set; } = string.Empty;
        public string Character_2_Sex { get; set; } = string.Empty;
        public string Character_3_Nickname { get; set; } = string.Empty;
        public int Character_3_Lvl { get; set; }
        public string Character_3_Class { get; set; } = string.Empty;
        public string Character_3_Kingdom { get; set; } = string.Empty;
        public string Character_3_InGameTime { get; set; } = string.Empty;
        public string Character_3_Sex { get; set; } = string.Empty;
        public string Character_4_Nickname { get; set; } = string.Empty;
        public int Character_4_Lvl { get; set; }
        public string Character_4_Class { get; set; } = string.Empty;
        public string Character_4_Kingdom { get; set; } = string.Empty;
        public string Character_4_InGameTime { get; set; } = string.Empty;
        public string Character_4_Sex { get; set; } = string.Empty;
    }
}
