#pragma checksum "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a22729c2b7fd3e660bcea25d7e3c7349a621fa7"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ServiceExcellence")]
    public partial class ServiceExcellencePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><b>ส่วนที่ 4</b>  มุ่งมั่นบริการ (Service Excellence)</h3>\r\n");
            __builder.AddMarkupContent(1, @"<p>
    ใช้ข้อมูล วิเคราะห์  ความต้องการของผู้รับบริการ และเพิ่มความสามารถการให้บริการ โดยปรับปรุงข้อจำกัดอุปสรรค และพัฒนาระบบงานที่ทันสมัยในการสร้างสรรค์ประสบการณ์ใหม่ๆ รวมถึงพัฒนามาตรฐานคุณภาพการบริการและการอำนวยความสะดวกให้ดียิ่งขึ้น เพื่อส่งเสริมภาพลักษณ์และความพึงพอใจโดยรวมของผู้ใช้บริการในทุกมิติ  มุ่งสู่การเป็นผู้เชี่ยวชาญธุรกิจบริการท่าอากาศยานระดับโลก
</p>

");
#nullable restore
#line 9 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
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
            __builder.AddMarkupContent(18, "<td>\r\n                            1. มีความรู้ในธุรกิจและลักษณะการให้บริการของหน่วยงาน\r\n                        </td>\r\n                        ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "label");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "checkbox");
            __builder.AddAttribute(23, "value", "1");
            __builder.AddAttribute(24, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
                                                                           serviceExcellence.level1.c1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => serviceExcellence.level1.c1 = __value, serviceExcellence.level1.c1));
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
            __builder.AddMarkupContent(31, "<td>\r\n                            2. รับฟังความต้องการ สามารถตอบสนองความต้องการของผู้รับบริการได้ครบถ้วน\r\n                        </td>\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "label");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "checkbox");
            __builder.AddAttribute(36, "value", "1");
            __builder.AddAttribute(37, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
                                                                           serviceExcellence.level1.c2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => serviceExcellence.level1.c2 = __value, serviceExcellence.level1.c2));
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
            __builder.AddMarkupContent(44, "<td>\r\n                            3. สามารถแก้ไขปัญหาร้องเรียนและตอบสนองความพึงพอใจของผู้รับบริการ\r\n                        </td>\r\n                        ");
            __builder.OpenElement(45, "td");
            __builder.OpenElement(46, "label");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "checkbox");
            __builder.AddAttribute(49, "value", "1");
            __builder.AddAttribute(50, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
                                                                           serviceExcellence.level1.c3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => serviceExcellence.level1.c3 = __value, serviceExcellence.level1.c3));
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
#line 42 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
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
#line 43 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
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
#line 46 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "\r\n\r\n");
#nullable restore
#line 49 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
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
            __builder.AddMarkupContent(88, "<td>\r\n                            1. รู้และเข้าใจมาตรฐาน คุณภาพการให้บริการ ข้อตกลงในการให้บริการ(SLA)ของหน่วยงานอย่างครบถ้วน\r\n                        </td>\r\n                        ");
            __builder.OpenElement(89, "td");
            __builder.OpenElement(90, "label");
            __builder.OpenElement(91, "input");
            __builder.AddAttribute(92, "type", "checkbox");
            __builder.AddAttribute(93, "value", "1");
            __builder.AddAttribute(94, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
                                                                           serviceExcellence.level3.c1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => serviceExcellence.level3.c1 = __value, serviceExcellence.level3.c1));
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
            __builder.AddMarkupContent(101, "<td>\r\n                            2. ปฏิบัติตามขั้นตอนการให้บริการและส่งมอบตามข้อตกลงอย่างสม่ำเสมอเป็นแบบอย่างที่ดีในหน่วยงาน\r\n                        </td>\r\n                        ");
            __builder.OpenElement(102, "td");
            __builder.OpenElement(103, "label");
            __builder.OpenElement(104, "input");
            __builder.AddAttribute(105, "type", "checkbox");
            __builder.AddAttribute(106, "value", "1");
            __builder.AddAttribute(107, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
                                                                           serviceExcellence.level3.c2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => serviceExcellence.level3.c2 = __value, serviceExcellence.level3.c2));
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
            __builder.AddMarkupContent(114, "<td>\r\n                            3. ตอบสนองความพึงพอใจผู้รับบริการเกินความคาดหวังได้รับคำชื่นชม\r\n                        </td>\r\n                        ");
            __builder.OpenElement(115, "td");
            __builder.OpenElement(116, "label");
            __builder.OpenElement(117, "input");
            __builder.AddAttribute(118, "type", "checkbox");
            __builder.AddAttribute(119, "value", "1");
            __builder.AddAttribute(120, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
                                                                           serviceExcellence.level3.c3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => serviceExcellence.level3.c3 = __value, serviceExcellence.level3.c3));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n            ");
            __builder.OpenElement(127, "button");
            __builder.AddAttribute(128, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
                              gotoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(129, "type", "button");
            __builder.AddAttribute(130, "class", "btn btn-default mt-5");
            __builder.AddContent(131, "  Back  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n            ");
            __builder.OpenElement(133, "button");
            __builder.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
                              gotoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(135, "type", "button");
            __builder.AddAttribute(136, "class", "btn btn-primary mt-5");
            __builder.AddContent(137, "  Next  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
#nullable restore
#line 86 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(141, "\r\n\r\n");
#nullable restore
#line 89 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
 if (step == 3)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(142, "    ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "row");
            __builder.AddMarkupContent(145, "\r\n        ");
            __builder.OpenElement(146, "div");
            __builder.AddAttribute(147, "class", "col-lg-12");
            __builder.AddMarkupContent(148, "\r\n            ");
            __builder.AddMarkupContent(149, "<h4 class=\"mt-5 mb-2\">ระดับที่ 5</h4>\r\n            ");
            __builder.OpenElement(150, "table");
            __builder.AddAttribute(151, "class", "table table-bordered");
            __builder.AddMarkupContent(152, "\r\n                ");
            __builder.AddMarkupContent(153, "<thead>\r\n                    <tr>\r\n                        <th>หัวข้อ</th>\r\n                        <th nowarp=\"nowarp\" style=\"width:100px;\">คำตอบ</th>\r\n                    </tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(154, "tbody");
            __builder.AddMarkupContent(155, "\r\n                    ");
            __builder.OpenElement(156, "tr");
            __builder.AddMarkupContent(157, "\r\n                        ");
            __builder.AddMarkupContent(158, "<td>\r\n                            1. มีความรู้ ความเข้าใจในระบบการให้บริการของทอท. ข้อมูลความต้องการ ความคาดหวัง ของผู้รับบริการประเภทต่างๆ\r\n                        </td>\r\n                        ");
            __builder.OpenElement(159, "td");
            __builder.OpenElement(160, "label");
            __builder.OpenElement(161, "input");
            __builder.AddAttribute(162, "type", "checkbox");
            __builder.AddAttribute(163, "value", "1");
            __builder.AddAttribute(164, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 106 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
                                                                           serviceExcellence.level5.c1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(165, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => serviceExcellence.level5.c1 = __value, serviceExcellence.level5.c1));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n                    ");
            __builder.OpenElement(169, "tr");
            __builder.AddMarkupContent(170, "\r\n                        ");
            __builder.AddMarkupContent(171, "<td>\r\n                            2. ใช้ฐานข้อมูลความต้องการของผู้รับบริการแต่ละกลุ่ม  มาออกแบบ พัฒนาระบบการให้บริการ\r\n                        </td>\r\n                        ");
            __builder.OpenElement(172, "td");
            __builder.OpenElement(173, "label");
            __builder.OpenElement(174, "input");
            __builder.AddAttribute(175, "type", "checkbox");
            __builder.AddAttribute(176, "value", "1");
            __builder.AddAttribute(177, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 112 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
                                                                           serviceExcellence.level5.c2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(178, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => serviceExcellence.level5.c2 = __value, serviceExcellence.level5.c2));
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
            __builder.AddMarkupContent(184, "<td>\r\n                            3. สามารถให้คำแนะนำการบริการที่เป็นเลิศกับหน่วยงานที่เกี่ยวข้อง\r\n                        </td>\r\n                        ");
            __builder.OpenElement(185, "td");
            __builder.OpenElement(186, "label");
            __builder.OpenElement(187, "input");
            __builder.AddAttribute(188, "type", "checkbox");
            __builder.AddAttribute(189, "value", "1");
            __builder.AddAttribute(190, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 118 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
                                                                           serviceExcellence.level5.c3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(191, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => serviceExcellence.level5.c3 = __value, serviceExcellence.level5.c3));
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
            __builder.AddMarkupContent(197, "<td>\r\n                            4. ผลักดันและร่วมออกแบบระบบการให้บริการที่สร้างสรรค์ โดยใช้เทคโนโลยีใหม่ๆ และดิจิทัลเพื่อสร้างประสบการณ์ใหม่ๆเทียบเท่าระดับสากลให้นำมาปฏิบัติได้\r\n                        </td>\r\n                        ");
            __builder.OpenElement(198, "td");
            __builder.OpenElement(199, "label");
            __builder.OpenElement(200, "input");
            __builder.AddAttribute(201, "type", "checkbox");
            __builder.AddAttribute(202, "value", "1");
            __builder.AddAttribute(203, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 124 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
                                                                           serviceExcellence.level5.c4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(204, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => serviceExcellence.level5.c4 = __value, serviceExcellence.level5.c4));
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
            __builder.AddMarkupContent(210, "<td>\r\n                            5. เพิ่มความพึงพอใจให้ผู้รับบริการ มีผลการประเมินความพึงพอใจจากผู้รับบริการ\r\n                        </td>\r\n                        ");
            __builder.OpenElement(211, "td");
            __builder.OpenElement(212, "label");
            __builder.OpenElement(213, "input");
            __builder.AddAttribute(214, "type", "checkbox");
            __builder.AddAttribute(215, "value", "1");
            __builder.AddAttribute(216, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 130 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
                                                                           serviceExcellence.level5.c5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(217, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => serviceExcellence.level5.c5 = __value, serviceExcellence.level5.c5));
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
#line 134 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
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
#line 135 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
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
#line 138 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 140 "D:\Projects\BlazorWebEvaluate\BlazorWebEvaluate\Pages\ServiceExcellencePage.razor"
       

    public ServiceExcellence serviceExcellence;
    private int step = 1;

    protected override async Task OnInitializedAsync()
    {
        serviceExcellence = new ServiceExcellence();
        serviceExcellence.level1 = new Level();
        await base.OnParametersSetAsync();
    }

    void gotoBack()
    {
        if (step == 1)
        {
            NavigationManager.NavigateTo("Collaboration");
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
                    if (serviceExcellence.level1.c1 == true && serviceExcellence.level1.c2 == true && serviceExcellence.level1.c3 == true)
                    {
                        if (serviceExcellence.level3 == null)
                        {
                            serviceExcellence.level3 = new Level();
                        }
                        step++;
                    }
                    else
                    {
                        NavigationManager.NavigateTo("SafetyAndSecurity");
                    }
                }; break;
            case 2:
                {
                    if (serviceExcellence.level3.c1 == true && serviceExcellence.level3.c2 == true && serviceExcellence.level3.c3 == true)
                    {
                        if (serviceExcellence.level5 == null)
                        {
                            serviceExcellence.level5 = new Level();
                        }
                        step++;
                    }
                    else
                    {
                        NavigationManager.NavigateTo("SafetyAndSecurity");
                    }
                }; break;
            case 3:
                {
                    NavigationManager.NavigateTo("SafetyAndSecurity");
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
