#pragma checksum "/home/pearu/Documents/V_SEMESTER/PROGRAMMEERIMINE_CSHARP_KEELES/GIT/LibraryApp/WebApp/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c53b1acb826ac462075cb04228be88fb24e5f9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WebApp.Pages
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
#line 1 "/home/pearu/Documents/V_SEMESTER/PROGRAMMEERIMINE_CSHARP_KEELES/GIT/LibraryApp/WebApp/Pages/_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c53b1acb826ac462075cb04228be88fb24e5f9d", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56255396305d1d1888ad93afc9c47568e44a4220", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("haioo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/pearu/Documents/V_SEMESTER/PROGRAMMEERIMINE_CSHARP_KEELES/GIT/LibraryApp/WebApp/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-2\"></div>\n        <div class=\"col-8\">\n            <div class=\"container\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c53b1acb826ac462075cb04228be88fb24e5f9d3873", async() => {
                WriteLiteral("\n                    <div class=\"row justify-content-start\">\n                        <div class=\"col-auto\">\n\n");
#nullable restore
#line 15 "/home/pearu/Documents/V_SEMESTER/PROGRAMMEERIMINE_CSHARP_KEELES/GIT/LibraryApp/WebApp/Pages/Index.cshtml"
                             for (var i = 0; i < Model.SearchButtons.Count; i++)
                            {
                                var item = Model.SearchButtons[i];

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6c53b1acb826ac462075cb04228be88fb24e5f9d4666", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 18 "/home/pearu/Documents/V_SEMESTER/PROGRAMMEERIMINE_CSHARP_KEELES/GIT/LibraryApp/WebApp/Pages/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchButtons[i].IsChecked);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                <label");
                BeginWriteAttribute("for", "\n                                    for=\"", 649, "\"", 720, 3);
                WriteAttributeValue("", 691, "SearchButtons_", 691, 14, true);
#nullable restore
#line 20 "/home/pearu/Documents/V_SEMESTER/PROGRAMMEERIMINE_CSHARP_KEELES/GIT/LibraryApp/WebApp/Pages/Index.cshtml"
WriteAttributeValue("", 705, i, 705, 4, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 709, "__IsChecked", 709, 11, true);
                EndWriteAttribute();
                BeginWriteAttribute("class", "\n                                    class=\"", 721, "\"", 830, 2);
                WriteAttributeValue("", 765, "toggle-label", 765, 12, true);
#nullable restore
#line 21 "/home/pearu/Documents/V_SEMESTER/PROGRAMMEERIMINE_CSHARP_KEELES/GIT/LibraryApp/WebApp/Pages/Index.cshtml"
WriteAttributeValue(" ", 777, item.IsChecked ? "btn btn-light" : "btn btn-dark", 778, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                    ");
#nullable restore
#line 22 "/home/pearu/Documents/V_SEMESTER/PROGRAMMEERIMINE_CSHARP_KEELES/GIT/LibraryApp/WebApp/Pages/Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </label>\n");
#nullable restore
#line 24 "/home/pearu/Documents/V_SEMESTER/PROGRAMMEERIMINE_CSHARP_KEELES/GIT/LibraryApp/WebApp/Pages/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>

                    </div>
                    <div class=""row justify-content-end"">
                        <div class=""col"">
                            <input type=""text"" class=""form-control "" id=""inlineFormInputName2"" placeholder=""Moby Dick"">
                        </div>
                        <div class=""col-4"">
                            <button type=""submit"" class=""btn btn-primary "">Go fetch!</button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div></div>\n        <div class=\"col-2\"></div></div>\n\n</div>\n\n\n<div class=\"container-fluid\">\n    <div class=\"row justify-content-center\">\n");
#nullable restore
#line 45 "/home/pearu/Documents/V_SEMESTER/PROGRAMMEERIMINE_CSHARP_KEELES/GIT/LibraryApp/WebApp/Pages/Index.cshtml"
         foreach (var item in Model.Books)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card col-sm m-3 p-3\">\n                <img src=\"resources/uzbekistan-forests.jpg\" class=\"card-img-top rounded\" alt=\"...\">\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 50 "/home/pearu/Documents/V_SEMESTER/PROGRAMMEERIMINE_CSHARP_KEELES/GIT/LibraryApp/WebApp/Pages/Index.cshtml"
                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <p class=\"card-text\">");
#nullable restore
#line 51 "/home/pearu/Documents/V_SEMESTER/PROGRAMMEERIMINE_CSHARP_KEELES/GIT/LibraryApp/WebApp/Pages/Index.cshtml"
                                    Write(item.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <a href=\"#\" class=\"btn btn-primary\">Look at this book!</a>\n                </div>\n            </div>\n");
#nullable restore
#line 55 "/home/pearu/Documents/V_SEMESTER/PROGRAMMEERIMINE_CSHARP_KEELES/GIT/LibraryApp/WebApp/Pages/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
