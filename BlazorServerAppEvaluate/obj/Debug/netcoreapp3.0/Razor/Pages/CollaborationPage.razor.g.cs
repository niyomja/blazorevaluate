#pragma checksum "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65e9bd8424bca5f9db55636a5e1be18b3079d70b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Collaboration")]
    public partial class CollaborationPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>\r\n    <b>ส่วนที่ 3</b> ประสานสัมพันธ์ (Collaboration)\r\n</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<p>ปฏิบัติงานด้วยความเข้าใจกระบวนการทำงานของแต่ละหน่วยงานทั้งภายใน และภายนอกองค์กรตลอดจนผู้มีส่วนได้ส่วนเสีย  โดยรับฟังความคิดเห็น แลกเปลี่ยนข้อมูล รวมถึงถ่ายทอดความรู้ระหว่างกัน  ผ่านการสร้างความร่วมมือประสานงานทั้งภายในและผู้มีส่วนได้ส่วนเสีย เพื่อให้งานบรรลุเป้าหมายในทิศทางเดียวกันทั้งในระดับ บุคคล หน่วยงาน และองค์กร นำพาองค์กรก้าวสู่การเป็นองค์กรที่มีสมรรถนะสูงระดับโลก Proficiency Level</p>



");
#nullable restore
#line 14 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
 if (step == 1)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-lg-12");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<h4 class=\"mt-5 mb-2\">ระดับที่ 1</h4>\r\n            ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table table-bordered");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<thead>\r\n                    <tr>\r\n                        <th>หัวข้อ</th>\r\n                        <th nowarp=\"nowarp\" style=\"width:100px;\">คำตอบ</th>\r\n                    </tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.AddMarkupContent(18, "<td>\r\n                            1. รู้และเข้าใจรูปแบบการทำงานภายในหน่วยงาน ทั้งเป้าหมายร่วม ทิศทาง ลักษณะงานที่เกี่ยวข้องและผลกระทบต่อผู้อื่น\r\n                        </td>\r\n                        ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "label");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "checkbox");
            __builder.AddAttribute(23, "value", "1");
            __builder.AddAttribute(24, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                                                                           collaboration.level1.c1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level1.c1 = __value, collaboration.level1.c1));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.AddMarkupContent(31, "<td>\r\n                            2. รับฟังความคิดเห็น มีการแลกเปลี่ยนข้อมูลระหว่างกัน ให้ข้อมูลที่ถูกต้อง รวดเร็ว\r\n                        </td>\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "label");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "checkbox");
            __builder.AddAttribute(36, "value", "1");
            __builder.AddAttribute(37, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                                                                           collaboration.level1.c2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level1.c2 = __value, collaboration.level1.c2));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "tr");
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.AddMarkupContent(44, "<td>\r\n                            3. ทำงานที่รับผิดชอบภายในหน่วยงานที่ได้รับมอบหมายจนสำเร็จตามเป้าหมายร่วมกัน\r\n                        </td>\r\n                        ");
            __builder.OpenElement(45, "td");
            __builder.OpenElement(46, "label");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "checkbox");
            __builder.AddAttribute(49, "value", "1");
            __builder.AddAttribute(50, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                                                                           collaboration.level1.c3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level1.c3 = __value, collaboration.level1.c3));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                              gotoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "class", "btn btn-default mt-5");
            __builder.AddContent(61, "  Back  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                              gotoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "class", "btn btn-primary mt-5");
            __builder.AddContent(67, "  Next  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 51 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "\r\n\r\n");
#nullable restore
#line 54 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
 if (step == 2)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, "    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "row");
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col-lg-12");
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.AddMarkupContent(79, "<h4 class=\"mt-5 mb-2\">ระดับที่ 3</h4>\r\n            ");
            __builder.OpenElement(80, "table");
            __builder.AddAttribute(81, "class", "table table-bordered");
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.AddMarkupContent(83, "<thead>\r\n                    <tr>\r\n                        <th>หัวข้อ</th>\r\n                        <th nowarp=\"nowarp\" style=\"width:100px;\">คำตอบ</th>\r\n                    </tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(84, "tbody");
            __builder.AddMarkupContent(85, "\r\n                    ");
            __builder.OpenElement(86, "tr");
            __builder.AddMarkupContent(87, "\r\n                        ");
            __builder.AddMarkupContent(88, "<td>\r\n                            1. รู้ เข้าใจรูปแบบ การทำงานของหน่วยงานอื่นในองค์กร เข้าใจเป้าหมาย ความต้องการ งานที่เกี่ยวข้องและผลกระทบต่อหน่วยงานข้างเคียง\r\n                        </td>\r\n                        ");
            __builder.OpenElement(89, "td");
            __builder.OpenElement(90, "label");
            __builder.OpenElement(91, "input");
            __builder.AddAttribute(92, "type", "checkbox");
            __builder.AddAttribute(93, "value", "1");
            __builder.AddAttribute(94, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                                                                           collaboration.level3.c1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level3.c1 = __value, collaboration.level3.c1));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                    ");
            __builder.OpenElement(99, "tr");
            __builder.AddMarkupContent(100, "\r\n                        ");
            __builder.AddMarkupContent(101, "<td>\r\n                            2. ทำงานร่วมกันแบบข้ามหน่วยงานได้  ในทิศทางเดียวกัน ตามกรอบระยะเวลา และความรับผิดชอบที่ได้รับมอบหมาย รับฟังความคิดเห็น แลกเปลี่ยนข้อมูลและให้ข้อมูลที่ถูกต้อง\r\n                        </td>\r\n                        ");
            __builder.OpenElement(102, "td");
            __builder.OpenElement(103, "label");
            __builder.OpenElement(104, "input");
            __builder.AddAttribute(105, "type", "checkbox");
            __builder.AddAttribute(106, "value", "1");
            __builder.AddAttribute(107, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                                                                           collaboration.level3.c2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level3.c2 = __value, collaboration.level3.c2));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                    ");
            __builder.OpenElement(112, "tr");
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.AddMarkupContent(114, "<td>\r\n                            3. ส่งต่อความรู้  สอนให้คำแนะนำผู้อื่นในทีมได้\r\n                        </td>\r\n                        ");
            __builder.OpenElement(115, "td");
            __builder.OpenElement(116, "label");
            __builder.OpenElement(117, "input");
            __builder.AddAttribute(118, "type", "checkbox");
            __builder.AddAttribute(119, "value", "1");
            __builder.AddAttribute(120, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                                                                           collaboration.level3.c3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level3.c3 = __value, collaboration.level3.c3));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                    ");
            __builder.OpenElement(125, "tr");
            __builder.AddMarkupContent(126, "\r\n                        ");
            __builder.AddMarkupContent(127, "<td>\r\n                            4. มีบทบาทสำคัญทำให้งานของหน่วยงานและงานที่เกี่ยวข้องกับหน่วยงานอื่นประสบความสำเร็จตามเป้าหมายร่วมกัน\r\n                        </td>\r\n                        ");
            __builder.OpenElement(128, "td");
            __builder.OpenElement(129, "label");
            __builder.OpenElement(130, "input");
            __builder.AddAttribute(131, "type", "checkbox");
            __builder.AddAttribute(132, "value", "1");
            __builder.AddAttribute(133, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                                                                           collaboration.level3.c4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(134, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level3.c4 = __value, collaboration.level3.c4));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n            ");
            __builder.OpenElement(140, "button");
            __builder.AddAttribute(141, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                              gotoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(142, "type", "button");
            __builder.AddAttribute(143, "class", "btn btn-default mt-5");
            __builder.AddContent(144, "  Back  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n            ");
            __builder.OpenElement(146, "button");
            __builder.AddAttribute(147, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                              gotoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(148, "type", "button");
            __builder.AddAttribute(149, "class", "btn btn-primary mt-5");
            __builder.AddContent(150, "  Next  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n");
#nullable restore
#line 97 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(154, "\r\n\r\n");
#nullable restore
#line 100 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
 if (step == 3)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(155, "    ");
            __builder.OpenElement(156, "div");
            __builder.AddAttribute(157, "class", "row");
            __builder.AddMarkupContent(158, "\r\n        ");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "class", "col-lg-12");
            __builder.AddMarkupContent(161, "\r\n            ");
            __builder.AddMarkupContent(162, "<h4 class=\"mt-5 mb-2\">ระดับที่ 5</h4>\r\n            ");
            __builder.OpenElement(163, "table");
            __builder.AddAttribute(164, "class", "table table-bordered");
            __builder.AddMarkupContent(165, "\r\n                ");
            __builder.AddMarkupContent(166, "<thead>\r\n                    <tr>\r\n                        <th>หัวข้อ</th>\r\n                        <th nowarp=\"nowarp\" style=\"width:100px;\">คำตอบ</th>\r\n                    </tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(167, "tbody");
            __builder.AddMarkupContent(168, "\r\n                    ");
            __builder.OpenElement(169, "tr");
            __builder.AddMarkupContent(170, "\r\n                        ");
            __builder.AddMarkupContent(171, "<td>\r\n                            1. รู้ เข้าใจรูปแบบ การทำงานของหน่วยงานทั้งภายในและภายนอกองค์กร ความต้องการ ผลกระทบต่อหน่วยงานและผู้มีส่วนได้ส่วนเสีย\r\n                        </td>\r\n                        ");
            __builder.OpenElement(172, "td");
            __builder.OpenElement(173, "label");
            __builder.OpenElement(174, "input");
            __builder.AddAttribute(175, "type", "checkbox");
            __builder.AddAttribute(176, "value", "1");
            __builder.AddAttribute(177, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 117 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                                                                           collaboration.level5.c1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(178, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level5.c1 = __value, collaboration.level5.c1));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n                    ");
            __builder.OpenElement(182, "tr");
            __builder.AddMarkupContent(183, "\r\n                        ");
            __builder.AddMarkupContent(184, "<td>\r\n                            2. ประสานงาน กับผู้มีส่วนได้ส่วนเสีย\r\n                        </td>\r\n                        ");
            __builder.OpenElement(185, "td");
            __builder.OpenElement(186, "label");
            __builder.OpenElement(187, "input");
            __builder.AddAttribute(188, "type", "checkbox");
            __builder.AddAttribute(189, "value", "1");
            __builder.AddAttribute(190, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 123 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                                                                           collaboration.level5.c2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(191, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level5.c2 = __value, collaboration.level5.c2));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n                    ");
            __builder.OpenElement(195, "tr");
            __builder.AddMarkupContent(196, "\r\n                        ");
            __builder.AddMarkupContent(197, "<td>\r\n                            3. สร้างระบบการทำงานร่วมกันให้ดีขึ้นโดยใช้ข้อมูลและเทคโนโลยีดิจิทัล\r\n                        </td>\r\n                        ");
            __builder.OpenElement(198, "td");
            __builder.OpenElement(199, "label");
            __builder.OpenElement(200, "input");
            __builder.AddAttribute(201, "type", "checkbox");
            __builder.AddAttribute(202, "value", "1");
            __builder.AddAttribute(203, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 129 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                                                                           collaboration.level5.c3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(204, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level5.c3 = __value, collaboration.level5.c3));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(205, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(206, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(207, "\r\n                    ");
            __builder.OpenElement(208, "tr");
            __builder.AddMarkupContent(209, "\r\n                        ");
            __builder.AddMarkupContent(210, "<td>\r\n                            4. มีบทบาทสำคัญทำให้งานของหน่วยงานและงานที่เกี่ยวข้องกับผู้มีส่วนได้ส่วนเสีย ประสบความสำเร็จตามเป้าหมายร่วมกัน\r\n                        </td>\r\n                        ");
            __builder.OpenElement(211, "td");
            __builder.OpenElement(212, "label");
            __builder.OpenElement(213, "input");
            __builder.AddAttribute(214, "type", "checkbox");
            __builder.AddAttribute(215, "value", "1");
            __builder.AddAttribute(216, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 135 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                                                                           collaboration.level5.c4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(217, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => collaboration.level5.c4 = __value, collaboration.level5.c4));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(218, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(219, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(221, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\r\n            ");
            __builder.OpenElement(223, "button");
            __builder.AddAttribute(224, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 139 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                              gotoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(225, "type", "button");
            __builder.AddAttribute(226, "class", "btn btn-default mt-5");
            __builder.AddContent(227, "  Back  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(228, "\r\n            ");
            __builder.OpenElement(229, "button");
            __builder.AddAttribute(230, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 140 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
                              gotoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(231, "type", "button");
            __builder.AddAttribute(232, "class", "btn btn-primary mt-5");
            __builder.AddContent(233, "  Next  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(234, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(235, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(236, "\r\n");
#nullable restore
#line 143 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 145 "D:\Repositories\blazorevaluate\BlazorServerAppEvaluate\Pages\CollaborationPage.razor"
       

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
