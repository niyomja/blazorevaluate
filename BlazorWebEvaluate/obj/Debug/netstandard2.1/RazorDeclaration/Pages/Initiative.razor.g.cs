#pragma checksum "D:\Repositories\blazorevaluate\BlazorWebEvaluate\Pages\Initiative.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7a80cc392c98af7eaacaea9622c99a1bd8cb1f7"
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
#line 1 "D:\Repositories\blazorevaluate\BlazorWebEvaluate\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repositories\blazorevaluate\BlazorWebEvaluate\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repositories\blazorevaluate\BlazorWebEvaluate\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repositories\blazorevaluate\BlazorWebEvaluate\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repositories\blazorevaluate\BlazorWebEvaluate\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repositories\blazorevaluate\BlazorWebEvaluate\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repositories\blazorevaluate\BlazorWebEvaluate\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repositories\blazorevaluate\BlazorWebEvaluate\_Imports.razor"
using BlazorWebEvaluate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repositories\blazorevaluate\BlazorWebEvaluate\_Imports.razor"
using BlazorWebEvaluate.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Repositories\blazorevaluate\BlazorWebEvaluate\_Imports.razor"
using BlazorWebEvaluate.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Initiative")]
    public partial class Initiative : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "D:\Repositories\blazorevaluate\BlazorWebEvaluate\Pages\Initiative.razor"
       

    public InitiativeData initiative;
    private int step = 1;

    protected override async Task OnInitializedAsync()
    {
        initiative = new InitiativeData();
        initiative.level1 = new Level();
        initiative.level3 = new Level();
        initiative.level5 = new Level();

        initiative.level1.c1 = await sessionStorage.GetItemAsync<bool>("initiative.level1.c1");
        initiative.level1.c2 = await sessionStorage.GetItemAsync<bool>("initiative.level1.c2");
        initiative.level1.c3 = await sessionStorage.GetItemAsync<bool>("initiative.level1.c3");

        initiative.level3.c1 = await sessionStorage.GetItemAsync<bool>("initiative.level3.c1");
        initiative.level3.c2 = await sessionStorage.GetItemAsync<bool>("initiative.level3.c2");
        initiative.level3.c3 = await sessionStorage.GetItemAsync<bool>("initiative.level3.c3");
        initiative.level3.c4 = await sessionStorage.GetItemAsync<bool>("initiative.level3.c4");
        initiative.level3.c5 = await sessionStorage.GetItemAsync<bool>("initiative.level3.c5");

        initiative.level5.c1 = await sessionStorage.GetItemAsync<bool>("initiative.level5.c1");
        initiative.level5.c2 = await sessionStorage.GetItemAsync<bool>("initiative.level5.c2");
        initiative.level5.c3 = await sessionStorage.GetItemAsync<bool>("initiative.level5.c3");

        await base.OnParametersSetAsync();
    }

    void gotoBack()
    {
        if (step == 1)
        {
            NavigationManager.NavigateTo("BusinessAcumen");
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
                    if (initiative.level1.c1 == true && initiative.level1.c2 == true && initiative.level1.c3 == true)
                    {
                        if (initiative.level3 == null)
                        {
                            initiative.level3 = new Level();
                        }
                        sessionStorage.SetItemAsync("initiative.level1.c1", initiative.level1.c1);
                        sessionStorage.SetItemAsync("initiative.level1.c2", initiative.level1.c2);
                        sessionStorage.SetItemAsync("initiative.level1.c3", initiative.level1.c3);
                        step++;
                    }
                    else
                    {
                        sessionStorage.SetItemAsync("initiative.level1.c1", initiative.level1.c1);
                        sessionStorage.SetItemAsync("initiative.level1.c2", initiative.level1.c2);
                        sessionStorage.SetItemAsync("initiative.level1.c3", initiative.level1.c3);
                        NavigationManager.NavigateTo("Collaboration");
                    }
                }; break;
            case 2:
                {
                    if (initiative.level3.c1 == true && initiative.level3.c2 == true && initiative.level3.c3 == true && initiative.level3.c4 == true && initiative.level3.c5 == true)
                    {
                        if (initiative.level5 == null)
                        {
                            initiative.level5 = new Level();
                        }
                        sessionStorage.SetItemAsync("initiative.level3.c1", initiative.level3.c1);
                        sessionStorage.SetItemAsync("initiative.level3.c2", initiative.level3.c2);
                        sessionStorage.SetItemAsync("initiative.level3.c3", initiative.level3.c3);
                        sessionStorage.SetItemAsync("initiative.level3.c4", initiative.level3.c4);
                        sessionStorage.SetItemAsync("initiative.level3.c5", initiative.level3.c5);
                        step++;
                    }
                    else
                    {
                        sessionStorage.SetItemAsync("initiative.level3.c1", initiative.level3.c1);
                        sessionStorage.SetItemAsync("initiative.level3.c2", initiative.level3.c2);
                        sessionStorage.SetItemAsync("initiative.level3.c3", initiative.level3.c3);
                        sessionStorage.SetItemAsync("initiative.level3.c4", initiative.level3.c4);
                        sessionStorage.SetItemAsync("initiative.level3.c5", initiative.level3.c5);
                        NavigationManager.NavigateTo("Collaboration");
                    }
                }; break;
            case 3:
                {
                    sessionStorage.SetItemAsync("initiative.level5.c1", initiative.level5.c1);
                    sessionStorage.SetItemAsync("initiative.level5.c2", initiative.level5.c2);
                    sessionStorage.SetItemAsync("initiative.level5.c3", initiative.level5.c3);
                    NavigationManager.NavigateTo("Collaboration");
                }; break;
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
