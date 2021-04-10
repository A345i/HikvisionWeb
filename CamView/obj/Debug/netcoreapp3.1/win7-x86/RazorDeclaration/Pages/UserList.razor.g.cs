// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CamView.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\_Imports.razor"
using CamView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\_Imports.razor"
using CamView.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\_Imports.razor"
using CamView.HelpClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\Pages\UserList.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\Pages\UserList.razor"
using CamView.UsersGroups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\Pages\UserList.razor"
using CamView.UsersGroupsComponents;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userlist")]
    public partial class UserList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\Pages\UserList.razor"
       

    protected override async Task OnInitializedAsync()
    {
        User usr = new User();
        usr = await usersetting.GetUserFromId(curentId.IdData);
        if (!usr.IsAdmin)
        { GoHome(); }
    }

    void GoHome()
    {
        NavigationManager.NavigateTo("/", false);
    }

    void GoCameras()
    {
        NavigationManager.NavigateTo("/cameralist", false);
    }

    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserData curentId { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserSettings usersetting { get; set; }
    }
}
#pragma warning restore 1591
