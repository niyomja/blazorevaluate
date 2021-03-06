#pragma checksum "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a798577c8a6ab678edcc904595443be04b910ff"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Summary")]
    public partial class SummaryPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Summary</h3>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-lg-12");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<h4 class=\"mt-5 mb-2\">ตารางสรุปผลการประเมิน</h4>\n");
#nullable restore
#line 11 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
         if(assessor != null && !String.IsNullOrEmpty(assessor.full_name)){

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "            ");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", "mt-2 mb-2");
            __builder.AddMarkupContent(11, "ผู้ประเมิน ");
            __builder.AddContent(12, 
#nullable restore
#line 12 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                                                 assessor.full_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n");
#nullable restore
#line 13 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "table-responsive");
            __builder.AddMarkupContent(17, "\n            ");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table table-bordered");
            __builder.AddAttribute(20, "style", "width:100%");
            __builder.AddMarkupContent(21, "\n                ");
            __builder.AddMarkupContent(22, @"<thead>
                    <tr>
                        <th colspan=""4""><img src=""img/logo.png""></th>
                        <th colspan=""2"" class=""text-center"">มีภาวะผู้นำ (Leadership) </th>
                        <th colspan=""2"" class=""text-center"">การบริหารจัดการธุรกิจยอดเยี่ยม (Business Management) </th>
                        <th colspan=""2"" class=""text-center"">สร้างสรรค์การเปลี่ยนแปลง (Change Catalyst) </th>
                        <th colspan=""2"" class=""text-center"">ความรับผิดชอบของสังคมต่อกิจการ (CSR for Sustainable) </th>
                    </tr>
                    <tr>
                        <th>No.</th>
                        <th>ชื่อ สกุล</th>
                        <th>Level</th>
                        <th>ค่าคาดหวัง</th>
                        <th>คะแนนประเมิน</th>
                        <th>ผลการประเมิน</th>
                        <th>คะแนนประเมิน</th>
                        <th>ผลการประเมิน</th>
                        <th>คะแนนประเมิน</th>
                        <th>ผลการประเมิน</th>
                        <th>คะแนนประเมิน</th>
                        <th>ผลการประเมิน</th>
                    </tr>
                </thead>
");
#nullable restore
#line 39 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
             if(evaluateList !=null){

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "tbody");
            __builder.AddMarkupContent(25, "\n");
#nullable restore
#line 41 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                 if(evaluateList.Count() > 0){
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                     for (int i=0;i<evaluateList.Count();i++)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                    ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\n                        ");
            __builder.OpenElement(29, "td");
            __builder.AddAttribute(30, "class", "text-center");
            __builder.AddContent(31, 
#nullable restore
#line 45 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                                                  1 + i

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                        ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 46 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                              evaluateList[i].full_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                        ");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "class", "text-center");
            __builder.AddContent(39, 
#nullable restore
#line 47 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                                                  evaluateList[i].top_level

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                        ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "class", "text-center");
            __builder.AddContent(43, 
#nullable restore
#line 48 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                                                  evaluateList[i].Max()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                        \n                        ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "class", "text-center");
            __builder.AddContent(47, 
#nullable restore
#line 50 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                                                  evaluateList[i].leadership_Scroll()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                        ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "class", "text-center");
            __builder.AddContent(51, 
#nullable restore
#line 51 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                                                  (evaluateList[i].leadership_Scroll() - evaluateList[i].Max())

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n                        \n                        ");
            __builder.OpenElement(53, "td");
            __builder.AddAttribute(54, "class", "text-center");
            __builder.AddContent(55, 
#nullable restore
#line 53 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                                                  evaluateList[i].businessManagement_Scroll()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n                        ");
            __builder.OpenElement(57, "td");
            __builder.AddAttribute(58, "class", "text-center");
            __builder.AddContent(59, " ");
            __builder.AddContent(60, 
#nullable restore
#line 54 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                                                   (evaluateList[i].businessManagement_Scroll() - evaluateList[i].Max())

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(61, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n\n                        ");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "class", "text-center");
            __builder.AddContent(65, " ");
            __builder.AddContent(66, 
#nullable restore
#line 56 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                                                   evaluateList[i].changeCatalyst_Scroll()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(67, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n                        ");
            __builder.OpenElement(69, "td");
            __builder.AddAttribute(70, "class", "text-center");
            __builder.AddContent(71, " ");
            __builder.AddContent(72, 
#nullable restore
#line 57 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                                                   (evaluateList[i].changeCatalyst_Scroll() - evaluateList[i].Max())

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(73, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n\n                        ");
            __builder.OpenElement(75, "td");
            __builder.AddAttribute(76, "class", "text-center");
            __builder.AddContent(77, " ");
            __builder.AddContent(78, 
#nullable restore
#line 59 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                                                   evaluateList[i].cSRforSustainable_Scroll()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(79, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\n                        ");
            __builder.OpenElement(81, "td");
            __builder.AddAttribute(82, "class", "text-center");
            __builder.AddContent(83, " ");
            __builder.AddContent(84, 
#nullable restore
#line 60 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                                                   (evaluateList[i].cSRforSustainable_Scroll() - evaluateList[i].Max())

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(85, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\n\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\n");
#nullable restore
#line 63 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                     
                }else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "                    ");
            __builder.AddMarkupContent(89, "<tr>\n                        <td colspan=\"16\" class=\"text-center\">\n                            <span class=\"text-mute\">No data to display.</span>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 70 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\n");
#nullable restore
#line 72 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
            }else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                    ");
            __builder.AddMarkupContent(93, @"<tbody>
                        <tr>
                            <td colspan=""16"" class=""text-center"">
                                <div class=""spinner-border m-5 text-center"" role=""status"">
                                    <span class=""sr-only"">Loading...</span>
                                </div>
                            </td>
                        </tr>
                    </tbody>
");
#nullable restore
#line 82 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(94, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n\n        ");
            __builder.OpenElement(97, "button");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
                          gotoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "type", "button");
            __builder.AddAttribute(100, "class", "btn btn-success mt-5");
            __builder.AddContent(101, "  Home  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "/Users/niyom/Repository/blazorevaluate/BlazorWebEvaluate/Pages/SummaryPage.razor"
       
    private Assessor assessor;
    private Evaluate evaluate;
    private List<EvaluateData> evaluateList;
    protected override async Task OnInitializedAsync()
    {
        evaluate = new Evaluate();
        evaluate.full_name = await sessionStorage.GetItemAsync<string>("full_name");
        evaluate.level = await sessionStorage.GetItemAsync<string>("level");

        // 1 )
        evaluate.leadership = new LeadershipData();
        evaluate.leadership.level1 = new Level();
        evaluate.leadership.level3 = new Level();
        evaluate.leadership.level5 = new Level();

        evaluate.leadership.level1.c1 = await sessionStorage.GetItemAsync<bool>("level1.c1");
        evaluate.leadership.level1.c2 = await sessionStorage.GetItemAsync<bool>("level1.c2");
        evaluate.leadership.level1.c3 = await sessionStorage.GetItemAsync<bool>("level1.c3");

        evaluate.leadership.level3.c1 = await sessionStorage.GetItemAsync<bool>("level3.c1");
        evaluate.leadership.level3.c2 = await sessionStorage.GetItemAsync<bool>("level3.c2");
        evaluate.leadership.level3.c3 = await sessionStorage.GetItemAsync<bool>("level3.c3");

        evaluate.leadership.level5.c1 = await sessionStorage.GetItemAsync<bool>("level5.c1");
        evaluate.leadership.level5.c2 = await sessionStorage.GetItemAsync<bool>("level5.c2");
        evaluate.leadership.level5.c3 = await sessionStorage.GetItemAsync<bool>("level5.c3");
        evaluate.leadership.level5.c4 = await sessionStorage.GetItemAsync<bool>("level5.c4");

        // 2 )
        evaluate.businessManagement = new  BusinessManagementData();
        evaluate.businessManagement.level1 = new Level();
        evaluate.businessManagement.level3 = new Level();
        evaluate.businessManagement.level5 = new Level();

        evaluate.businessManagement.level1.c1 = await sessionStorage.GetItemAsync<bool>("businessManagement.level1.c1");
        evaluate.businessManagement.level1.c2 = await sessionStorage.GetItemAsync<bool>("businessManagement.level1.c2");
        evaluate.businessManagement.level1.c3 = await sessionStorage.GetItemAsync<bool>("businessManagement.level1.c3");
        evaluate.businessManagement.level1.c4 = await sessionStorage.GetItemAsync<bool>("businessManagement.level1.c4");

        evaluate.businessManagement.level3.c1 = await sessionStorage.GetItemAsync<bool>("businessManagement.level3.c1");
        evaluate.businessManagement.level3.c2 = await sessionStorage.GetItemAsync<bool>("businessManagement.level3.c2");
        evaluate.businessManagement.level3.c3 = await sessionStorage.GetItemAsync<bool>("businessManagement.level3.c3");

        evaluate.businessManagement.level5.c1 = await sessionStorage.GetItemAsync<bool>("businessManagement.level5.c1");
        evaluate.businessManagement.level5.c2 = await sessionStorage.GetItemAsync<bool>("businessManagement.level5.c2");
        evaluate.businessManagement.level5.c3 = await sessionStorage.GetItemAsync<bool>("businessManagement.level5.c3");
        evaluate.businessManagement.level5.c4 = await sessionStorage.GetItemAsync<bool>("businessManagement.level5.c4");

        // 3 )
        evaluate.changeCatalyst = new ChangeCatalystData();
        evaluate.changeCatalyst.level1 = new Level();
        evaluate.changeCatalyst.level3 = new Level();
        evaluate.changeCatalyst.level5 = new Level();

        evaluate.changeCatalyst.level1.c1 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level1.c1");
        evaluate.changeCatalyst.level1.c2 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level1.c2");
        evaluate.changeCatalyst.level1.c3 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level1.c3");
        evaluate.changeCatalyst.level1.c4 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level1.c4");
        evaluate.changeCatalyst.level1.c5 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level1.c5");

        evaluate.changeCatalyst.level3.c1 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level3.c1");
        evaluate.changeCatalyst.level3.c2 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level3.c2");
        evaluate.changeCatalyst.level3.c3 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level3.c3");
        evaluate.changeCatalyst.level3.c4 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level3.c4");
        evaluate.changeCatalyst.level3.c5 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level3.c5");

        evaluate.changeCatalyst.level5.c1 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level5.c1");
        evaluate.changeCatalyst.level5.c2 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level5.c2");
        evaluate.changeCatalyst.level5.c3 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level5.c3");
        evaluate.changeCatalyst.level5.c4 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level5.c4");
        evaluate.changeCatalyst.level5.c5 = await sessionStorage.GetItemAsync<bool>("changeCatalyst.level5.c5");

        // 4 )
        evaluate.cSRforSustainable = new CSRforSustainableData();
        evaluate.cSRforSustainable.level1 = new Level();
        evaluate.cSRforSustainable.level3 = new Level();
        evaluate.cSRforSustainable.level5 = new Level();

        evaluate.cSRforSustainable.level1.c1 = await sessionStorage.GetItemAsync<bool>("cSRforSustainable.level1.c1");
        evaluate.cSRforSustainable.level1.c2 = await sessionStorage.GetItemAsync<bool>("cSRforSustainable.level1.c2");
        evaluate.cSRforSustainable.level1.c3 = await sessionStorage.GetItemAsync<bool>("cSRforSustainable.level1.c3");
        evaluate.cSRforSustainable.level1.c4 = await sessionStorage.GetItemAsync<bool>("cSRforSustainable.level1.c4");

        evaluate.cSRforSustainable.level3.c1 = await sessionStorage.GetItemAsync<bool>("cSRforSustainable.level3.c1");
        evaluate.cSRforSustainable.level3.c2 = await sessionStorage.GetItemAsync<bool>("cSRforSustainable.level3.c2");
        evaluate.cSRforSustainable.level3.c3 = await sessionStorage.GetItemAsync<bool>("cSRforSustainable.level3.c3");
        evaluate.cSRforSustainable.level3.c4 = await sessionStorage.GetItemAsync<bool>("cSRforSustainable.level3.c4");

        evaluate.cSRforSustainable.level5.c1 = await sessionStorage.GetItemAsync<bool>("cSRforSustainable.level5.c1");
        evaluate.cSRforSustainable.level5.c2 = await sessionStorage.GetItemAsync<bool>("cSRforSustainable.level5.c2");
        evaluate.cSRforSustainable.level5.c3 = await sessionStorage.GetItemAsync<bool>("cSRforSustainable.level5.c3");
        evaluate.cSRforSustainable.level5.c4 = await sessionStorage.GetItemAsync<bool>("cSRforSustainable.level5.c4");


        assessor = new Assessor();
        assessor.code =  await sessionStorage.GetItemAsync<string>("assessor.code");
        assessor.full_name =  await sessionStorage.GetItemAsync<string>("assessor.full_name");
        assessor.division = await sessionStorage.GetItemAsync<string>("assessor.division");
        assessor.level = await sessionStorage.GetItemAsync<string>("assessor.level");

        evaluate.assessor = assessor;

        if(!String.IsNullOrEmpty(evaluate.full_name)){

            var response = await Http.PostAsJsonAsync<Evaluate>("/ajax/postdata.php", evaluate);

            if(response.IsSuccessStatusCode){
                await sessionStorage.ClearAsync();

                await sessionStorage.SetItemAsync("assessor.code", assessor.code);
                await sessionStorage.SetItemAsync("assessor.full_name", assessor.full_name);
                await sessionStorage.SetItemAsync("assessor.division", assessor.division);
                await sessionStorage.SetItemAsync("assessor.level", assessor.level);
            }
        }

        string url = "/ajax/getdata.php?assessor_code=" + assessor.code;

        evaluateList = await Http.GetFromJsonAsync<List<EvaluateData>>(url);

        await base.OnParametersSetAsync();
    }

    void gotoBack()
    {
        NavigationManager.NavigateTo("");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
