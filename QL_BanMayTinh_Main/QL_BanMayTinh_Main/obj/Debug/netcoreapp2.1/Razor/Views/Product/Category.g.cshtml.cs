#pragma checksum "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d001f447f4eb8b056a711e134aa2cd06b80252de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Category), @"mvc.1.0.view", @"/Views/Product/Category.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Category.cshtml", typeof(AspNetCore.Views_Product_Category))]
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
#line 1 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\_ViewImports.cshtml"
using QL_BanMayTinh_Main;

#line default
#line hidden
#line 2 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\_ViewImports.cshtml"
using QL_BanMayTinh_Main.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d001f447f4eb8b056a711e134aa2cd06b80252de", @"/Views/Product/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"589d94f8231c61858541f99d6d268afc1023797c", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QL_BanMayTinh_Main.Models.SearchModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
  
    ViewData["Title"] = "Category";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("jsFooter", async() => {
                BeginContext(155, 61, true);
                WriteLiteral("\r\n    <script src=\"/js/controller/Themgiohang.js\"></script>\r\n");
                EndContext();
            }
            );
            BeginContext(219, 206, true);
            WriteLiteral("\r\n<!-- page -->\r\n<div class=\"services-breadcrumb\">\r\n    <div class=\"agile_inner_breadcrumb\">\r\n        <div class=\"container\">\r\n            <ul class=\"w3_short\">\r\n                <li>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 425, "\"", 460, 1);
