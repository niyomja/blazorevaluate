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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Change-Catalyst")]
    public partial class ChangeCatalyst : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 178 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/ChangeCatalyst.razor"
       

    public ChangeCatalystData changeCatalyst;
    private int step = 1;

    protected override async Task OnInitializedAsync()
    {
        changeCatalyst = new ChangeCatalystData();
        changeCatalyst.level1 = new Level();
        changeCatalyst.level3 = new Level();
        changeCatalyst.level5 = new Level();

        changeCatalyst.level1.c1 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level1.c1");
        changeCatalyst.level1.c2 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level1.c2");
        changeCatalyst.level1.c3 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level1.c3");
        changeCatalyst.level1.c4 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level1.c4");
        changeCatalyst.level1.c5 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level1.c5");

        changeCatalyst.level3.c1 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level3.c1");
        changeCatalyst.level3.c2 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level3.c2");
        changeCatalyst.level3.c3 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level3.c3");
        changeCatalyst.level3.c4 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level3.c4");
        changeCatalyst.level3.c5 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level3.c5");

        changeCatalyst.level5.c1 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level5.c1");
        changeCatalyst.level5.c2 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level5.c2");
        changeCatalyst.level5.c3 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level5.c3");
        changeCatalyst.level5.c4 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level5.c4");
        changeCatalyst.level5.c5 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level5.c5");

        await base.OnParametersSetAsync();
    }

    void gotoBack()
    {
        if (step == 1)
        {
            NavigationManager.NavigateTo("Business-Management");
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
                    if (changeCatalyst.level1.c1 == true && changeCatalyst.level1.c2 == true && changeCatalyst.level1.c3 == true && changeCatalyst.level1.c4 == true && changeCatalyst.level1.c5 == true)
                    {
                        if (changeCatalyst.level3 == null)
                        {
                            changeCatalyst.level3 = new Level();
                        }
                        sessionStorage.SetItemAsync("changeCatalyst.level1.c1", changeCatalyst.level1.c1);
                        sessionStorage.SetItemAsync("changeCatalyst.level1.c2", changeCatalyst.level1.c2);
                        sessionStorage.SetItemAsync("changeCatalyst.level1.c3", changeCatalyst.level1.c3);
                        sessionStorage.SetItemAsync("changeCatalyst.level1.c4", changeCatalyst.level1.c4);
                        sessionStorage.SetItemAsync("changeCatalyst.level1.c5", changeCatalyst.level1.c5);
                        step++;
                    }
                    else
                    {
                        sessionStorage.SetItemAsync("changeCatalyst.level1.c1", changeCatalyst.level1.c1);
                        sessionStorage.SetItemAsync("changeCatalyst.level1.c2", changeCatalyst.level1.c2);
                        sessionStorage.SetItemAsync("changeCatalyst.level1.c3", changeCatalyst.level1.c3);
                        sessionStorage.SetItemAsync("changeCatalyst.level1.c4", changeCatalyst.level1.c4);
                        sessionStorage.SetItemAsync("changeCatalyst.level1.c5", changeCatalyst.level1.c5);

                        NavigationManager.NavigateTo("CSR-for-Sustainable");
                    }
                }; break;
            case 2:
                {
                    if (changeCatalyst.level3.c1 == true && changeCatalyst.level3.c2 == true && changeCatalyst.level3.c3 == true && changeCatalyst.level3.c4 == true && changeCatalyst.level3.c5 == true)
                    {
                        if (changeCatalyst.level5 == null)
                        {
                            changeCatalyst.level5 = new Level();
                        }
                        sessionStorage.SetItemAsync("changeCatalyst.level3.c1", changeCatalyst.level3.c1);
                        sessionStorage.SetItemAsync("changeCatalyst.level3.c2", changeCatalyst.level3.c2);
                        sessionStorage.SetItemAsync("changeCatalyst.level3.c3", changeCatalyst.level3.c3);
                        sessionStorage.SetItemAsync("changeCatalyst.level3.c4", changeCatalyst.level3.c4);
                        sessionStorage.SetItemAsync("changeCatalyst.level3.c5", changeCatalyst.level3.c5);
                        step++;
                    }
                    else
                    {
                        sessionStorage.SetItemAsync("changeCatalyst.level3.c1", changeCatalyst.level3.c1);
                        sessionStorage.SetItemAsync("changeCatalyst.level3.c2", changeCatalyst.level3.c2);
                        sessionStorage.SetItemAsync("changeCatalyst.level3.c3", changeCatalyst.level3.c3);
                        sessionStorage.SetItemAsync("changeCatalyst.level3.c4", changeCatalyst.level3.c4);
                        sessionStorage.SetItemAsync("changeCatalyst.level3.c5", changeCatalyst.level3.c5);

                        NavigationManager.NavigateTo("CSR-for-Sustainable");
                    }
                }; break;
            case 3:
                {
                    sessionStorage.SetItemAsync("changeCatalyst.level5.c1", changeCatalyst.level5.c1);
                    sessionStorage.SetItemAsync("changeCatalyst.level5.c2", changeCatalyst.level5.c2);
                    sessionStorage.SetItemAsync("changeCatalyst.level5.c3", changeCatalyst.level5.c3);
                    sessionStorage.SetItemAsync("changeCatalyst.level5.c4", changeCatalyst.level5.c4);
                    sessionStorage.SetItemAsync("changeCatalyst.level5.c5", changeCatalyst.level5.c5);

                    NavigationManager.NavigateTo("CSR-for-Sustainable");
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