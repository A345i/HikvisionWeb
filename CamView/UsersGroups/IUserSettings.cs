using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamView.UsersGroups
{
    public interface IUserSettings
    {

        #region HostSetting

        public Task<string> GetHost();
        public Task<string> GetUserName();
        public Task<string> GetPassword();
        public Task UpdateHostSetting(string _host, string _user, string _pass);

        #endregion

        #region Camera

        public Task<List<Camera>> GetCameraList();
        public Task AddCameraToList(Camera _cam);
        public Task<Camera> UpdateCamera(Camera _cam);
        public Task RemoveCameraFromList(Camera _cam);
        public Task<Camera> GetCameraFromChanel(string _chanel);

        #endregion

        public Task<List<User>> GetUserList();
        public Task AddUserToList(User _user);
        public Task RemoveUserFromList(User _user);
        public Task<User> GetUserFromId(string _userId);
        public Task<User> UpdateUser(User _user);
        public Task Save();
        public Task Load();
        public Task<User> GetUserByPass(string _pass);
        public Task<GlobalUser> GetGlobalUser(User _usr);

      
    }
}
