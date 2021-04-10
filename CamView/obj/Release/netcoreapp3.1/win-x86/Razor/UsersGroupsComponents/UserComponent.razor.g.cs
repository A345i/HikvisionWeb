#pragma checksum "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e50e9ec5dfd87baec8703305b024fc3671f01ba"
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
#line 1 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
using CamView.UsersGroups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class UserComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<label class=\"text-dark\" for=\"userNameField\">Имя пользователя</label>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "input-group");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "id", "userNameField");
            __builder.AddAttribute(7, "placeholder", "введите имя пользователя");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 9 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                                                                                                              CurentUser.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                                                                                                                                              OnUserName

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "input-group-append");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-outline-danger float-right");
            __builder.AddAttribute(15, "type", "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                          DeleteUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "<span class=\"oi oi-trash\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "<label class=\"text-dark\" for=\"userDescriptionField\">Краткое описание пользователя</label>\r\n    ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "id", "userDescriptionField");
            __builder.AddAttribute(26, "placeholder", "Добавьте краткое описание пользователя");
            __builder.AddAttribute(27, "value", 
#nullable restore
#line 21 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                                                                                                                                   CurentUser.UserDescription

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 21 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                                                                                                                                                                          OnUserDescription

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n");
            __builder.AddMarkupContent(30, "<label class=\"text-dark\" for=\"userPasswordField\">Код</label>\r\n");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "input-group");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "disabled", true);
            __builder.AddAttribute(35, "type", "text");
            __builder.AddAttribute(36, "class", "form-control");
            __builder.AddAttribute(37, "id", "userPasswordField");
            __builder.AddAttribute(38, "placeholder", "Укажите код для доступа");
            __builder.AddAttribute(39, "value", 
#nullable restore
#line 27 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                                                                                                                          CurentUser.UserPassword

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 27 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                                                                                                                                                              OnUserPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "input-group-append");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "btn btn-outline-dark");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                          ShowKbtn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, "<span class=\"oi oi-key\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
 if (_showKbtn)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "modal fade show d-block");
            __builder.AddAttribute(51, "tabindex", "-1");
            __builder.AddAttribute(52, "role", "dialog");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "modal-dialog");
            __builder.AddAttribute(55, "role", "document");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "modal-content");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "modal-header");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "type", "button");
            __builder.AddAttribute(62, "class", "close");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                                                                   ShowKbtn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "aria-label", "Close");
            __builder.AddMarkupContent(65, "<span aria-hidden=\"true\" class=\"text-dark\">×</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "modal-body");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "row");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "col");
            __builder.OpenComponent<CamView.Shared.EnterViewL>(73);
            __builder.AddAttribute(74, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 51 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                                                         (string s) => GetPass(s)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"

    
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "row");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "col");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "form-check");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "class", "form-check-input");
            __builder.AddAttribute(83, "type", "checkbox");
            __builder.AddAttribute(84, "checked", 
#nullable restore
#line 68 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                                                                      CurentUser.IsAdmin

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 68 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                                                                                                     CheckAdmin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "id", "stoptorCheckf");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.AddMarkupContent(88, "<label class=\"form-check-label text-danger\" for=\"stoptorCheckf\">\r\n                Администратор\r\n            </label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "row");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "col");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "class", "btn btn-outline-dark");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                                                       AddUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(97, 
#nullable restore
#line 78 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                                                                 uTmp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "col");
            __builder.OpenElement(101, "button");
            __builder.AddAttribute(102, "class", "btn btn-outline-info float-right");
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
                                                                   GoHome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(104, "<span class=\"oi oi-home\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "G:\NewFolder\Core_NET\Blazor\CamViewer\CamView\UsersGroupsComponents\UserComponent.razor"
       
    [Parameter]
    public User CurentUser { get; set; }

    bool _showKbtn = false;
    void ShowKbtn()
    { _showKbtn = !_showKbtn; }

    protected override void OnInitialized()
    {
        CheckCurentUser();
    }

    void CheckCurentUser()
    {
        if (CurentUser.UserId != "")
        {
            uTmp = "Обновить";
        }
    }
    string uTmp { get; set; } = "Создать";
    //string TmpName { get; set; }="" ;
    async Task AddUser()
    {
        await usersetting.AddUserToList(CurentUser);
        await usersetting.Save();
        CurentUser = await usersetting.GetUserFromId(CurentUser.UserId);
        //TmpName =((User)await usersetting.GetUserFromId(CurentUser.UserId)).UserName;
        CheckCurentUser();
        await Task.CompletedTask;
    }

    async Task DeleteUser()
    {
        if (CurentUser.UserId != "")
        {
            await usersetting.RemoveUserFromList(CurentUser);
            await usersetting.Save();
            CurentUser = new User();
        }

        await Task.CompletedTask;
    }

    void GoHome()
    {
        NavigationManager.NavigateTo("/", true);
    }


    void OnUserName(ChangeEventArgs args)
    {
        CurentUser.UserName = args.Value.ToString();
    }
    void OnUserDescription(ChangeEventArgs args)
    {
        CurentUser.UserDescription = args.Value.ToString();
    }
    void OnUserPassword(ChangeEventArgs args)
    {
        CurentUser.UserPassword = args.Value.ToString();
    }

    async Task GetPass(string _code)
    {
        CurentUser.UserPassword = _code;
        await Task.CompletedTask;

    }

    Task CheckAdmin()
    {
        CurentUser.IsAdmin = !CurentUser.IsAdmin;
        return Task.CompletedTask;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserSettings usersetting { get; set; }
    }
}
#pragma warning restore 1591
