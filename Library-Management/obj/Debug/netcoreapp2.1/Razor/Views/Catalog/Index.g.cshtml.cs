#pragma checksum "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Catalog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cbf0b3b8a70298d16825f690d7e1bfc90eee30f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Index), @"mvc.1.0.view", @"/Views/Catalog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Index.cshtml", typeof(AspNetCore.Views_Catalog_Index))]
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
#line 1 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\_ViewImports.cshtml"
using Library_Management;

#line default
#line hidden
#line 2 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\_ViewImports.cshtml"
using Library_Management.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cbf0b3b8a70298d16825f690d7e1bfc90eee30f", @"/Views/Catalog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9808b66272054d1e10f4c596c3d68bb1fdf2a1bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryManagement.Models.Catalog.AssetIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 438, true);
            WriteLiteral(@"
<div id=""assets"">
    
    <h3>Library Catalog</h3>
    
    <div id=""assetsTable"">
        <table class=""table table-condensed"" id=""catelogIndexTable"">
            <thead>
                <tr>
                    <th>Image</th>
                    <th>Title</th>
                    <th>Author/Director</th>
                    <th>Dewey Call Number</th>
                </tr>
            </thead>

            <tbody>
");
            EndContext();
#line 19 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Catalog\Index.cshtml"
                 foreach(var asset in Model.Assets)
                {

#line default
#line hidden
            BeginContext(567, 110, true);
            WriteLiteral("                    <tr class=\"assetRow\">\r\n                        <td class=\"\">\r\n                            ");
            EndContext();
            BeginContext(677, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d4089f29c10442ab613c69a4381927b", async() => {
                BeginContext(755, 38, true);
                WriteLiteral("\r\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 793, "\"", 814, 1);
#line 24 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Catalog\Index.cshtml"
WriteAttributeValue("", 799, asset.ImageUrl, 799, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(815, 51, true);
                WriteLiteral(" class=\"imageCell\" />\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-assetId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Catalog\Index.cshtml"
                                                                                   WriteLiteral(asset.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["assetId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-assetId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["assetId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(870, 100, true);
            WriteLiteral("\r\n                            \r\n                        </td>\r\n                        <td class=\"\">");
            EndContext();
            BeginContext(971, 11, false);
#line 28 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Catalog\Index.cshtml"
                                Write(asset.Title);

#line default
#line hidden
            EndContext();
            BeginContext(982, 44, true);
            WriteLiteral("</td>\r\n                        <td class=\"\">");
            EndContext();
            BeginContext(1027, 22, false);
#line 29 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Catalog\Index.cshtml"
                                Write(asset.AuthorOrDirector);

#line default
#line hidden
            EndContext();
            BeginContext(1049, 44, true);
            WriteLiteral("</td>\r\n                        <td class=\"\">");
            EndContext();
            BeginContext(1094, 21, false);
#line 30 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Catalog\Index.cshtml"
                                Write(asset.DeweyCallNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1115, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 32 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Catalog\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1168, 72, true);
            WriteLiteral("            </tbody>\r\n            \r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryManagement.Models.Catalog.AssetIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
