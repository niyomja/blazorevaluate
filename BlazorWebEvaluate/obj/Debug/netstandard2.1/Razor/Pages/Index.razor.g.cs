#pragma checksum "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d9d9fcbd343afa02a4de42641e28df288b6ce22"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebEvaluate.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\_Imports.razor"
using BlazorWebEvaluate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\_Imports.razor"
using BlazorWebEvaluate.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\_Imports.razor"
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
            __builder.AddMarkupContent(0, "<h3>Personal Information.</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-lg-12");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<label for=\"fullname\">Name - Surename</label>\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "id", "fullname");
            __builder.AddAttribute(15, "placeholder", "Enter you name and surename");
            __builder.AddAttribute(16, "required", true);
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\Index.razor"
                          personal.full_name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => personal.full_name = __value, personal.full_name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.AddMarkupContent(24, "<label for=\"level\">Level</label>\r\n            ");
            __builder.OpenElement(25, "select");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "id", "level");
            __builder.AddAttribute(28, "required", true);
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\Index.razor"
                           personal.level

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => personal.level = __value, personal.level));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "option");
            __builder.AddContent(33, " --- Choose --- ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 16 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\Index.razor"
                 for (int i = 1; i < 11; i++)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                    ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", 
#nullable restore
#line 18 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\Index.razor"
                                     "L"+i

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(38, 
#nullable restore
#line 18 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\Index.razor"
                                               "L"+i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 19 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\Index.razor"
                          gotoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "class", "btn btn-primary");
            __builder.AddContent(47, "  Next  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\Index.razor"
       
    public Personal personal { get; set; }

    protected override async Task OnInitializedAsync()
    {
        personal = new Personal();
        await base.OnParametersSetAsync();
    }

    void gotoNext()
    {
        StateHasChanged();
        NavigationManager.NavigateTo("BusinessAcumen");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591