#line 16 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
WriteAttributeValue("", 432, Url.Action("Index", "Home"), 432, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(461, 89, true);
            WriteLiteral(">Trang chủ</a>\r\n                    <i>|</i>\r\n                </li>\r\n                <li>");
            EndContext();
            BeginContext(551, 15, false);
#line 19 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
               Write(ViewBag.Keyword);

#line default
#line hidden
            EndContext();
            BeginContext(566, 301, true);
            WriteLiteral(@"</li>
            </ul>
        </div>
    </div>
</div>
<!-- //page -->
<!-- top Products -->
<div class=""ads-grid py-sm-5 py-4"">
    <div class=""container py-xl-4 py-lg-2"">
        <!-- tittle heading -->
        <h3 class=""tittle-w3l text-center mb-lg-5 mb-sm-4 mb-3"">
            <span>");
            EndContext();
            BeginContext(868, 15, false);
#line 30 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
             Write(ViewBag.Keyword);

#line default
#line hidden
            EndContext();
            BeginContext(883, 393, true);
            WriteLiteral(@"</span>
        </h3>
        <!-- //tittle heading -->
        <div class=""row"">
            <!-- product left -->
            <div class=""agileinfo-ads-display col-lg-9"">
                <div class=""wrapper"">
                    <!-- first section -->
                    <div class=""product-sec1 px-sm-4 px-3 py-sm-5  py-3 mb-4"">
                        <h2 class=""heading-tittle"">");
            EndContext();
            BeginContext(1277, 16, false);
#line 39 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
                                              Write(ViewBag.ThongBao);

#line default
#line hidden
            EndContext();
            BeginContext(1293, 50, true);
            WriteLiteral("</h2>\r\n                        <div class=\"row\">\r\n");
            EndContext();
#line 41 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
                             foreach (var sanpham in Model.SearchResult)
                            {

#line default
#line hidden
            BeginContext(1448, 288, true);
            WriteLiteral(@"                                <div class=""col-md-4 product-men mt-5"">
                                    <div class=""men-pro-item simpleCart_shelfItem"">
                                        <div class=""men-thumb-item text-center"">
                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1736, "\"", 1763, 1);
#line 46 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
WriteAttributeValue("", 1742, sanpham.Hinhanhindex, 1742, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1764, 218, true);
            WriteLiteral(" alt=\"\">\r\n                                            <div class=\"men-cart-pro\">\r\n                                                <div class=\"inner-men-cart-pro\">\r\n                                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1982, "\"", 2047, 1);
#line 49 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
WriteAttributeValue("", 1989, Url.Action("Details","Product",new { id = sanpham.MaSp }), 1989, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2048, 415, true);
            WriteLiteral(@" class=""link-product-add-cart"">Chi tiết</a>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""item-info-product text-center border-top mt-4"">
                                            <h4 class=""pt-1"">
                                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2463, "\"", 2528, 1);
#line 55 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
WriteAttributeValue("", 2470, Url.Action("Details","Product",new { id = sanpham.MaSp }), 2470, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2529, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2531, 13, false);
#line 55 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
                                                                                                                Write(sanpham.TenSp);

#line default
#line hidden
            EndContext();
            BeginContext(2544, 213, true);
            WriteLiteral("</a>\r\n                                            </h4>\r\n                                            <div class=\"info-product-price my-2\">\r\n                                                <span class=\"item_price\">");
            EndContext();
            BeginContext(2758, 34, false);
#line 58 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
                                                                    Write(sanpham.GiaBanLe.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(2792, 249, true);
            WriteLiteral(" VNĐ</span>\r\n                                            </div>\r\n                                            <div class=\"snipcart-details top_brand_home_details item_add single-item hvr-outline-out\">\r\n                                                ");
            EndContext();
            BeginContext(3041, 359, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a661140f7c643e09f8c7644078ebf32", async() => {
                BeginContext(3061, 142, true);
                WriteLiteral("\r\n                                                    <fieldset>\r\n                                                        <input type=\"button\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3203, "\"", 3234, 3);
                WriteAttributeValue("", 3213, "them(\'", 3213, 6, true);
#line 63 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
WriteAttributeValue("", 3219, sanpham.MaSp, 3219, 13, false);

#line default
#line hidden
                WriteAttributeValue("", 3232, "\')", 3232, 2, true);
                EndWriteAttribute();
                BeginContext(3235, 158, true);
                WriteLiteral(" value=\"Thêm vào giỏ\" class=\"button btn\" />\r\n                                                    </fieldset>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3400, 186, true);
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 70 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
                            }

#line default
#line hidden
            BeginContext(3617, 495, true);
            WriteLiteral(@"                        </div>
                    </div>
                    <!-- //first section -->

                </div>
            </div>
            <!-- //product left -->
            <!-- product right -->
            <div class=""col-lg-3 mt-lg-0 mt-4 p-lg-0"">
                <div class=""side-bar p-sm-4 p-3"">
                    <div class=""search-hotel border-bottom py-2"">
                        <h3 class=""agileits-sear-head mb-3"">Tìm..</h3>
                        ");
            EndContext();
            BeginContext(4112, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cfca42a39994eb880518320e71ec4aa", async() => {
                BeginContext(4173, 195, true);
                WriteLiteral("\r\n                            <input type=\"search\" placeholder=\"Tên sản phẩm...\" name=\"keyword\" required=\"\">\r\n                            <input type=\"submit\" value=\" \">\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 83 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
AddHtmlAttributeValue("", 4126, Url.Action("Search", "Product"), 4126, 32, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4375, 52, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                    ");
            EndContext();
            BeginContext(4427, 1795, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53ffdc15187d41a0bcdd39cf28f602cf", async() => {
                BeginContext(4458, 223, true);
                WriteLiteral("\r\n                        <!-- price -->\r\n                        <div class=\"left-side border-bottom py-2\">\r\n                            <h3 class=\"agileits-sear-head mb-3\">Giá tiền</h3>\r\n                            <ul>\r\n");
                EndContext();
#line 94 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
                                 foreach (var price in Model.filter.PriceList)
                                {

#line default
#line hidden
                BeginContext(4796, 131, true);
                WriteLiteral("                                    <li>\r\n                                        <input type=\"checkbox\" class=\"checked\" name=\"gia\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4927, "\"", 4946, 1);
#line 97 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
WriteAttributeValue("", 4932, price.PriceID, 4932, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=\"", 4947, "\"", 4973, 1);
#line 97 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
WriteAttributeValue("", 4957, price.IsChecked, 4957, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 4974, "\"", 4999, 1);
#line 97 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
WriteAttributeValue("", 4982, price.PriceValue, 4982, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5000, 94, true);
                WriteLiteral(" onclick=\"this.form.submit();\" />\r\n                                        <span class=\"span\">");
                EndContext();
                BeginContext(5095, 15, false);
#line 98 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
                                                      Write(price.PriceName);

#line default
#line hidden
                EndContext();
                BeginContext(5110, 52, true);
                WriteLiteral("</span>\r\n                                    </li>\r\n");
                EndContext();
#line 100 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
                                }

#line default
#line hidden
                BeginContext(5197, 339, true);
                WriteLiteral(@"                            </ul>
                        </div>
                        <!-- //price -->
                        <!-- electronics -->
                        <div class=""left-side border-bottom py-2"">
                            <h3 class=""agileits-sear-head mb-3"">Thương hiệu</h3>
                            <ul>
");
                EndContext();
#line 108 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
                                 foreach (var category in Model.filter.CategoryList)
                                {

#line default
#line hidden
                BeginContext(5657, 132, true);
                WriteLiteral("                                    <li>\r\n                                        <input type=\"checkbox\" class=\"checked\" name=\"loai\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 5789, "\"", 5814, 1);
#line 111 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
WriteAttributeValue("", 5794, category.CategoryID, 5794, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=\"", 5815, "\"", 5844, 1);
#line 111 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
WriteAttributeValue("", 5825, category.IsChecked, 5825, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 5845, "\"", 5876, 1);
#line 111 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
WriteAttributeValue("", 5853, category.CategoryValue, 5853, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5877, 94, true);
                WriteLiteral(" onclick=\"this.form.submit();\" />\r\n                                        <span class=\"span\">");
                EndContext();
                BeginContext(5972, 21, false);
#line 112 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
                                                      Write(category.CategoryName);

#line default
#line hidden
                EndContext();
                BeginContext(5993, 52, true);
                WriteLiteral("</span>\r\n                                    </li>\r\n");
                EndContext();
#line 114 "D:\Documents\4th Year\1st Semester\Open-sourced Apps\Project\QL_BanMayTinh\QL_BanMayTinh_Main\QL_BanMayTinh_Main\Views\Product\Category.cshtml"
                                }

#line default
#line hidden
                BeginContext(6080, 135, true);
                WriteLiteral("                            </ul>\r\n                        </div>\r\n                        <!-- //electronics -->\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6222, 169, true);
            WriteLiteral("\r\n                    \r\n                </div>\r\n                <!-- //product right -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- //top products -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QL_BanMayTinh_Main.Models.SearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
