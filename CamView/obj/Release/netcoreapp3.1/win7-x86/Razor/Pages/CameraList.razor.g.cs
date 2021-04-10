#pragma checksum "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\Pages\CameraList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1348f209eae6e9f88b27a00159866d3a4c2d86f"
// <auto-generated/>
#pragma warning disable 1591
namespace CamView.Pages
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
#line 1 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\Pages\CameraList.razor"
using CamView.UsersGroups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\Pages\CameraList.razor"
using CamView.UsersGroupsComponents;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cameralist")]
    public partial class CameraList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "btn-group");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-sm btn-outline-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\Pages\CameraList.razor"
                                                              GoHome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "<span class=\"oi oi-home\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddMarkupContent(7, "<button class=\"btn btn-sm btn-outline-light\" disabled>\r\n        &nbsp;\r\n    </button>\r\n    ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-sm btn-outline-info");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\Pages\CameraList.razor"
                                                           GoUsers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "<span class=\"oi oi-people\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n\r\n");
            __builder.OpenComponent<CamView.UsersGroupsComponents.AllCamerasComponent>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, " \r\n<br>\r\n<hr>\r\n");
            __builder.OpenComponent<CamView.UsersGroupsComponents.HostSettingComponent>(15);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\Pages\CameraList.razor"
       

        protected override async Task OnInitializedAsync()
        {
            User usr=new User();
            usr=await usersetting.GetUserFromId(curentId.IdData);
            if (!usr.IsAdmin)
            { GoHome(); }
        }
        void GoHome()
        {
            NavigationManager.NavigateTo(" /", false);
        }
        void GoUsers()
        {
            NavigationManager.NavigateTo(" /userlist", false);
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