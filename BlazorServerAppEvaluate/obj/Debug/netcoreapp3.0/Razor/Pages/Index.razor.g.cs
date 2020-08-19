#pragma checksum "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bca1b32a51318c6e4fc48bb1494885d65d7fbb8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerAppEvaluate.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/_Imports.razor"
using BlazorServerAppEvaluate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/_Imports.razor"
using BlazorServerAppEvaluate.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/_Imports.razor"
using BlazorWebEvaluate.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Personal Information.</h3>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-lg-12");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\n            ");
            __builder.AddMarkupContent(10, "<label for=\"fullname\">Name - Surename</label>\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "id", "fullname");
            __builder.AddAttribute(15, "placeholder", "Enter you name and surename");
            __builder.AddAttribute(16, "required", "required");
            __builder.AddAttribute(17, "autofocus", true);
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                          personal.full_name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => personal.full_name = __value, personal.full_name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.AddMarkupContent(24, "\n            ");
            __builder.AddMarkupContent(25, "<label for=\"level\">Level</label>\n            ");
            __builder.OpenElement(26, "select");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "id", "level");
            __builder.AddAttribute(29, "required", true);
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                           personal.level

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => personal.level = __value, personal.level));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(32, "\n                ");
            __builder.OpenElement(33, "option");
            __builder.AddContent(34, " --- Choose --- ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n");
#nullable restore
#line 18 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                 for (int i = 1; i <= 11; i++)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "                    ");
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", 
#nullable restore
#line 20 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                                     "L"+i

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(39, 
#nullable restore
#line 20 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                                               "L"+i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n");
#nullable restore
#line 21 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n        ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                          gotoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-primary");
            __builder.AddContent(48, "  Next  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
       
    public Personal personal { get; set; }

    protected override async Task OnInitializedAsync()
    {
        personal = new Personal();
        if (!PreRenderFlag.IsPreRendering)
        {
            personal.full_name = await sessionStorage.GetItemAsync<string>("full_name");
            personal.level = await sessionStorage.GetItemAsync<string>("level");
        }
        await base.OnParametersSetAsync();
    }

    private async Task gotoNext()
    {
        if (!String.IsNullOrEmpty(personal.full_name) && !String.IsNullOrEmpty(personal.level))
        {
            await sessionStorage.SetItemAsync("full_name", personal.full_name);
            await sessionStorage.SetItemAsync("level", personal.level);
            NavigationManager.NavigateTo("BusinessAcumen");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PreRenderComponent.IPreRenderFlag PreRenderFlag { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
