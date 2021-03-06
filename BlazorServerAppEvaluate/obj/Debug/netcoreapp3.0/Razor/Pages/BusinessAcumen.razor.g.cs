#pragma checksum "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c4b204c7f335356668a983d277f1114b136fca7"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/BusinessAcumen")]
    public partial class BusinessAcumen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><b>ส่วนที่ 1</b> เชื่ยวชาญธุรกิจ (Business Acumen)</h3>\n\n");
            __builder.AddMarkupContent(1, @"<p>
    ความเข้าใจบริบทโครงสร้างหน่วยธุรกิจ โมเดลธุรกิจภารกิจงาน แผนกลยุทธ์ขององค์กร ลูกค้าและเครือข่ายพันธมิตร สามารถวิเคราะห์ข้อมูลด้านลูกค้า การตลาดการเงิน และผลกระทบที่มีต่อผู้มีส่วนได้ส่วนเสียที่เกี่ยวข้อง เพื่อใช้พิจารณาตัดสินใจวางแผนดำเนินงาน ธุรกิจ บริหารเครือข่ายพันธมิตรและความต่อเนื่องทางธุรกิจให้เกิดความสมดุลระหว่างคุณภาพการให้บริการ มาตรฐานความปลอดภัยระดับสากล และผลลัพธ์ด้านการเงิน
</p>");
#nullable restore
#line 12 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
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
            __builder.AddMarkupContent(12, "<td>1. รู้ศัพท์ทางธุรกิจและการเงินเบื้องต้น  เข้าใจการดำเนินธุรกิจ แผนกลยุทธ์ เป้าหมายขององค์กร ความรู้เกี่ยวกับลูกค้าตลาดและบริการของทอท. ในภาพรวม</td>\n                        ");
            __builder.OpenElement(13, "td");
            __builder.OpenElement(14, "label");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "checkbox");
            __builder.AddAttribute(17, "value", "1");
            __builder.AddAttribute(18, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                                                                           businessAcumen.level1.c1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => businessAcumen.level1.c1 = __value, businessAcumen.level1.c1));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "<td>2. อธิบายภาระงานของตนเอง และระบุผลงานที่ไปสนับสนุนเป้าหมายหน่วยงานและองค์กร</td>\n                        ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "label");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "checkbox");
            __builder.AddAttribute(28, "value", "1");
            __builder.AddAttribute(29, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                                                                           businessAcumen.level1.c2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => businessAcumen.level1.c2 = __value, businessAcumen.level1.c2));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                    ");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "<td>3. กำหนดแนวทางวิธีการทำงานตามที่ได้รับมอบหมายให้สามารถสนับสนุนเป้าหมายหน่วยงานและองค์กร</td>\n                        ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "label");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "checkbox");
            __builder.AddAttribute(39, "value", "1");
            __builder.AddAttribute(40, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                                                                           businessAcumen.level1.c3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => businessAcumen.level1.c3 = __value, businessAcumen.level1.c3));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                    ");
            __builder.OpenElement(44, "tr");
            __builder.AddMarkupContent(45, "<td>4. ปฏิบัติงานของตนบรรลุผลสำเร็จได้ตามเป้าหมาย</td>\n                        ");
            __builder.OpenElement(46, "td");
            __builder.OpenElement(47, "label");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "checkbox");
            __builder.AddAttribute(50, "value", "1");
            __builder.AddAttribute(51, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                                                                           businessAcumen.level1.c4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => businessAcumen.level1.c4 = __value, businessAcumen.level1.c4));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n            ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                              gotoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "type", "button");
            __builder.AddAttribute(58, "class", "btn btn-default mt-5");
            __builder.AddContent(59, "  Back  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n            ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                              gotoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "type", "button");
            __builder.AddAttribute(64, "class", "btn btn-primary mt-5");
            __builder.AddContent(65, "  Next  ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
 if (step == 2)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "row");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-lg-12");
            __builder.AddMarkupContent(70, "<h4 class=\"mt-5 mb-2\">ระดับที่ 3</h4>\n            ");
            __builder.OpenElement(71, "table");
            __builder.AddAttribute(72, "class", "table table-bordered");
            __builder.AddMarkupContent(73, "<thead><tr><th>หัวข้อ</th>\n                        <th nowarp=\"nowarp\" style=\"width:100px;\">คำตอบ</th></tr></thead>\n                ");
            __builder.OpenElement(74, "tbody");
            __builder.OpenElement(75, "tr");
            __builder.AddMarkupContent(76, "<td>1. รู้เข้าใจลึกซึ้งบริบทโครงสร้างหน่วยธุรกิจ โมเดลธุรกิจ ความต้องการของลูกค้า/เครือข่ายพันธมิตรและผู้มีส่วนได้ส่วนเสียที่เกี่ยวข้อง</td>\n                        ");
            __builder.OpenElement(77, "td");
            __builder.OpenElement(78, "label");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "type", "checkbox");
            __builder.AddAttribute(81, "value", "1");
            __builder.AddAttribute(82, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                                                                           businessAcumen.level3.c1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => businessAcumen.level3.c1 = __value, businessAcumen.level3.c1));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n                    ");
            __builder.OpenElement(86, "tr");
            __builder.AddMarkupContent(87, "<td> 2. วิเคราะห์ข้อมูลธุรกิจ ด้านลูกค้า การตลาด การเงิน และผลกระทบต่อผู้มีส่วนได้ส่วนเสียที่เกี่ยวข้อง</td>\n                        ");
            __builder.OpenElement(88, "td");
            __builder.OpenElement(89, "label");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "type", "checkbox");
            __builder.AddAttribute(92, "value", "1");
            __builder.AddAttribute(93, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                                                                           businessAcumen.level3.c2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => businessAcumen.level3.c2 = __value, businessAcumen.level3.c2));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n                    ");
            __builder.OpenElement(97, "tr");
            __builder.AddMarkupContent(98, @"<td>
                            3. นำเสนอแนวทางการทำงานดำเนินธุรกิจและเป้าหมายสนับสนุนพันธกิจกลยุทธ์หน่วยงาน/องค์กรที่ตอบสนองความต้องการของลูกค้า/เครือข่ายพันธมิตร และผู้มีส่วนได้ส่วนเสียที่เกี่ยวข้องได้อย่างรวดเร็ว ทันสถานการณ์แก่หน่วยงานที่รับผิดชอบและหน่วยงานที่เกี่ยวข้อง
                        </td>
                        ");
            __builder.OpenElement(99, "td");
            __builder.OpenElement(100, "label");
            __builder.OpenElement(101, "input");
            __builder.AddAttribute(102, "type", "checkbox");
            __builder.AddAttribute(103, "value", "1");
            __builder.AddAttribute(104, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                                                                           businessAcumen.level3.c3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => businessAcumen.level3.c3 = __value, businessAcumen.level3.c3));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\n                    ");
            __builder.OpenElement(108, "tr");
            __builder.AddMarkupContent(109, "<td>4. ตัดสินใจดำเนินงานตามแนวทางการดำเนินธุรกิจที่สนับสนุนพันธกิจกลยุทธ์องค์กรและเครือข่ายพันธมิตรในฐานะเป็น Business Partner ได้ผลลัพธ์ตามเป้าหมาย</td>\n                        ");
            __builder.OpenElement(110, "td");
            __builder.OpenElement(111, "label");
            __builder.OpenElement(112, "input");
            __builder.AddAttribute(113, "type", "checkbox");
            __builder.AddAttribute(114, "value", "1");
            __builder.AddAttribute(115, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 78 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                                                                           businessAcumen.level3.c4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => businessAcumen.level3.c4 = __value, businessAcumen.level3.c4));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\n            ");
            __builder.OpenElement(119, "button");
            __builder.AddAttribute(120, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                              gotoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "type", "button");
            __builder.AddAttribute(122, "class", "btn btn-default mt-5");
            __builder.AddContent(123, "  Back  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\n            ");
            __builder.OpenElement(125, "button");
            __builder.AddAttribute(126, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                              gotoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(127, "type", "button");
            __builder.AddAttribute(128, "class", "btn btn-primary mt-5");
            __builder.AddContent(129, "  Next  ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 86 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
 if (step == 3)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "row");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "col-lg-12");
            __builder.AddMarkupContent(134, "<h4 class=\"mt-5 mb-2\">ระดับที่ 5</h4>\n            ");
            __builder.OpenElement(135, "table");
            __builder.AddAttribute(136, "class", "table table-bordered");
            __builder.AddMarkupContent(137, "<thead><tr><th>หัวข้อ</th>\n                        <th nowarp=\"nowarp\" style=\"width:100px;\">คำตอบ</th></tr></thead>\n                ");
            __builder.OpenElement(138, "tbody");
            __builder.OpenElement(139, "tr");
            __builder.AddMarkupContent(140, "<td>1. รู้และตีความข้อมูลทางการเงิน (Financial Matrix) ได้อย่างถูกต้อง </td>\n                        ");
            __builder.OpenElement(141, "td");
            __builder.OpenElement(142, "label");
            __builder.OpenElement(143, "input");
            __builder.AddAttribute(144, "type", "checkbox");
            __builder.AddAttribute(145, "value", "1");
            __builder.AddAttribute(146, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 103 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                                                                           businessAcumen.level5.c1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(147, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => businessAcumen.level5.c1 = __value, businessAcumen.level5.c1));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\n                    ");
            __builder.OpenElement(150, "tr");
            __builder.AddMarkupContent(151, "<td>2. ศึกษาวิเคราะห์โอกาสทางธุรกิจ โมเดลธุรกิจใหม่ๆ จากคู่เทียบ / Best Practices ทั้งความรู้ด้านกลยุทธ์ การตลาดเชิงรุก การเงิน  เทคโนโลยี ความเสี่ยง การบริหารความต่อเนื่องทางธุรกิจ (Business Continuity Plan)</td>\n                        ");
            __builder.OpenElement(152, "td");
            __builder.OpenElement(153, "label");
            __builder.OpenElement(154, "input");
            __builder.AddAttribute(155, "type", "checkbox");
            __builder.AddAttribute(156, "value", "1");
            __builder.AddAttribute(157, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 107 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                                                                           businessAcumen.level5.c2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(158, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => businessAcumen.level5.c2 = __value, businessAcumen.level5.c2));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\n                    ");
            __builder.OpenElement(161, "tr");
            __builder.AddMarkupContent(162, @"<td>
                            3. ดำเนินการและร่วมมือกับเครือข่ายพันธมิตรตามแนวทางดำเนินธุรกิจ สร้างคุณค่าต่อผู้มีส่วนได้ส่วนเสียที่เกี่ยวข้อง ตามมาตรฐานงานที่เกี่ยวข้องทั้งในด้านคุณภาพการให้บริการ มาตรฐานความปลอดภัยในระดับสากลและเป้าหมายด้านการเงิน
                        </td>
                        ");
            __builder.OpenElement(163, "td");
            __builder.OpenElement(164, "label");
            __builder.OpenElement(165, "input");
            __builder.AddAttribute(166, "type", "checkbox");
            __builder.AddAttribute(167, "value", "1");
            __builder.AddAttribute(168, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 113 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                                                                           businessAcumen.level5.c3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(169, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => businessAcumen.level5.c3 = __value, businessAcumen.level5.c3));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\n                    ");
            __builder.OpenElement(172, "tr");
            __builder.AddMarkupContent(173, "<td>4. สร้างผลลัพธ์ความสำเร็จได้ตามมาตรฐานที่เกี่ยวข้อง และเกิดความสมดุลระหว่างความเสี่ยง การตอบสนองผู้มีส่วนได้ส่วนเสียที่เกี่ยวข้อง และผลลัพธ์เป้าหมายด้านการเงินได้</td>\n                        ");
            __builder.OpenElement(174, "td");
            __builder.OpenElement(175, "label");
            __builder.OpenElement(176, "input");
            __builder.AddAttribute(177, "type", "checkbox");
            __builder.AddAttribute(178, "value", "1");
            __builder.AddAttribute(179, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 117 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                                                                           businessAcumen.level5.c4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(180, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => businessAcumen.level5.c4 = __value, businessAcumen.level5.c4));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, " ใช่");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\n            ");
            __builder.OpenElement(183, "button");
            __builder.AddAttribute(184, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 121 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                              gotoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(185, "type", "button");
            __builder.AddAttribute(186, "class", "btn btn-default mt-5");
            __builder.AddContent(187, "  Back  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\n            ");
            __builder.OpenElement(189, "button");
            __builder.AddAttribute(190, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
                              gotoNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(191, "type", "button");
            __builder.AddAttribute(192, "class", "btn btn-primary mt-5");
            __builder.AddContent(193, "  Next  ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 125 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 127 "/Users/niyom/Repository/blazorevaluate/BlazorServerAppEvaluate/Pages/BusinessAcumen.razor"
       
    public BusinessAcu businessAcumen;
    private int step = 1;

    protected override async Task OnInitializedAsync()
    {
        businessAcumen = new BusinessAcu();
        businessAcumen.level1 = new Level();
        businessAcumen.level3 = new Level();
        businessAcumen.level5 = new Level();

        if (!PreRenderFlag.IsPreRendering)
        {
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
        }

        await base.OnParametersSetAsync();
    }

    void gotoBack()
    {
        if (step == 1)
        {
            NavigationManager.NavigateTo("/");
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
                    else
                    {
                        sessionStorage.SetItemAsync("level1.c1", businessAcumen.level1.c1);
                        sessionStorage.SetItemAsync("level1.c2", businessAcumen.level1.c2);
                        sessionStorage.SetItemAsync("level1.c3", businessAcumen.level1.c3);
                        sessionStorage.SetItemAsync("level1.c4", businessAcumen.level1.c4);

                        NavigationManager.NavigateTo("Initiative");
                    }
                }; break;
            case 2:
                {
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
                    else
                    {
                        sessionStorage.SetItemAsync("level3.c1", businessAcumen.level3.c1);
                        sessionStorage.SetItemAsync("level3.c2", businessAcumen.level3.c2);
                        sessionStorage.SetItemAsync("level3.c3", businessAcumen.level3.c3);
                        sessionStorage.SetItemAsync("level3.c4", businessAcumen.level3.c4);
                        NavigationManager.NavigateTo("Initiative");
                    }
                }; break;
            case 3:
                {
                    sessionStorage.SetItemAsync("level5.c1", businessAcumen.level5.c1);
                    sessionStorage.SetItemAsync("level5.c2", businessAcumen.level5.c2);
                    sessionStorage.SetItemAsync("level5.c3", businessAcumen.level5.c3);
                    sessionStorage.SetItemAsync("level5.c4", businessAcumen.level5.c4);
                    NavigationManager.NavigateTo("Initiative");
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
