#pragma checksum "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\HostSettingComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e3ecfb32ca8c948929c0096fdfdcdb71aefd9ef"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "<label class=\"text-dark\" for=\"HostField\">Адрес хоста</label>\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "id", "HostField");
            __builder.AddAttribute(7, "placeholder", "Добавьте адрес хоста");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 6 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\HostSettingComponent.razor"
                                                                                                      _Host

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 6 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\HostSettingComponent.razor"
                                                                                                                        OnHost

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-group");
            __builder.AddMarkupContent(13, "<label class=\"text-dark\" for=\"UNamField\">Имя пользователя</label>\r\n    ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "class", "form-control");
            __builder.AddAttribute(17, "id", "UNamField");
            __builder.AddAttribute(18, "placeholder", "Добавьте имя пользователя");
            __builder.AddAttribute(19, "value", 
#nullable restore
#line 11 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\HostSettingComponent.razor"
                                                                                                           _UserName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\HostSettingComponent.razor"
                                                                                                                                 OnUserName

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.AddMarkupContent(24, "<label class=\"text-dark\" for=\"PassField\">Пароль</label>\r\n    ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "id", "PassField");
            __builder.AddAttribute(29, "placeholder", "укажите пароль");
            __builder.AddAttribute(30, "value", 
#nullable restore
#line 16 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\HostSettingComponent.razor"
                                                                                                _Password

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\HostSettingComponent.razor"
                                                                                                                      OnPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-outline-dark");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\HostSettingComponent.razor"
                                                       SaveSetting

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "Сохранить");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
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
