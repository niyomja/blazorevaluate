#pragma checksum "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfc8a17dc0079ca4fb92a0278c361e14d6c07113"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Collaboration")]
    public partial class CollaborationPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><b>ส่วนที่ 3</b> ประสานสัมพันธ์ (Collaboration)\n</h3>\n\n");
            __builder.AddMarkupContent(1, @"<p>ปฏิบัติงานด้วยความเข้าใจกระบวนการทำงานของแต่ละหน่วยงานทั้งภายใน และภายนอกองค์กรตลอดจนผู้มีส่วนได้ส่วนเสีย  โดยรับฟังความคิดเห็น แลกเปลี่ยนข้อมูล รวมถึงถ่ายทอดความรู้ระหว่างกัน  ผ่านการสร้างความร่วมมือประสานงานทั้งภายในและผู้มีส่วนได้ส่วนเสีย เพื่อให้งานบรรลุเป้าหมายในทิศทางเดียวกันทั้งในระดับ บุคคล หน่วยงาน และองค์กร นำพาองค์กรก้าวสู่การเป็นองค์กรที่มีสมรรถนะสูงระดับโลก Proficiency Level</p>");
#nullable restore
#line 14 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
 if (step == 1)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-lg-12");
            __builder.AddMarkupContent(6, "<h4 class=\"mt-5 mb-2\">ระดับที่ 1</h4>\n            ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-bordered");
            __builder.AddMarkupContent(9, "<thead><tr><th>หัวข้อ</th>\n                        <th nowarp=\"nowarp\" style=\"width:100px;\">คำตอบ</th></tr></thead>\n                ");
            __builder.OpenElement(10, "tbody");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "<td>\n                            1. รู้และเข้าใจรูปแบบการทำงานภายในหน่วยงาน ทั้งเป้าหมายร่วม ทิศทาง ลักษณะงานที่เกี่ยวข้องและผลกระทบต่อผู้อื่น\n                        </td>\n                        ");
            __builder.OpenElement(13, "td");
            __builder.OpenElement(14, "label");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "checkbox");
            __builder.AddAttribute(17, "value", "1");
            __builder.AddAttribute(18, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                                                                           collaboration.level1.c1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level1.c1 = __value, collaboration.level1.c1));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "<td>\n                            2. รับฟังความคิดเห็น มีการแลกเปลี่ยนข้อมูลระหว่างกัน ให้ข้อมูลที่ถูกต้อง รวดเร็ว\n                        </td>\n                        ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "label");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "checkbox");
            __builder.AddAttribute(28, "value", "1");
            __builder.AddAttribute(29, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                                                                           collaboration.level1.c2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level1.c2 = __value, collaboration.level1.c2));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                    ");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "<td>\n                            3. ทำงานที่รับผิดชอบภายในหน่วยงานที่ได้รับมอบหมายจนสำเร็จตามเป้าหมายร่วมกัน\n                        </td>\n                        ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "label");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "checkbox");
            __builder.AddAttribute(39, "value", "1");
            __builder.AddAttribute(40, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                                                                           collaboration.level1.c3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level1.c3 = __value, collaboration.level1.c3));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n            ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                              gotoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-default mt-5");
            __builder.AddContent(48, "  Back  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n            ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                              gotoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "btn btn-primary mt-5");
            __builder.AddContent(54, "  Next  ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
 if (step == 2)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "row");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-lg-12");
            __builder.AddMarkupContent(59, "<h4 class=\"mt-5 mb-2\">ระดับที่ 3</h4>\n            ");
            __builder.OpenElement(60, "table");
            __builder.AddAttribute(61, "class", "table table-bordered");
            __builder.AddMarkupContent(62, "<thead><tr><th>หัวข้อ</th>\n                        <th nowarp=\"nowarp\" style=\"width:100px;\">คำตอบ</th></tr></thead>\n                ");
            __builder.OpenElement(63, "tbody");
            __builder.OpenElement(64, "tr");
            __builder.AddMarkupContent(65, "<td>\n                            1. รู้ เข้าใจรูปแบบ การทำงานของหน่วยงานอื่นในองค์กร เข้าใจเป้าหมาย ความต้องการ งานที่เกี่ยวข้องและผลกระทบต่อหน่วยงานข้างเคียง\n                        </td>\n                        ");
            __builder.OpenElement(66, "td");
            __builder.OpenElement(67, "label");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "checkbox");
            __builder.AddAttribute(70, "value", "1");
            __builder.AddAttribute(71, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                                                                           collaboration.level3.c1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level3.c1 = __value, collaboration.level3.c1));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n                    ");
            __builder.OpenElement(75, "tr");
            __builder.AddMarkupContent(76, "<td>\n                            2. ทำงานร่วมกันแบบข้ามหน่วยงานได้  ในทิศทางเดียวกัน ตามกรอบระยะเวลา และความรับผิดชอบที่ได้รับมอบหมาย รับฟังความคิดเห็น แลกเปลี่ยนข้อมูลและให้ข้อมูลที่ถูกต้อง\n                        </td>\n                        ");
            __builder.OpenElement(77, "td");
            __builder.OpenElement(78, "label");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "type", "checkbox");
            __builder.AddAttribute(81, "value", "1");
            __builder.AddAttribute(82, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                                                                           collaboration.level3.c2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level3.c2 = __value, collaboration.level3.c2));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n                    ");
            __builder.OpenElement(86, "tr");
            __builder.AddMarkupContent(87, "<td>\n                            3. ส่งต่อความรู้  สอนให้คำแนะนำผู้อื่นในทีมได้\n                        </td>\n                        ");
            __builder.OpenElement(88, "td");
            __builder.OpenElement(89, "label");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "type", "checkbox");
            __builder.AddAttribute(92, "value", "1");
            __builder.AddAttribute(93, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                                                                           collaboration.level3.c3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level3.c3 = __value, collaboration.level3.c3));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n                    ");
            __builder.OpenElement(97, "tr");
            __builder.AddMarkupContent(98, "<td>\n                            4. มีบทบาทสำคัญทำให้งานของหน่วยงานและงานที่เกี่ยวข้องกับหน่วยงานอื่นประสบความสำเร็จตามเป้าหมายร่วมกัน\n                        </td>\n                        ");
            __builder.OpenElement(99, "td");
            __builder.OpenElement(100, "label");
            __builder.OpenElement(101, "input");
            __builder.AddAttribute(102, "type", "checkbox");
            __builder.AddAttribute(103, "value", "1");
            __builder.AddAttribute(104, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                                                                           collaboration.level3.c4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level3.c4 = __value, collaboration.level3.c4));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\n            ");
            __builder.OpenElement(108, "button");
            __builder.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                              gotoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "type", "button");
            __builder.AddAttribute(111, "class", "btn btn-default mt-5");
            __builder.AddContent(112, "  Back  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\n            ");
            __builder.OpenElement(114, "button");
            __builder.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                              gotoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "type", "button");
            __builder.AddAttribute(117, "class", "btn btn-primary mt-5");
            __builder.AddContent(118, "  Next  ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 97 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
 if (step == 3)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "row");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "col-lg-12");
            __builder.AddMarkupContent(123, "<h4 class=\"mt-5 mb-2\">ระดับที่ 5</h4>\n            ");
            __builder.OpenElement(124, "table");
            __builder.AddAttribute(125, "class", "table table-bordered");
            __builder.AddMarkupContent(126, "<thead><tr><th>หัวข้อ</th>\n                        <th nowarp=\"nowarp\" style=\"width:100px;\">คำตอบ</th></tr></thead>\n                ");
            __builder.OpenElement(127, "tbody");
            __builder.OpenElement(128, "tr");
            __builder.AddMarkupContent(129, "<td>\n                            1. รู้ เข้าใจรูปแบบ การทำงานของหน่วยงานทั้งภายในและภายนอกองค์กร ความต้องการ ผลกระทบต่อหน่วยงานและผู้มีส่วนได้ส่วนเสีย\n                        </td>\n                        ");
            __builder.OpenElement(130, "td");
            __builder.OpenElement(131, "label");
            __builder.OpenElement(132, "input");
            __builder.AddAttribute(133, "type", "checkbox");
            __builder.AddAttribute(134, "value", "1");
            __builder.AddAttribute(135, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 117 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                                                                           collaboration.level5.c1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(136, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level5.c1 = __value, collaboration.level5.c1));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\n                    ");
            __builder.OpenElement(139, "tr");
            __builder.AddMarkupContent(140, "<td>\n                            2. ประสานงาน กับผู้มีส่วนได้ส่วนเสีย\n                        </td>\n                        ");
            __builder.OpenElement(141, "td");
            __builder.OpenElement(142, "label");
            __builder.OpenElement(143, "input");
            __builder.AddAttribute(144, "type", "checkbox");
            __builder.AddAttribute(145, "value", "1");
            __builder.AddAttribute(146, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 123 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                                                                           collaboration.level5.c2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(147, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level5.c2 = __value, collaboration.level5.c2));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\n                    ");
            __builder.OpenElement(150, "tr");
            __builder.AddMarkupContent(151, "<td>\n                            3. สร้างระบบการทำงานร่วมกันให้ดีขึ้นโดยใช้ข้อมูลและเทคโนโลยีดิจิทัล\n                        </td>\n                        ");
            __builder.OpenElement(152, "td");
            __builder.OpenElement(153, "label");
            __builder.OpenElement(154, "input");
            __builder.AddAttribute(155, "type", "checkbox");
            __builder.AddAttribute(156, "value", "1");
            __builder.AddAttribute(157, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 129 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                                                                           collaboration.level5.c3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(158, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level5.c3 = __value, collaboration.level5.c3));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\n                    ");
            __builder.OpenElement(161, "tr");
            __builder.AddMarkupContent(162, "<td>\n                            4. มีบทบาทสำคัญทำให้งานของหน่วยงานและงานที่เกี่ยวข้องกับผู้มีส่วนได้ส่วนเสีย ประสบความสำเร็จตามเป้าหมายร่วมกัน\n                        </td>\n                        ");
            __builder.OpenElement(163, "td");
            __builder.OpenElement(164, "label");
            __builder.OpenElement(165, "input");
            __builder.AddAttribute(166, "type", "checkbox");
            __builder.AddAttribute(167, "value", "1");
            __builder.AddAttribute(168, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 135 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                                                                           collaboration.level5.c4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(169, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level5.c4 = __value, collaboration.level5.c4));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\n            ");
            __builder.OpenElement(172, "button");
            __builder.AddAttribute(173, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 139 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                              gotoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(174, "type", "button");
            __builder.AddAttribute(175, "class", "btn btn-default mt-5");
            __builder.AddContent(176, "  Back  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\n            ");
            __builder.OpenElement(178, "button");
            __builder.AddAttribute(179, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 140 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
                              gotoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(180, "type", "button");
            __builder.AddAttribute(181, "class", "btn btn-primary mt-5");
            __builder.AddContent(182, "  Next  ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 143 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 145 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/CollaborationPage.razor"
       

    public Collaboration collaboration;
    private int step = 1;

    protected override async Task OnInitializedAsync()
    {
        collaboration = new Collaboration();
        collaboration.level1 = new Level();
        collaboration.level3 = new Level();
        collaboration.level5 = new Level();

        if (!PreRenderFlag.IsPreRendering)
        {
            collaboration.level1.c1 = await sessionStorage.GetItemAsync<bool>("collaboration.level1.c1");
            collaboration.level1.c2 = await sessionStorage.GetItemAsync<bool>("collaboration.level1.c2");
            collaboration.level1.c3 = await sessionStorage.GetItemAsync<bool>("collaboration.level1.c3");

            collaboration.level3.c1 = await sessionStorage.GetItemAsync<bool>("collaboration.level3.c1");
            collaboration.level3.c2 = await sessionStorage.GetItemAsync<bool>("collaboration.level3.c2");
            collaboration.level3.c3 = await sessionStorage.GetItemAsync<bool>("collaboration.level3.c3");
            collaboration.level3.c4 = await sessionStorage.GetItemAsync<bool>("collaboration.level3.c4");

            collaboration.level5.c1 = await sessionStorage.GetItemAsync<bool>("collaboration.level5.c1");
            collaboration.level5.c2 = await sessionStorage.GetItemAsync<bool>("collaboration.level5.c2");
            collaboration.level5.c3 = await sessionStorage.GetItemAsync<bool>("collaboration.level5.c3");
            collaboration.level5.c4 = await sessionStorage.GetItemAsync<bool>("collaboration.level5.c4");
        }
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
                        sessionStorage.SetItemAsync("collaboration.level1.c1", collaboration.level1.c1);
                        sessionStorage.SetItemAsync("collaboration.level1.c2", collaboration.level1.c2);
                        sessionStorage.SetItemAsync("collaboration.level1.c3", collaboration.level1.c3);
                        step++;
                    }
                    else
                    {
                        sessionStorage.SetItemAsync("collaboration.level1.c1", collaboration.level1.c1);
                        sessionStorage.SetItemAsync("collaboration.level1.c2", collaboration.level1.c2);
                        sessionStorage.SetItemAsync("collaboration.level1.c3", collaboration.level1.c3);

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
                        sessionStorage.SetItemAsync("collaboration.level3.c1", collaboration.level3.c1);
                        sessionStorage.SetItemAsync("collaboration.level3.c2", collaboration.level3.c2);
                        sessionStorage.SetItemAsync("collaboration.level3.c3", collaboration.level3.c3);
                        sessionStorage.SetItemAsync("collaboration.level3.c4", collaboration.level3.c4);
                        step++;
                    }
                    else
                    {
                        sessionStorage.SetItemAsync("collaboration.level3.c1", collaboration.level3.c1);
                        sessionStorage.SetItemAsync("collaboration.level3.c2", collaboration.level3.c2);
                        sessionStorage.SetItemAsync("collaboration.level3.c3", collaboration.level3.c3);
                        sessionStorage.SetItemAsync("collaboration.level3.c4", collaboration.level3.c4);

                        NavigationManager.NavigateTo("ServiceExcellence");
                    }
                }; break;
            case 3:
                {
                    sessionStorage.SetItemAsync("collaboration.level5.c1", collaboration.level5.c1);
                    sessionStorage.SetItemAsync("collaboration.level5.c2", collaboration.level5.c2);
                    sessionStorage.SetItemAsync("collaboration.level5.c3", collaboration.level5.c3);
                    sessionStorage.SetItemAsync("collaboration.level5.c4", collaboration.level5.c4);

                    NavigationManager.NavigateTo("ServiceExcellence");
                }; break;
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
