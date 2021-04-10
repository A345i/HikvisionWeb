// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CamView.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\_Imports.razor"
using CamView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\_Imports.razor"
using CamView.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\Shared\CamShowComponent.razor"
using CamView.HelpClasses;

#line default
#line hidden
#nullable disable
    public partial class CamShowComponent : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\Shared\CamShowComponent.razor"
       
    [Parameter]
    public string HostName { get; set; }
    [Parameter]
    public string UserName { get; set; }
    [Parameter]
    public string Password { get; set; }
    [Parameter]
    public string Chanel { get; set; } = "101";
    [Parameter]
    public bool Capture { get; set; } = false;
    protected override async Task OnInitializedAsync()
    {
        await Timer();
    }
    public void Dispose()
    {
        Capture = false;
        img = "/image/noise.gif";
        GC.Collect();
    }
    string img = "/image/noise.gif";
    string url = "http://192.168.1.250/ISAPI/Streaming/channels/101/picture?snapShotImageType=JPEG";
    async Task ShowCamScreenShot()
    {
        url = "http://" + HostName + "/ISAPI/Streaming/channels/" + Chanel + "/picture?snapShotImageType=JPEG";
        string curentBaseString = await cam.GetImageStringFromUrl(UserName, Password, url);
        if (curentBaseString != "")
        {
            img = "data:image/jpeg;base64, " + curentBaseString;
            StateHasChanged();
        }
        if (Capture)
            await Timer();
    }

    #region Timer

    private int _TimerInterval { get; set; } = 500;
    async Task Timer()
    {
        await Task.Delay(_TimerInterval);
        await AfterTime();
    }
    async Task AfterTime()
    {
        if (Capture)
        {
            await ShowCamScreenShot();
        }
        else
        {
            //await Timer();
            await Task.CompletedTask;
        }

    }
    #endregion

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICamHelper cam { get; set; }
    }
}
#pragma warning restore 1591