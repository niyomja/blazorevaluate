#pragma checksum "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\CollaborationPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ff1dac85d66a52bab26954eb99111d81f903588"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Collaboration")]
    public partial class CollaborationPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 143 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\CollaborationPage.razor"
       

    public Collaboration collaboration;
    private int step = 1;

    protected override async Task OnInitializedAsync()
    {
        collaboration = new Collaboration();
        collaboration.level1 = new Level();
        await base.OnParametersSetAsync();
    }

    void gotoBack()
    {
        if (step == 1)
        {
            NavigationManager.NavigateTo("Initiative");
        }
        else
        {
            step--;
        }
    }
    void gotoNext()
    {
        switch (step)
        {
            case 1:
                {
                    if (collaboration.level1.c1 == true && collaboration.level1.c2 == true && collaboration.level1.c3 == true)
                    {
                        if (collaboration.level3 == null)
                        {
                            collaboration.level3 = new Level();
                        }
                        step++;
                    }
                    else
                    {
                        NavigationManager.NavigateTo("ServiceExcellence");
                    }
                }; break;
            case 2:
                {
                    if (collaboration.level3.c1 == true && collaboration.level3.c2 == true && collaboration.level3.c3 == true && collaboration.level3.c4 == true)
                    {
                        if (collaboration.level5 == null)
                        {
                            collaboration.level5 = new Level();
                        }
                        step++;
                    }
                    else
                    {
                        NavigationManager.NavigateTo("ServiceExcellence");
                    }
                }; break;
            case 3:
                {
                    NavigationManager.NavigateTo("ServiceExcellence");
                }; break;
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591