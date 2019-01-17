#pragma checksum "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "709552083662212268b28dd5ec785a9b1ffba81d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patron_Index), @"mvc.1.0.view", @"/Views/Patron/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patron/Index.cshtml", typeof(AspNetCore.Views_Patron_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709552083662212268b28dd5ec785a9b1ffba81d", @"/Views/Patron/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9808b66272054d1e10f4c596c3d68bb1fdf2a1bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Patron_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryManagement.Models.Patron.PatronIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Patron", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Index.cshtml"
  
    ViewBag.Title = "Patron Index";

#line default
#line hidden
            BeginContext(103, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(110, 13, false);
#line 7 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(123, 485, true);
            WriteLiteral(@"</h3>

<div id=""patronIndex"">
    <table class=""mdl-data-table mdl-js-data-table mdl-data-table--selectable mdl-shadow--2dp customTable"" id=""patronIndexTable"">
        <thead>
            <tr>
                <th>Profile Link</th>
                <th>Last Name</th>
                <th>First Name</th>
                <th>Library Card Id</th>
                <th>Overdue Fees</th>
                <th>Home Library</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Index.cshtml"
             foreach (var patron in Model.Patrons)
            {

#line default
#line hidden
            BeginContext(675, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(735, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b70d6c64a5e64c068e5413f8f230118c", async() => {
                BeginContext(814, 9, true);
                WriteLiteral("(Profile)");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-patronId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Index.cshtml"
                                                                           WriteLiteral(patron.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["patronId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-patronId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["patronId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(827, 46, true);
            WriteLiteral("\r\n                </td>\r\n                <td> ");
            EndContext();
            BeginContext(874, 15, false);
#line 28 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Index.cshtml"
                Write(patron.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(889, 29, true);
            WriteLiteral(" </td>\r\n                <td> ");
            EndContext();
            BeginContext(919, 16, false);
#line 29 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Index.cshtml"
                Write(patron.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(935, 29, true);
            WriteLiteral(" </td>\r\n                <td> ");
            EndContext();
            BeginContext(965, 20, false);
#line 30 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Index.cshtml"
                Write(patron.LibraryCardId);

#line default
#line hidden
            EndContext();
            BeginContext(985, 29, true);
            WriteLiteral(" </td>\r\n                <td> ");
            EndContext();
            BeginContext(1015, 18, false);
#line 31 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Index.cshtml"
                Write(patron.OverDueFees);

#line default
#line hidden
            EndContext();
            BeginContext(1033, 29, true);
            WriteLiteral(" </td>\r\n                <td> ");
            EndContext();
            BeginContext(1063, 24, false);
#line 32 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Index.cshtml"
                Write(patron.HomeLibraryBranch);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 27, true);
            WriteLiteral(" </td>\r\n            </tr>\r\n");
            EndContext();
#line 34 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1129, 41, true);
            WriteLiteral("\r\n        </tbody> \r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryManagement.Models.Patron.PatronIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
