#pragma checksum "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_LoaiHang\MH_XoaLoaiHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbb71d12a0d17bf800f2477f0498573a26e483cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuanLyCuaHang_21880159.Pages.MH_LoaiHang.Pages_MH_LoaiHang_MH_XoaLoaiHang), @"mvc.1.0.razor-page", @"/Pages/MH_LoaiHang/MH_XoaLoaiHang.cshtml")]
namespace QuanLyCuaHang_21880159.Pages.MH_LoaiHang
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\_ViewImports.cshtml"
using QuanLyCuaHang_21880159;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb71d12a0d17bf800f2477f0498573a26e483cd", @"/Pages/MH_LoaiHang/MH_XoaLoaiHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50f5cb9ad2c6abe0325b08f92dbad601c6c3ba01", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_LoaiHang_MH_XoaLoaiHang : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 5 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_LoaiHang\MH_XoaLoaiHang.cshtml"
 if (Model.CoLoaiHang)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbb71d12a0d17bf800f2477f0498573a26e483cd3628", async() => {
                WriteLiteral("\r\n        <div>Bạn có muốn xóa loại hàng ");
#nullable restore
#line 8 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_LoaiHang\MH_XoaLoaiHang.cshtml"
                                  Write(Model.LoaiHang.TenLoaiHang);

#line default
#line hidden
#nullable disable
                WriteLiteral(" không?</div><br />\r\n        <input type=\"submit\" value=\"Xóa\" /><br /><br />\r\n        <a href=\"MH_TimKiemLoaiHang\">Quay lại trang tìm kiếm</a>\r\n    ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 12 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_LoaiHang\MH_XoaLoaiHang.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_LoaiHang\MH_XoaLoaiHang.cshtml"
Write(Model.Chuoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"MH_TimKiemLoaiHang\">Quay lại trang tìm kiếm</a>\r\n");
#nullable restore
#line 17 "D:\HUS\KyThuatLapTrinh\Demo\Demo2\Demo2\Pages\MH_LoaiHang\MH_XoaLoaiHang.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyCuaHang_21880159.Pages.MH_LoaiHang.MH_XoaLoaiHangModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang_21880159.Pages.MH_LoaiHang.MH_XoaLoaiHangModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang_21880159.Pages.MH_LoaiHang.MH_XoaLoaiHangModel>)PageContext?.ViewData;
        public QuanLyCuaHang_21880159.Pages.MH_LoaiHang.MH_XoaLoaiHangModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
