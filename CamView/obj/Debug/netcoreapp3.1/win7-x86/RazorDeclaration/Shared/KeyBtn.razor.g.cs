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
    public partial class KeyBtn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "G:\NewFolder\Core_NET\GitProjects\testProject\CamView\Shared\KeyBtn.razor"
       

    [Parameter]
    public string KeyVal { get; set; }

    [Parameter]
    public string Numb { get; set; }

    [Parameter]
    public string KeyClass { get; set; } = "btn btn-outline-primary btn-lg";

    [Parameter]
    public EventCallback<string> OnClickCallback { get; set; }

    void OnClick()
    {
        OnClickCallback.InvokeAsync(Numb);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
