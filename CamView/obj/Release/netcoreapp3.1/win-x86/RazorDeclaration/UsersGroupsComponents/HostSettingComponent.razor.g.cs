// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CamView.UsersGroupsComponents
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
#line 10 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\_Imports.razor"
using CamView.HelpClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\HostSettingComponent.razor"
using CamView.UsersGroups;

#line default
#line hidden
#nullable disable
    public partial class HostSettingComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\HostSettingComponent.razor"
       

    public string _Host { get; set; }
    public string _UserName { get; set; }
    public string _Password { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await usersetting.Load();

        _Host = await usersetting.GetHost();
        _UserName = await usersetting.GetUserName();
        _Password = await usersetting.GetPassword();
    }

    async Task SaveSetting()
    {
        await usersetting.Load();

        await usersetting.UpdateHostSetting(_Host, _UserName, _Password);

        await usersetting.Save();

        await Task.CompletedTask;
    }

    void OnHost(ChangeEventArgs args)
    {
        _Host = args.Value.ToString();
    }

    void OnUserName(ChangeEventArgs args)
    {
        _UserName = args.Value.ToString();
    }

    void OnPassword(ChangeEventArgs args)
    {
        _Password = args.Value.ToString();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserSettings usersetting { get; set; }
    }
}
#pragma warning restore 1591