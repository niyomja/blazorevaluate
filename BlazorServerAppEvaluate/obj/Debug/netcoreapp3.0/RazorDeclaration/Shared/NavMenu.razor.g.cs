#pragma checksum "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2a95f14eae84f010788119ab08149ecca37a029"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerAppEvaluate.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\_Imports.razor"
using BlazorServerAppEvaluate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\_Imports.razor"
using BlazorServerAppEvaluate.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\_Imports.razor"
using BlazorWebEvaluate.Data;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
