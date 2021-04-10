using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace CamView.HelpClasses
{
    

    public class BrowserService : IBrowserService
    {
        private readonly IJSRuntime _js;

        public BrowserService(IJSRuntime js)
        {
            _js = js;
        }

      

        public async Task ScrollTop()
        {
            await _js.InvokeVoidAsync("scrollTop");
        }

       

       

    }

   
}
