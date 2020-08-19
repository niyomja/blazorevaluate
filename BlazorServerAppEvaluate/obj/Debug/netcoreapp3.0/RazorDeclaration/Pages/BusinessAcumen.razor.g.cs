#pragma checksum "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "100d9463adcc7c32b29da4fa549889592fe944d5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/BusinessAcumen")]
    public partial class BusinessAcumen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
       
    public BusinessAcu businessAcumen;
    private int step = 1;

    protected override async Task OnInitializedAsync()
    {
        businessAcumen = new BusinessAcu();
        businessAcumen.level1 = new Level();
        businessAcumen.level3 = new Level();
        businessAcumen.level5 = new Level();

        businessAcumen.level1.c1 = await sessionStorage.GetItemAsync<bool>("level1.c1");
        businessAcumen.level1.c2 = await sessionStorage.GetItemAsync<bool>("level1.c2");
        businessAcumen.level1.c3 = await sessionStorage.GetItemAsync<bool>("level1.c3");
        businessAcumen.level1.c4 = await sessionStorage.GetItemAsync<bool>("level1.c4");

        businessAcumen.level3.c1 = await sessionStorage.GetItemAsync<bool>("level3.c1");
        businessAcumen.level3.c2 = await sessionStorage.GetItemAsync<bool>("level3.c2");
        businessAcumen.level3.c3 = await sessionStorage.GetItemAsync<bool>("level3.c3");
        businessAcumen.level3.c4 = await sessionStorage.GetItemAsync<bool>("level3.c4");

        businessAcumen.level5.c1 = await sessionStorage.GetItemAsync<bool>("level5.c1");
        businessAcumen.level5.c2 = await sessionStorage.GetItemAsync<bool>("level5.c2");
        businessAcumen.level5.c3 = await sessionStorage.GetItemAsync<bool>("level5.c3");
        businessAcumen.level5.c4 = await sessionStorage.GetItemAsync<bool>("level5.c4");
        
        await base.OnParametersSetAsync();
    }

    void gotoBack()
    {
        if (step == 1)
        {
            NavigationManager.NavigateTo("/");
        }
        else {
            step--;
        }
    }
    void gotoNext()
    {
        switch (step) {
            case 1: {
                    if (businessAcumen.level1.c1 == true && businessAcumen.level1.c2 == true && businessAcumen.level1.c3 == true && businessAcumen.level1.c4 == true)
                    {
                        if (businessAcumen.level3 == null)
                        {
                            businessAcumen.level3 = new Level();
                        }
                        sessionStorage.SetItemAsync("level1.c1", businessAcumen.level1.c1);
                        sessionStorage.SetItemAsync("level1.c2", businessAcumen.level1.c2);
                        sessionStorage.SetItemAsync("level1.c3", businessAcumen.level1.c3);
                        sessionStorage.SetItemAsync("level1.c4", businessAcumen.level1.c4);
                        step++;
                    }
                    else {
                        NavigationManager.NavigateTo("Initiative");
                    }
                };break;
            case 2: {
                    if (businessAcumen.level3.c1 == true && businessAcumen.level3.c2 == true && businessAcumen.level3.c3 == true && businessAcumen.level3.c4 == true)
                    {
                        if (businessAcumen.level5 == null)
                        {
                            businessAcumen.level5 = new Level();
                        }
                        sessionStorage.SetItemAsync("level3.c1", businessAcumen.level3.c1);
                        sessionStorage.SetItemAsync("level3.c2", businessAcumen.level3.c2);
                        sessionStorage.SetItemAsync("level3.c3", businessAcumen.level3.c3);
                        sessionStorage.SetItemAsync("level3.c4", businessAcumen.level3.c4);
                        step++;
                    }
                    else {
                        sessionStorage.SetItemAsync("level3.c1", businessAcumen.level3.c1);
                        sessionStorage.SetItemAsync("level3.c2", businessAcumen.level3.c2);
                        sessionStorage.SetItemAsync("level3.c3", businessAcumen.level3.c3);
                        sessionStorage.SetItemAsync("level3.c4", businessAcumen.level3.c4);
                        NavigationManager.NavigateTo("Initiative");
                    }
                };break;
            case 3: {
                    sessionStorage.SetItemAsync("level5.c1", businessAcumen.level5.c1);
                    sessionStorage.SetItemAsync("level5.c2", businessAcumen.level5.c2);
                    sessionStorage.SetItemAsync("level5.c3", businessAcumen.level5.c3);
                    sessionStorage.SetItemAsync("level5.c4", businessAcumen.level5.c4);
                    NavigationManager.NavigateTo("Initiative");
                };break;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591