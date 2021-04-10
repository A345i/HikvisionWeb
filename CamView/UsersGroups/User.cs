using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamView.UsersGroups
{
    public class User
    {
        public string UserId { get; set; } = "";
        public bool IsAdmin { get; set; } = false;
        public string UserName { get; set; } = "";
        public string UserDescription { get; set; } = "";
        public string UserPassword { get; set; } = "";
    }
}
