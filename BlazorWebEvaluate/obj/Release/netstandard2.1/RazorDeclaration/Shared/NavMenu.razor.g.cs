// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWebEvaluate.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/_Imports.razor"
using BlazorWebEvaluate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/_Imports.razor"
using BlazorWebEvaluate.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/_Imports.razor"
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
#line 18 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
