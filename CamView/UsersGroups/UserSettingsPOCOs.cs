using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamView.UsersGroups
{
    public class UserSettingsPOCOs
    {
        public string Host { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Camera> CameraList { get; set; }
        public List<User> UsersList { get; set; }
    }
}
