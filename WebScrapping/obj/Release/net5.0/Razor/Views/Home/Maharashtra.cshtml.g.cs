#pragma checksum "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2399442de6dc66cb9334180c23a88453c50bfd24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Maharashtra), @"mvc.1.0.view", @"/Views/Home/Maharashtra.cshtml")]
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
#nullable restore
#line 1 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\_ViewImports.cshtml"
using WebScrapping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\_ViewImports.cshtml"
using WebScrapping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2399442de6dc66cb9334180c23a88453c50bfd24", @"/Views/Home/Maharashtra.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d9796580a9959b14bcd2cb2bad1919ac1db02d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Maharashtra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Maharashtra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
  
    ViewData["Title"] = "Maharashtra";
    var abc = ViewBag.TenderTdOdd;
    var def = ViewBag.TenderTdEven;
    var linkOdd = ViewBag.TenderaOdd;
    var linkEven = ViewBag.TenderaEven;
    int k = 0;
    int l = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List of Tendends & Corrigendum</h1>\r\n\r\n<div class=\"pagetitle\">\r\n    <h1>Maharashtra</h1>\r\n    <nav>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2399442de6dc66cb9334180c23a88453c50bfd244281", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
            <li class=""breadcrumb-item active"">Maharashtra</li>
        </ol>
    </nav>
</div><!-- End Page Title -->

<section class=""section"">
    <div class=""row"">
        <div class=""col-lg-12"">

            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Tenders for Maharashtra</h5>
                    <p></p>

                    <!-- Table with stripped rows -->
                    <table class=""table datatable"">
                        <thead>
                            <tr>
                                <th scope=""col"">#</th>
                                <th scope=""col"">Title</th>
                                <th scope=""col"">Reference No</th>
                                <th scope=""col"">Closing Date</th>
                                <th scope=""col"">Bid Opening Date</th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 45 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                             for (int i = 0; i < ViewBag.TenderOdd.Count; i++)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 49 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                                               Write(Convert.ToInt32(i + 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                                     for (int j = 0; j < 4; j++, k++)
                                    {

                                        if (j == 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2204, "\"", 2222, 1);
#nullable restore
#line 60 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
WriteAttributeValue("", 2211, linkOdd[i], 2211, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 60 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                                                                                 Write(abc[k].InnerText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n");
#nullable restore
#line 61 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>");
#nullable restore
#line 64 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                                           Write(abc[k].InnerText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 65 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 69 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                             for (int i = 0; i < ViewBag.TenderEven.Count; i++)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 74 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                                               Write(Convert.ToInt32(i + 1 + ViewBag.TenderOdd.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 80 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                                     for (int j = 0; j < 4; j++, l++)
                                    {

                                        if (j == 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td><a");
            BeginWriteAttribute("href", " href=\"", 3471, "\"", 3490, 1);
#nullable restore
#line 85 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
WriteAttributeValue("", 3478, linkEven[i], 3478, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 85 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                                                                                  Write(def[l].InnerText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n");
#nullable restore
#line 86 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>");
#nullable restore
#line 89 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                                           Write(def[l].InnerText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 90 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                                        }


                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 96 "C:\Users\SandhiS\Desktop\WebScrapping\WebScrapping\Views\Home\Maharashtra.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
