#pragma checksum "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\ThongKe\thongkesanpham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cab08499ad67ebff500e5d595d329dd4cdb3f6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ThongKe_thongkesanpham), @"mvc.1.0.view", @"/Areas/Admin/Views/ThongKe/thongkesanpham.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ThongKe/thongkesanpham.cshtml", typeof(AspNetCore.Areas_Admin_Views_ThongKe_thongkesanpham))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cab08499ad67ebff500e5d595d329dd4cdb3f6b", @"/Areas/Admin/Views/ThongKe/thongkesanpham.cshtml")]
    public class Areas_Admin_Views_ThongKe_thongkesanpham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<QL_BanMayTinh_Main.Areas.Admin.Models.SanphambanchayModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\ThongKe\thongkesanpham.cshtml"
  
    ViewData["Title"] = "thongkesanpham";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(183, 497, true);
            WriteLiteral(@"
<div id=""piechart""></div>


<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

<script type=""text/javascript"">
    // Load google charts
    google.charts.load('current', { 'packages': ['corechart'] });
    google.charts.setOnLoadCallback(drawChart);

    // Draw the chart and set the chart values
    function drawChart() {
        var data = google.visualization.arrayToDataTable([

            ['Sản phẩm', 'Số lượng bán'],
            [""");
            EndContext();
            BeginContext(681, 25, false);
#line 23 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\ThongKe\thongkesanpham.cshtml"
         Write(Html.Raw(@Model[0].TenSP));

#line default
#line hidden
            EndContext();
            BeginContext(706, 8, true);
            WriteLiteral("\", { v: ");
            EndContext();
            BeginContext(715, 19, false);
#line 23 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\ThongKe\thongkesanpham.cshtml"
                                           Write(Model[0].SoLuongBan);

#line default
#line hidden
            EndContext();
            BeginContext(734, 19, true);
            WriteLiteral("}],\r\n            [\"");
            EndContext();
            BeginContext(754, 25, false);
#line 24 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\ThongKe\thongkesanpham.cshtml"
         Write(Html.Raw(@Model[1].TenSP));

#line default
#line hidden
            EndContext();
            BeginContext(779, 8, true);
            WriteLiteral("\", { v: ");
            EndContext();
            BeginContext(788, 19, false);
#line 24 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\ThongKe\thongkesanpham.cshtml"
                                           Write(Model[1].SoLuongBan);

#line default
#line hidden
            EndContext();
            BeginContext(807, 19, true);
            WriteLiteral("}],\r\n            [\"");
            EndContext();
            BeginContext(827, 25, false);
#line 25 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\ThongKe\thongkesanpham.cshtml"
         Write(Html.Raw(@Model[2].TenSP));

#line default
#line hidden
            EndContext();
            BeginContext(852, 8, true);
            WriteLiteral("\", { v: ");
            EndContext();
            BeginContext(861, 19, false);
#line 25 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\ThongKe\thongkesanpham.cshtml"
                                           Write(Model[2].SoLuongBan);

#line default
#line hidden
            EndContext();
            BeginContext(880, 534, true);
            WriteLiteral(@"}]
            
        ],
            false); // 'false' means that the first row contains labels, not data.





        // Optional; add a title and set the width and height of the chart
        var options = { 'title': 'Top 3 Sản phẩm bán chạy tháng 3', 'width': 1200, 'height': 400 };

        // Display the chart inside the <div> element with id=""piechart""


        var chart3 = new google.visualization.PieChart(document.getElementById('piechart'));


        chart3.draw(data, options);
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<QL_BanMayTinh_Main.Areas.Admin.Models.SanphambanchayModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
