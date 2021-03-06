#pragma checksum "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d85c7fe5868d467d6b4832940859c13e1068454"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patron_Detail), @"mvc.1.0.view", @"/Views/Patron/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patron/Detail.cshtml", typeof(AspNetCore.Views_Patron_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d85c7fe5868d467d6b4832940859c13e1068454", @"/Views/Patron/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9808b66272054d1e10f4c596c3d68bb1fdf2a1bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Patron_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryManagement.Models.Patron.PatronDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
  
    ViewBag.Title = @Model.LastName + ", " + @Model.FirstName;

#line default
#line hidden
            BeginContext(129, 283, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Patron Information</h2>
    </div>
    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div>
                    <h2>");
            EndContext();
            BeginContext(413, 15, false);
#line 14 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(428, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(430, 14, false);
#line 14 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                                    Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(444, 117, true);
            WriteLiteral("</h2>\r\n                    <div class=\"patronContact\">\r\n                        <div id=\"patronTel\">Library Card ID: ");
            EndContext();
            BeginContext(562, 19, false);
#line 16 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                                                        Write(Model.LibraryCardId);

#line default
#line hidden
            EndContext();
            BeginContext(581, 65, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronAddress\">Address: ");
            EndContext();
            BeginContext(647, 13, false);
#line 17 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                                                    Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(660, 59, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronTel\">Phone: ");
            EndContext();
            BeginContext(720, 11, false);
#line 18 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                                              Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(731, 67, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronDate\">Member Since: ");
            EndContext();
            BeginContext(799, 17, false);
#line 19 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                                                      Write(Model.MemberSince);

#line default
#line hidden
            EndContext();
            BeginContext(816, 70, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronLibrary\">Home Library: ");
            EndContext();
            BeginContext(887, 23, false);
#line 20 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                                                         Write(Model.HomeLibraryBranch);

#line default
#line hidden
            EndContext();
            BeginContext(910, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 21 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                         if (@Model.OverDueFees > 0)
                        {

#line default
#line hidden
            BeginContext(999, 71, true);
            WriteLiteral("                            <div id=\"patronHasFees\">Current Fees Due: $");
            EndContext();
            BeginContext(1071, 17, false);
#line 23 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                                                                  Write(Model.OverDueFees);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 24 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1180, 81, true);
            WriteLiteral("                            <div id=\"patronNoFees\">No Fees Currently Due.</div>\r\n");
            EndContext();
#line 28 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"

                        }

#line default
#line hidden
            BeginContext(1290, 163, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently Checked Out</h4>\r\n");
            EndContext();
#line 35 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                 if (@Model.AssetsCheckedOut.Any())
                {

#line default
#line hidden
            BeginContext(1525, 75, true);
            WriteLiteral("                    <div id=\"patronAssets\">\r\n                        <ul>\r\n");
            EndContext();
#line 39 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                             foreach (var checkout in @Model.AssetsCheckedOut)
                            {

#line default
#line hidden
            BeginContext(1711, 74, true);
            WriteLiteral("                                <li>\r\n                                    ");
            EndContext();
            BeginContext(1786, 27, false);
#line 42 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                               Write(checkout.LibraryAsset.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1813, 22, true);
            WriteLiteral(" - (Library Asset ID: ");
            EndContext();
            BeginContext(1836, 24, false);
#line 42 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                                                                                 Write(checkout.LibraryAsset.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1860, 142, true);
            WriteLiteral(")\r\n                                    <ul>\r\n                                        <li>\r\n                                            Since: ");
            EndContext();
            BeginContext(2003, 14, false);
#line 45 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                                              Write(checkout.Since);

#line default
#line hidden
            EndContext();
            BeginContext(2017, 144, true);
            WriteLiteral("\r\n                                        </li>\r\n                                        <li>\r\n                                            Due: ");
            EndContext();
            BeginContext(2162, 14, false);
#line 48 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                                            Write(checkout.Until);

#line default
#line hidden
            EndContext();
            BeginContext(2176, 131, true);
            WriteLiteral("\r\n                                        </li>\r\n                                    </ul>\r\n                                </li>\r\n");
            EndContext();
#line 52 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(2338, 59, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
            EndContext();
#line 55 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2457, 64, true);
            WriteLiteral("                    <div>No items currently checked out.</div>\r\n");
            EndContext();
#line 59 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"

                }

#line default
#line hidden
            BeginContext(2542, 109, true);
            WriteLiteral("            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently On Hold</h4>\r\n");
            EndContext();
#line 65 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                 if (@Model.Holds.Any())
                {

#line default
#line hidden
            BeginContext(2712, 74, true);
            WriteLiteral("                    <div id=\"patronHolds\">\r\n                        <ul>\r\n");
            EndContext();
#line 69 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                             foreach (var hold in @Model.Holds)
                            {

#line default
#line hidden
            BeginContext(2882, 36, true);
            WriteLiteral("                                <li>");
            EndContext();
            BeginContext(2919, 23, false);
#line 71 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                               Write(hold.LibraryAsset.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2942, 10, true);
            WriteLiteral(" - Placed ");
            EndContext();
            BeginContext(2953, 44, false);
#line 71 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                                                                 Write(hold.HoldPlaced.ToString("yy-dd-MM - HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(2997, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 72 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(3035, 59, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
            EndContext();
#line 75 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3154, 50, true);
            WriteLiteral("                    <div>No items on hold.</div>\r\n");
            EndContext();
#line 79 "G:\my_projects\Web-Apps\AspNetCore_Projects\Library-Management\Library-Management\Views\Patron\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(3223, 54, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryManagement.Models.Patron.PatronDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
