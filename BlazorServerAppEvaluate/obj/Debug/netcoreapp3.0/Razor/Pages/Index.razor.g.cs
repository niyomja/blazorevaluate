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
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-lg-12");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.AddMarkupContent(7, "<label for=\"fullname\">Name - Surename</label>\n            ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "id", "fullname");
            __builder.AddAttribute(12, "placeholder", "Enter you name and surename");
            __builder.AddAttribute(13, "required", "required");
            __builder.AddAttribute(14, "autofocus", true);
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                          personal.full_name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => personal.full_name = __value, personal.full_name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group");
            __builder.AddMarkupContent(20, "<label for=\"level\">Level</label>\n            ");
            __builder.OpenElement(21, "select");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "id", "level");
            __builder.AddAttribute(24, "required", true);
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                           personal.level

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => personal.level = __value, personal.level));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(27, "option");
            __builder.AddContent(28, " --- Choose --- ");
            __builder.CloseElement();
#nullable restore
#line 18 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                 for (int i = 1; i <= 11; i++)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", 
#nullable restore
#line 20 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                                     "L"+i

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, 
#nullable restore
#line 20 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                                               "L"+i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 21 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n        ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/Index.razor"
                          gotoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "btn btn-primary");
            __builder.AddContent(37, "  Next  ");
            __builder.CloseElement();
            __builder.CloseElement();
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
