#pragma checksum "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c5a337c4023edfeef0141738072db0ba6d371c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c5a337c4023edfeef0141738072db0ba6d371c2", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 1245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e09740344604fe1b727eb5ea99386c4", async() => {
                BeginContext(43, 1232, true);
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">

    <title>Trang Admin</title>

    <!-- Bootstrap Core CSS -->

    <link href=""/admin/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">

    <!-- MetisMenu CSS -->
    <link href=""/admin/vendor/metisMenu/metisMenu.min.css"" rel=""stylesheet"">

    <!-- Custom CSS -->
    <link href=""/admin/dist/css/sb-admin-2.css"" rel=""stylesheet"">

    <!-- Morris Charts CSS -->
    <link href=""/admin/vendor/morrisjs/morris.css"" rel=""stylesheet"">

    <!-- Custom Fonts -->
    <link href=""/admin/vendor/font-awesome/css/font-awesome.min.css"" rel=""stylesheet"" type=""text/css"">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE ");
                WriteLiteral("9]>\r\n        <script src=\"https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js\"></script>\r\n        <script src=\"https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js\"></script>\r\n    <![endif]-->\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1282, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1286, 15555, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf9b356769004be48f20f7bedb5ebeb0", async() => {
                BeginContext(1292, 612, true);
                WriteLiteral(@"

    <div id=""wrapper"">

        <!-- Navigation -->
        <nav class=""navbar navbar-default navbar-static-top"" role=""navigation"" style=""margin-bottom: 0"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                <a class=""navbar-brand""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1904, "\"", 1949, 1);
#line 52 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1911, Url.Action("IndexAdmin", "AdminHome"), 1911, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1950, 10720, true);
                WriteLiteral(@">Quản lí admin</a>
            </div>
            <!-- /.navbar-header -->

            <ul class=""nav navbar-top-links navbar-right"">
                <li class=""dropdown"">
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                        <i class=""fa fa-envelope fa-fw""></i> <i class=""fa fa-caret-down""></i>
                    </a>
                    <ul class=""dropdown-menu dropdown-messages"">
                        <li>
                            <a href=""#"">
                                <div>
                                    <strong>John Smith</strong>
                                    <span class=""pull-right text-muted"">
                                        <em>Yesterday</em>
                                    </span>
                                </div>
                                <div>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque eleifend...</div>
                            </a>
                      ");
                WriteLiteral(@"  </li>
                        <li class=""divider""></li>
                        <li>
                            <a href=""#"">
                                <div>
                                    <strong>John Smith</strong>
                                    <span class=""pull-right text-muted"">
                                        <em>Yesterday</em>
                                    </span>
                                </div>
                                <div>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque eleifend...</div>
                            </a>
                        </li>
                        <li class=""divider""></li>
                        <li>
                            <a href=""#"">
                                <div>
                                    <strong>John Smith</strong>
                                    <span class=""pull-right text-muted"">
                                        <em>Yesterday</em>
                 ");
                WriteLiteral(@"                   </span>
                                </div>
                                <div>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque eleifend...</div>
                            </a>
                        </li>
                        <li class=""divider""></li>
                        <li>
                            <a class=""text-center"" href=""#"">
                                <strong>Read All Messages</strong>
                                <i class=""fa fa-angle-right""></i>
                            </a>
                        </li>
                    </ul>
                    <!-- /.dropdown-messages -->
                </li>
                <!-- /.dropdown -->
                <li class=""dropdown"">
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                        <i class=""fa fa-tasks fa-fw""></i> <i class=""fa fa-caret-down""></i>
                    </a>
                    <ul class=""dropdown-menu dr");
                WriteLiteral(@"opdown-tasks"">
                        <li>
                            <a href=""#"">
                                <div>
                                    <p>
                                        <strong>Task 1</strong>
                                        <span class=""pull-right text-muted"">40% Complete</span>
                                    </p>
                                    <div class=""progress progress-striped active"">
                                        <div class=""progress-bar progress-bar-success"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 40%"">
                                            <span class=""sr-only"">40% Complete (success)</span>
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""divider""></li>
                        <li>
         ");
                WriteLiteral(@"                   <a href=""#"">
                                <div>
                                    <p>
                                        <strong>Task 2</strong>
                                        <span class=""pull-right text-muted"">20% Complete</span>
                                    </p>
                                    <div class=""progress progress-striped active"">
                                        <div class=""progress-bar progress-bar-info"" role=""progressbar"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 20%"">
                                            <span class=""sr-only"">20% Complete</span>
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""divider""></li>
                        <li>
                            <a href=""#"">
                                <di");
                WriteLiteral(@"v>
                                    <p>
                                        <strong>Task 3</strong>
                                        <span class=""pull-right text-muted"">60% Complete</span>
                                    </p>
                                    <div class=""progress progress-striped active"">
                                        <div class=""progress-bar progress-bar-warning"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%"">
                                            <span class=""sr-only"">60% Complete (warning)</span>
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""divider""></li>
                        <li>
                            <a href=""#"">
                                <div>
                                    <p>
          ");
                WriteLiteral(@"                              <strong>Task 4</strong>
                                        <span class=""pull-right text-muted"">80% Complete</span>
                                    </p>
                                    <div class=""progress progress-striped active"">
                                        <div class=""progress-bar progress-bar-danger"" role=""progressbar"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 80%"">
                                            <span class=""sr-only"">80% Complete (danger)</span>
                                        </div>
                                    </div>
                                </div>
                            </a>
                        </li>
                        <li class=""divider""></li>
                        <li>
                            <a class=""text-center"" href=""#"">
                                <strong>See All Tasks</strong>
                                <i class=""fa fa-angle-right""></");
                WriteLiteral(@"i>
                            </a>
                        </li>
                    </ul>
                    <!-- /.dropdown-tasks -->
                </li>
                <!-- /.dropdown -->
                <li class=""dropdown"">
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                        <i class=""fa fa-bell fa-fw""></i> <i class=""fa fa-caret-down""></i>
                    </a>
                    <ul class=""dropdown-menu dropdown-alerts"">
                        <li>
                            <a href=""#"">
                                <div>
                                    <i class=""fa fa-comment fa-fw""></i> New Comment
                                    <span class=""pull-right text-muted small"">4 minutes ago</span>
                                </div>
                            </a>
                        </li>
                        <li class=""divider""></li>
                        <li>
                            <a href=""#");
                WriteLiteral(@""">
                                <div>
                                    <i class=""fa fa-twitter fa-fw""></i> 3 New Followers
                                    <span class=""pull-right text-muted small"">12 minutes ago</span>
                                </div>
                            </a>
                        </li>
                        <li class=""divider""></li>
                        <li>
                            <a href=""#"">
                                <div>
                                    <i class=""fa fa-envelope fa-fw""></i> Message Sent
                                    <span class=""pull-right text-muted small"">4 minutes ago</span>
                                </div>
                            </a>
                        </li>
                        <li class=""divider""></li>
                        <li>
                            <a href=""#"">
                                <div>
                                    <i class=""fa fa-tasks fa-fw""></i> ");
                WriteLiteral(@"New Task
                                    <span class=""pull-right text-muted small"">4 minutes ago</span>
                                </div>
                            </a>
                        </li>
                        <li class=""divider""></li>
                        <li>
                            <a href=""#"">
                                <div>
                                    <i class=""fa fa-upload fa-fw""></i> Server Rebooted
                                    <span class=""pull-right text-muted small"">4 minutes ago</span>
                                </div>
                            </a>
                        </li>
                        <li class=""divider""></li>
                        <li>
                            <a class=""text-center"" href=""#"">
                                <strong>See All Alerts</strong>
                                <i class=""fa fa-angle-right""></i>
                            </a>
                        </li>
              ");
                WriteLiteral(@"      </ul>
                    <!-- /.dropdown-alerts -->
                </li>
                <!-- /.dropdown -->
                <li class=""dropdown"">
                    <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                        <i class=""fa fa-user fa-fw""></i> <i class=""fa fa-caret-down""></i>
                    </a>
                    <ul class=""dropdown-menu dropdown-user"">
                        <li>
                            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 12670, "\"", 12724, 1);
#line 253 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 12677, Url.Action("Index", "Home", new { area = "" }), 12677, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(12725, 1175, true);
                WriteLiteral(@"><i class=""fa fa-sign-out fa-fw""></i> Quay lại trang chủ</a>
                        </li>
                    </ul>
                    <!-- /.dropdown-user -->
                </li>
                <!-- /.dropdown -->
            </ul>
            <!-- /.navbar-top-links -->

            <div class=""navbar-default sidebar"" role=""navigation"">
                <div class=""sidebar-nav navbar-collapse"">
                    <ul class=""nav"" id=""side-menu"">
                        <li class=""sidebar-search"">
                            <div class=""input-group custom-search-form"">
                                <input type=""text"" class=""form-control"" placeholder=""Search..."">
                                <span class=""input-group-btn"">
                                    <button class=""btn btn-default"" type=""button"">
                                        <i class=""fa fa-search""></i>
                                    </button>
                                </span>
                         ");
                WriteLiteral("   </div>\r\n                            <!-- /input-group -->\r\n                        </li>\r\n                        <li>\r\n                            ");
                EndContext();
                BeginContext(13901, 55, false);
#line 277 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\Shared\_Layout.cshtml"
                       Write(Html.ActionLink("Tổng quan", "IndexAdmin", "AdminHome"));

#line default
#line hidden
                EndContext();
                BeginContext(13956, 330, true);
                WriteLiteral(@"
                        </li>

                        <li>
                            <a href=""#""><i class="" fa fa-table fa-fw""></i> Quản lí thông tin<span class=""fa arrow""></span></a>
                            <ul class=""nav nav-second-level"">
                                <li>
                                    ");
                EndContext();
                BeginContext(14287, 49, false);
#line 284 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\Shared\_Layout.cshtml"
                               Write(Html.ActionLink("Tài khoản", "Index", "TaiKhoan"));

#line default
#line hidden
                EndContext();
                BeginContext(14336, 115, true);
                WriteLiteral("\r\n                                </li>\r\n                                <li>\r\n                                    ");
                EndContext();
                BeginContext(14452, 47, false);
#line 287 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\Shared\_Layout.cshtml"
                               Write(Html.ActionLink("Sản phẩm", "Index", "SanPham"));

#line default
#line hidden
                EndContext();
                BeginContext(14499, 115, true);
                WriteLiteral("\r\n                                </li>\r\n                                <li>\r\n                                    ");
                EndContext();
                BeginContext(14615, 47, false);
#line 290 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\Shared\_Layout.cshtml"
                               Write(Html.ActionLink("Đơn hàng", "Index", "DonHang"));

#line default
#line hidden
                EndContext();
                BeginContext(14662, 115, true);
                WriteLiteral("\r\n                                </li>\r\n                                <li>\r\n                                    ");
                EndContext();
                BeginContext(14778, 51, false);
#line 293 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\Shared\_Layout.cshtml"
                               Write(Html.ActionLink("Phiếu nhập", "Index", "PhieuNhap"));

#line default
#line hidden
                EndContext();
                BeginContext(14829, 115, true);
                WriteLiteral("\r\n                                </li>\r\n                                <li>\r\n                                    ");
                EndContext();
                BeginContext(14945, 54, false);
#line 296 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\Shared\_Layout.cshtml"
                               Write(Html.ActionLink("Nhà cung cấp", "Index", "NhaCungCap"));

#line default
#line hidden
                EndContext();
                BeginContext(14999, 401, true);
                WriteLiteral(@"
                                </li>
                            </ul>
                        </li>
                        <li>
                            <a href=""#""><i class=""fa fa-bar-chart-o fa-fw""></i> Thống kê <span class=""fa arrow""></span></a>
                            <ul class=""nav nav-second-level"">
                                <li>
                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 15400, "\"", 15447, 1);
#line 304 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 15407, Url.Action("thongkedoanhthu","ThongKe"), 15407, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(15448, 131, true);
                WriteLiteral(">Doanh thu</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 15579, "\"", 15625, 1);
#line 307 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 15586, Url.Action("thongkesanpham","ThongKe"), 15586, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(15626, 410, true);
                WriteLiteral(@">Sản phẩm bán chạy</a>
                                </li>
                            </ul>
                            <!-- /.nav-second-level -->
                        </li>

                    </ul>
                </div>
                <!-- /.sidebar-collapse -->
            </div>
            <!-- /.navbar-static-side -->
        </nav>

        <div id=""page-wrapper"">
            ");
                EndContext();
                BeginContext(16037, 12, false);
#line 321 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(16049, 26, true);
                WriteLiteral("\r\n        </div>\r\n        ");
                EndContext();
                BeginContext(16076, 41, false);
#line 323 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Areas\Admin\Views\Shared\_Layout.cshtml"
   Write(RenderSection("scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(16117, 717, true);
                WriteLiteral(@"
        <!-- /#page-wrapper -->

    </div>
    <!-- /#wrapper -->
    <!-- jQuery -->
    <script src=""/admin/vendor/jquery/jquery.min.js""></script>

    <!-- Bootstrap Core JavaScript -->
    <script src=""/admin/vendor/bootstrap/js/bootstrap.min.js""></script>

    <!-- Metis Menu Plugin JavaScript -->
    <script src=""/admin/vendor/metisMenu/metisMenu.min.js""></script>

    <!-- Morris Charts JavaScript -->
    <script src=""/admin/vendor/raphael/raphael.min.js""></script>
    <script src=""/admin/vendor/morrisjs/morris.min.js""></script>
    <script src=""/admin/data/morris-data.js""></script>

    <!-- Custom Theme JavaScript -->
    <script src=""/admin/dist/js/sb-admin-2.js""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(16841, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
