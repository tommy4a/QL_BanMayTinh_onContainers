#pragma checksum "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c77ef9fc006d5637b24f6eda3cffffe4596db9a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CTPN_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/CTPN/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/CTPN/Edit.cshtml", typeof(AspNetCore.Areas_Admin_Views_CTPN_Edit))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c77ef9fc006d5637b24f6eda3cffffe4596db9a9", @"/Areas/Admin/Views/CTPN/Edit.cshtml")]
    public class Areas_Admin_Views_CTPN_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QL_BanMayTinh_Main.EF.Chitietphieunhap>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(173, 198, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        var slt = parseInt(document.getElementById(\"slt\").value);\r\n\r\n        function changecost() {\r\n            document.getElementById(\"thanhtien\").value = ");
                EndContext();
                BeginContext(372, 31, false);
#line 14 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
                                                    Write(Convert.ToInt32(ViewBag.TienSP));

#line default
#line hidden
                EndContext();
                BeginContext(403, 113, true);
                WriteLiteral(" * parseInt(document.getElementById(\"soluong\").value);\r\n            document.getElementById(\"slt\").value = slt - ");
                EndContext();
                BeginContext(517, 19, false);
#line 15 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
                                                    Write(ViewBag.SoLuongSPCu);

#line default
#line hidden
                EndContext();
                BeginContext(536, 483, true);
                WriteLiteral(@" + parseInt(document.getElementById(""soluong"").value);
            if (document.getElementById(""slt"").value < 0) {
                document.getElementById(""info"").style.display = ""block"";
                document.getElementById(""sm"").style.display = ""none"";
            }
            else {
                document.getElementById(""info"").style.display = ""none"";
                document.getElementById(""sm"").style.display = ""block"";
            }
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(1022, 24, true);
            WriteLiteral("\r\n<h2>Chỉnh sửa</h2>\r\n\r\n");
            EndContext();
#line 30 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(1081, 23, false);
#line 32 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1108, 265, true);
            WriteLiteral(@"    <div class=""form-horizontal"">
        <h4>Chi tiết phiếu nhập</h4>
        <hr />

        <div class=""alert alert-danger"" role=""alert"" style=""display:none"" id=""info"">
            <strong>Số lượng tồn trong kho không đủ</strong>
        </div>

        ");
            EndContext();
            BeginContext(1374, 64, false);
#line 42 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1449, 35, false);
#line 43 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
   Write(Html.HiddenFor(model => model.MaPn));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1495, 35, false);
#line 44 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
   Write(Html.HiddenFor(model => model.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(1530, 50, true);
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1581, 93, false);
#line 47 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
       Write(Html.LabelFor(model => model.MaSp, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1674, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1730, 139, false);
#line 49 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
           Write(Html.EditorFor(model => model.MaSp, new { htmlAttributes = new { @class = "form-control", @style = "width:40%", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1869, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1888, 82, false);
#line 50 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.MaSp, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1970, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2057, 109, false);
#line 55 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
       Write(Html.LabelFor(model => model.MaSpNavigation.TenSp, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2166, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2222, 155, false);
#line 57 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
           Write(Html.EditorFor(model => model.MaSpNavigation.TenSp, new { htmlAttributes = new { @class = "form-control", @style = "width:40%", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2377, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2396, 98, false);
#line 58 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.MaSpNavigation.TenSp, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2494, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2581, 114, false);
#line 63 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
       Write(Html.LabelFor(model => model.MaSpNavigation.SoLuongTon, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2695, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2751, 173, false);
#line 65 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
           Write(Html.EditorFor(model => model.MaSpNavigation.SoLuongTon, new { htmlAttributes = new { @class = "form-control", @style = "width:40%", @readonly = "readonly", @id = "slt" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2924, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2943, 103, false);
#line 66 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.MaSpNavigation.SoLuongTon, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3046, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(3133, 112, false);
#line 71 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
       Write(Html.LabelFor(model => model.MaSpNavigation.GiaBanLe, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3245, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(3301, 171, false);
#line 73 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
           Write(Html.EditorFor(model => model.MaSpNavigation.GiaBanLe, new { htmlAttributes = new { @class = "form-control", @style = "width:40%", @readonly = "readonly", @id = "slt" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3472, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3491, 101, false);
#line 74 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.MaSpNavigation.GiaBanLe, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3592, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(3679, 100, false);
#line 79 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
       Write(Html.LabelFor(model => model.SoLuongNhap, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3779, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(3835, 166, false);
#line 81 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
           Write(Html.EditorFor(model => model.SoLuongNhap, new { htmlAttributes = new { @class = "form-control", @id = "soluong", @style = "width:40%", @oninput = "changecost()" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4001, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(4020, 89, false);
#line 82 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.SoLuongNhap, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4109, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(4196, 98, false);
#line 87 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
       Write(Html.LabelFor(model => model.ThanhTien, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4294, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(4350, 163, false);
#line 89 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
           Write(Html.EditorFor(model => model.ThanhTien, new { htmlAttributes = new { @class = "form-control", @style = "width:40%", @readonly = "readonly", @id = "thanhtien" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4513, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(4532, 87, false);
#line 90 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.ThanhTien, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4619, 260, true);
            WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Lưu"" class=""btn btn-primary"" id=""sm"" />
            </div>
        </div>
    </div>
");
            EndContext();
#line 100 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(4882, 42, true);
            WriteLiteral("<div>\r\n    <button class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4924, "\"", 5009, 4);
            WriteAttributeValue("", 4934, "location.href=\'", 4934, 15, true);
#line 102 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\CTPN\Edit.cshtml"
WriteAttributeValue("", 4949, Url.Action("Index", new { id = Model.MaPn }), 4949, 45, false);

#line default
#line hidden
            WriteAttributeValue("", 4994, "\';return", 4994, 8, true);
            WriteAttributeValue(" ", 5002, "false;", 5003, 7, true);
            EndWriteAttribute();
            BeginContext(5010, 60, true);
            WriteLiteral("><b>Trở lại</b></button>&nbsp&nbsp&nbsp&nbsp\r\n</div>\r\n<br />");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QL_BanMayTinh_Main.EF.Chitietphieunhap> Html { get; private set; }
    }
}
#pragma warning restore 1591
