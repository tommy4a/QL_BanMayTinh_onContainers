#pragma checksum "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "104bb8c3bd66d95d4be9909216ba78d902bd5310"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NhaCungCap_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/NhaCungCap/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/NhaCungCap/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_NhaCungCap_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"104bb8c3bd66d95d4be9909216ba78d902bd5310", @"/Areas/Admin/Views/NhaCungCap/Create.cshtml")]
    public class Areas_Admin_Views_NhaCungCap_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QL_BanMayTinh_Main.EF.Nhacungcap>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 22, true);
            WriteLiteral("\r\n<h2>Tạo mới</h2>\r\n\r\n");
            EndContext();
#line 10 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(201, 23, false);
#line 12 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(228, 90, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Nhà cung cấp</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(319, 64, false);
#line 17 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(383, 48, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(432, 94, false);
#line 19 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
       Write(Html.LabelFor(model => model.MaNcc, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(526, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(582, 140, false);
#line 21 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
           Write(Html.EditorFor(model => model.MaNcc, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly", @style = "width:50%" } }));

#line default
#line hidden
            EndContext();
            BeginContext(722, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(741, 83, false);
#line 22 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.MaNcc, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(824, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(911, 95, false);
#line 27 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
       Write(Html.LabelFor(model => model.TenNcc, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1062, 117, false);
#line 29 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
           Write(Html.EditorFor(model => model.TenNcc, new { htmlAttributes = new { @class = "form-control", @style = "width:50%" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1198, 84, false);
#line 30 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.TenNcc, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1369, 95, false);
#line 35 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
       Write(Html.LabelFor(model => model.DiaChi, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1520, 117, false);
#line 37 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
           Write(Html.EditorFor(model => model.DiaChi, new { htmlAttributes = new { @class = "form-control", @style = "width:50%" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1637, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1656, 84, false);
#line 38 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.DiaChi, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1827, 92, false);
#line 43 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
       Write(Html.LabelFor(model => model.Sdt, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1975, 114, false);
#line 45 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
           Write(Html.EditorFor(model => model.Sdt, new { htmlAttributes = new { @class = "form-control", @style = "width:50%" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2089, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2108, 81, false);
#line 46 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Sdt, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2189, 249, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Tạo\" class=\"btn btn-info\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 56 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
}

#line default
#line hidden
            BeginContext(2441, 44, true);
            WriteLiteral("\r\n<div>\r\n    <button class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2485, "\"", 2545, 4);
            WriteAttributeValue("", 2495, "location.href=\'", 2495, 15, true);
#line 59 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Create.cshtml"
WriteAttributeValue("", 2510, Url.Action("Index"), 2510, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 2530, "\';return", 2530, 8, true);
            WriteAttributeValue(" ", 2538, "false;", 2539, 7, true);
            EndWriteAttribute();
            BeginContext(2546, 54, true);
            WriteLiteral("><b>Trở lại</b></button>&nbsp&nbsp&nbsp&nbsp\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QL_BanMayTinh_Main.EF.Nhacungcap> Html { get; private set; }
    }
}
#pragma warning restore 1591
