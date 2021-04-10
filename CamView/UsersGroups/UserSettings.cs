using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Reflection;

namespace CamView.UsersGroups
{
    public class UserSettings : IUserSettings
    {
        public string Host = "";
        public string UserName = "";
        public string Password = "";
        public List<Camera> CameraList = new List<Camera>();
        public List<User> UsersList = new List<User>();

        #region HostSetting

        public async Task<string> GetHost()
        {
            return await Task.Run(() => this.Host);
        }

        public async Task<string> GetUserName()
        {
            return await Task.Run(() => this.UserName);
        }

        public async Task<string> GetPassword()
        {
            return await Task.Run(() => this.Password);
        }

        public async Task UpdateHostSetting(string _host, string _user, string _pass)
        {
            this.Host = _host;
            this.UserName = _user;
            this.Password = _pass;

            await Task.CompletedTask;
        }

        #endregion

        #region Camera

        public async Task<List<Camera>> GetCameraList()
        {
            return await Task.Run(() => this.CameraList);
        }

        public async Task AddCameraToList(Camera _cam)
        {
            if (_cam.CameraChanel != "")
            {
                if (await CheckCameraChanel(_cam.CameraChanel))
                {
                    await UpdateCamera(_cam);
                }
                else
                {
                    CameraList.Add(_cam);
                }
            }
            await Task.CompletedTask;
        }

        public async Task<Camera> UpdateCamera(Camera _cam)
        {
            Camera retcam;
            retcam = CameraList.FirstOrDefault(_c => _c.CameraChanel == _cam.CameraChanel);
            if (retcam != null)
            {
                CameraList.RemoveAll(_c => _c.CameraChanel == _cam.CameraChanel);
                CameraList.Add(retcam);
                retcam = _cam;

            }

            return await Task.Run(() => retcam);
        }

        public async Task RemoveCameraFromList(Camera _cam)
        {
            CameraList.RemoveAll(_c => _c.CameraChanel == _cam.CameraChanel);
            await Task.CompletedTask;
        }

        //Проверяем есть ли такой канал камеры в списке
        private async Task<bool> CheckCameraChanel(string _chanel)
        {
            Camera retcam;
            retcam = CameraList.FirstOrDefault(_c => _c.CameraChanel == _chanel);
            if (retcam != null)
            {
                return await Task.Run(() => true);
            }
            else
            { return await Task.Run(() => false); }
        }

        public async Task<Camera> GetCameraFromChanel(string _chanel)
        {
            Camera retcam;
            retcam = CameraList.FirstOrDefault(_c => _c.CameraChanel == _chanel);

            if (retcam != null)
            { return await Task.Run(() => retcam); }

            retcam = new Camera();
            return await Task.Run(() => retcam);
        }

        #endregion

        #region User
        public async Task<List<User>> GetUserList()
        {
            return await Task.Run(() => this.UsersList);
        }

        public async Task AddUserToList(User _user)
        {
            if (await CheckUserId(_user.UserId))
            {
                await UpdateUser(_user);
            }
            else
            { 
                _user.UserId = await GenerateId();
                UsersList.Add(_user);
            }
            await Task.CompletedTask;
        }

        public async Task RemoveUserFromList(User _user)
        {
            
            UsersList.RemoveAll(u => u.UserId == _user.UserId);
            await Task.CompletedTask;
        }

        //Проверяем по ID есть ли такой пользователь в списке
        private async Task<bool> CheckUserId(string _userId)
        {
            User retuser;
            retuser = UsersList.FirstOrDefault(_u => _u.UserId == _userId);
            if (retuser != null)
            {
                return await Task.Run(() => true);
            }
            else
            { return await Task.Run(() => false); }
        }

        public async Task<User> GetUserFromId(string _userId)
        {
            User retuser;
            retuser = UsersList.FirstOrDefault(_u => _u.UserId == _userId);

            if (retuser != null)
            { return await Task.Run(() => retuser); }

            retuser = new User();
            return await Task.Run(() => retuser);
        }

        public async Task<User> UpdateUser(User _user)
        {
            User retuser;
            retuser = UsersList.FirstOrDefault(_u => _u.UserId == _user.UserId);
            if (retuser != null)
            {
                UsersList.RemoveAll(_u => _u.UserId == _user.UserId);
                UsersList.Add(_user);
                retuser = _user;

               
            }

            

            return await Task.Run(() => retuser);
        }

        public async Task<User> GetUserByPass(string _pass)
        {
            User retuser; // = new User();
            retuser = UsersList.FirstOrDefault(_u => _u.UserPassword.ToLower() == _pass.ToLower()); //.ToLower() - add

            if (retuser != null)
            { return await Task.Run(() => retuser); }

            retuser = new User();
            return await Task.Run(() => retuser);
        }

        #endregion

        public async Task Save()
        {
            UserSettingsPOCOs up = new UserSettingsPOCOs();

            up.Host = this.Host;
            up.UserName = this.UserName;
            up.Password = this.Password;

            up.CameraList = this.CameraList;
            up.UsersList = this.UsersList;

            string _ptch = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            Cript cr = new Cript();

            string jstr = cr.CriptMe(JsonSerializer.Serialize<UserSettingsPOCOs>(up));

            File.WriteAllText(_ptch + "\\ust.dat", jstr);

            await Task.CompletedTask;
        }

        public async Task Load()
        {
            string _ptch = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            if (File.Exists(_ptch + "\\ust.dat"))
            {
                UserSettingsPOCOs up = new UserSettingsPOCOs();
                Cript cr = new Cript();
                string datStr = File.ReadAllText(_ptch + "\\ust.dat");
                string decriptedStr = cr.DeCriptMe(datStr);

                up = JsonSerializer.Deserialize<UserSettingsPOCOs>(decriptedStr);

                this.Host = up.Host;
                this.UserName = up.UserName;
                this.Password = up.Password;

                this.UsersList = up.UsersList;
                this.CameraList = up.CameraList;
            }

            await Task.CompletedTask;
        }


        public async Task Save_old()
        {
            UserSettingsPOCOs up = new UserSettingsPOCOs();

            up.CameraList = this.CameraList;
            up.UsersList = this.UsersList;

            string _ptch = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            using (FileStream fs = File.Create(_ptch + "\\Setting.json"))
            {
                await JsonSerializer.SerializeAsync<UserSettingsPOCOs>(fs, up);
            }

            await Task.CompletedTask;
        }

        public async Task Load_old()
        {
            string _ptch = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            if (File.Exists(_ptch + "\\Setting.json"))
            {
                UserSettingsPOCOs up = new UserSettingsPOCOs();
                using (FileStream fs = File.OpenRead(_ptch + "\\Setting.json"))
                {
                    up = await JsonSerializer.DeserializeAsync<UserSettingsPOCOs>(fs);
                }

               
                this.UsersList = up.UsersList;
                this.CameraList = up.CameraList;
            }

            await Task.CompletedTask;
        }

        public async Task<string> GenerateId()
        {
            Guid g = Guid.NewGuid();
            return await Task.Run(() => g.ToString("N"));
        }

        public async Task<GlobalUser> GetGlobalUser(User _usr)
        {
            GlobalUser glu = new GlobalUser();
            glu.GUser = _usr;


            return await Task.Run(() => glu);
        }

        //end class
    }
}
