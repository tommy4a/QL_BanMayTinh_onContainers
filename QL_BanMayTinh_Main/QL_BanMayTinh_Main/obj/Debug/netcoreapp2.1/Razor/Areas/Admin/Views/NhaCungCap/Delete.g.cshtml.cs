#pragma checksum "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0becd25282e52194932e708b8e5dc2f7733fea3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NhaCungCap_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/NhaCungCap/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/NhaCungCap/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_NhaCungCap_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0becd25282e52194932e708b8e5dc2f7733fea3c", @"/Areas/Admin/Views/NhaCungCap/Delete.cshtml")]
    public class Areas_Admin_Views_NhaCungCap_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QL_BanMayTinh_Main.EF.Nhacungcap>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 156, true);
            WriteLiteral("\r\n<h2>Xóa thông tin</h2>\r\n\r\n<h3>Bạn muốn xóa thông tin nhà cung cấp này?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(301, 41, false);
#line 15 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaNcc));

#line default
#line hidden
            EndContext();
            BeginContext(342, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(388, 37, false);
#line 19 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaNcc));

#line default
#line hidden
            EndContext();
            BeginContext(425, 63, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <br />\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(489, 42, false);
#line 25 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TenNcc));

#line default
#line hidden
            EndContext();
            BeginContext(531, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(577, 38, false);
#line 29 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TenNcc));

#line default
#line hidden
            EndContext();
            BeginContext(615, 63, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <br />\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(679, 42, false);
#line 35 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(721, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(767, 38, false);
#line 39 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(805, 63, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <br />\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(869, 39, false);
#line 45 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sdt));

#line default
#line hidden
            EndContext();
            BeginContext(908, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(954, 35, false);
#line 49 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sdt));

#line default
#line hidden
            EndContext();
            BeginContext(989, 32, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
            EndContext();
#line 54 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(1068, 23, false);
#line 56 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1095, 180, true);
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Xóa\" class=\"btn btn-danger\" />&nbsp&nbsp&nbsp&nbsp\r\n            <button class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1275, "\"", 1335, 4);
            WriteAttributeValue("", 1285, "location.href=\'", 1285, 15, true);
#line 60 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
WriteAttributeValue("", 1300, Url.Action("Index"), 1300, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 1320, "\';return", 1320, 8, true);
            WriteAttributeValue(" ", 1328, "false;", 1329, 7, true);
            EndWriteAttribute();
            BeginContext(1336, 62, true);
            WriteLiteral("><b>Trở lại</b></button>&nbsp&nbsp&nbsp&nbsp\r\n        </div>\r\n");
            EndContext();
#line 62 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\NhaCungCap\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(1405, 8, true);
            WriteLiteral("</div>\r\n");
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
