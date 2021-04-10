using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamView.HelpClasses
{
    interface ICamHelper
    {
        public Task<string> GetImageStringFromUrl(string _username, string _userpass, string _url);
    }
}
