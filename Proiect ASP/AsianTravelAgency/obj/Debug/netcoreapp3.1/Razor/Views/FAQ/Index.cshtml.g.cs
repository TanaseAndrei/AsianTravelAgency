#pragma checksum "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\FAQ\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d6d257cdc0c673b4585961a7c0c7da9ffe6e9a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FAQ_Index), @"mvc.1.0.view", @"/Views/FAQ/Index.cshtml")]
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
#line 1 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\_ViewImports.cshtml"
using AsianTravelAgency;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\_ViewImports.cshtml"
using AsianTravelAgency.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d6d257cdc0c673b4585961a7c0c7da9ffe6e9a4", @"/Views/FAQ/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b9e122f331c7e964ddc811885055a6ed5f813f", @"/Views/_ViewImports.cshtml")]
    public class Views_FAQ_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AsianTravelAgency.Models.ViewModels.FAQViewModel.DisplayAllFAQViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Freepik-question.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid floating-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFAQ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\FAQ\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container container-banner"">
    <div class=""row banner"">
        <div class=""col-md-6"">
            <h1>Got questions? No problem!</h1>
            <p>
                Here are some of the frequently asked questions. If you do not feel that one of these
                questions responds to one of your, feel free to contact us!
            </p>
            <a href=""pictures.html"" class=""express-btn"">SEE PICTURES</a>
            <a href=""#review"" class=""express-btn2"">SEE REVIEWS</a>
        </div>
        <div class=""col-md-6 city-picture"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7d6d257cdc0c673b4585961a7c0c7da9ffe6e9a45812", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d6d257cdc0c673b4585961a7c0c7da9ffe6e9a47036", async() => {
                WriteLiteral("\r\n            <input type=\"button\" value=\"+\" class=\"btn btn-outline-secondary spacing filter\" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 32 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\FAQ\Index.cshtml"
 if (Model.FAQs.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            No questions\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 39 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\FAQ\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container container-style\">\r\n        <div class=\"wrapper\">\r\n");
#nullable restore
#line 45 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\FAQ\Index.cshtml"
             for(int iterator = 0; iterator < Model.FAQs.Count(); iterator++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"wrapper-item\"");
            BeginWriteAttribute("id", " id=\"", 1400, "\"", 1424, 2);
            WriteAttributeValue("", 1405, "question", 1405, 8, true);
#nullable restore
#line 47 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\FAQ\Index.cshtml"
WriteAttributeValue("", 1413, iterator, 1413, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a class=\"wrapper-link\"");
            BeginWriteAttribute("href", " href=\"", 1467, "\"", 1494, 2);
            WriteAttributeValue("", 1474, "#question", 1474, 9, true);
#nullable restore
#line 48 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\FAQ\Index.cshtml"
WriteAttributeValue("", 1483, iterator, 1483, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h3>");
#nullable restore
#line 49 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\FAQ\Index.cshtml"
                   Write(Html.DisplayFor(item => Model.FAQs.ElementAt(iterator).Question));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <ion-icon class=""ion-md-add"" name=""add-outline""></ion-icon>
                    <ion-icon class=""ion-md-remove"" name=""remove-outline""></ion-icon>
                </a>
                <div class=""answer"">
                    <p>");
#nullable restore
#line 54 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\FAQ\Index.cshtml"
                  Write(Html.DisplayFor(item => Model.FAQs.ElementAt(iterator).Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d6d257cdc0c673b4585961a7c0c7da9ffe6e9a411198", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\FAQ\Index.cshtml"
                                       WriteLiteral(Model.FAQs.ElementAt(iterator).Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d6d257cdc0c673b4585961a7c0c7da9ffe6e9a413400", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\FAQ\Index.cshtml"
                                         WriteLiteral(Model.FAQs.ElementAt(iterator).Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 59 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\FAQ\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 62 "E:\Programming\PAW proiect\AsiaExpress\Proiect ASP\AsianTravelAgency\Views\FAQ\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AsianTravelAgency.Models.ViewModels.FAQViewModel.DisplayAllFAQViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
