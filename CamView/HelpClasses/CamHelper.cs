using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Net;

namespace CamView.HelpClasses
{
    public class CamHelper : ICamHelper
    {
        public async Task<string> GetImageStringFromUrl(string _username, string _userpass, string _url)
        {
            try
            {
                byte[] imageBytes;
                string base64String = "";

                using (var handler = new HttpClientHandler { Credentials = new NetworkCredential(_username, _userpass), })
                {
                    using (HttpClient c = new HttpClient(handler))
                    {
                        var _stream = new MemoryStream();
                        using (Stream s = await c.GetStreamAsync(_url))
                        {
                            await s.CopyToAsync(_stream);

                        }

                        imageBytes = _stream.ToArray();

                        await _stream.DisposeAsync();
                    }
                }
                base64String = Convert.ToBase64String(imageBytes);

                GC.Collect();
                return await Task.Run(() => base64String);
            }
            catch
            { return await Task.Run(() => ""); }
        }
    }
}
