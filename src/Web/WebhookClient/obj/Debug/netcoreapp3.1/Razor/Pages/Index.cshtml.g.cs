#pragma checksum "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8dc7c25967497a72bda9936a7b2b408a236fdf246155cbabe6b228578effc1be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebhookClient.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WebhookClient.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\_ViewImports.cshtml"
using WebhookClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8dc7c25967497a72bda9936a7b2b408a236fdf246155cbabe6b228578effc1be", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5d33b745c7df386adaa239950f441e421e608cbc98c1a3b1c7a5ca1b06ffd503", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("esh-app-footer-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/brand.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "RegisterWebhook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"esh-catalog-hero\">\n</section>\n\n<div class=\"text-center\">\n    <p>&nbsp;</p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8dc7c25967497a72bda9936a7b2b408a236fdf246155cbabe6b228578effc1be4667", async() => {
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
            WriteLiteral(@"
    <h2>eShopOnContainers - Order Management</h2>
    <p>
        This is a <bold>sample</bold> web client that uses the Webhooks API to show you all orders that reached the ""paid"" status. This is accomplished by creating a Webhook
        that will be called by eShopOnContainers core when the order reached this ""paid"" status. If not created you can create this webhook going to ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dc7c25967497a72bda9936a7b2b408a236fdf246155cbabe6b228578effc1be6187", async() => {
                WriteLiteral("webhook registration");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(".\n    </p>\n");
#nullable restore
#line 18 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\Index.cshtml"
     if (!User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"btn-primary btn\"");
            BeginWriteAttribute("href", " href=\"", 751, "\"", 790, 1);
#nullable restore
#line (20,42)-(20,74) 29 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\Index.cshtml"
WriteAttributeValue("", 758, Url.Action("SignIn", "Account"), 758, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Login</a>\n        <p>Why I need to login? You only need to login <bold>to setup a new webhook</bold>.</p>\n");
#nullable restore
#line 22 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<div class=\"table\">\n    <h3>Current webhooks received (orders paid)</h3>\n    <p>(Data since last time web started up). <strong>Note: </strong>Must manually refresh this page.<p>\n    <table class=\"table\">\n");
#nullable restore
#line 29 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\Index.cshtml"
         foreach (var webhook in Model.WebHooksReceived)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line (32,22)-(32,34) 6 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\Index.cshtml"
Write(webhook.When);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><pre>");
#nullable restore
#line (33,27)-(33,39) 6 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\Index.cshtml"
Write(webhook.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre></td>\n                <td>");
#nullable restore
#line (34,23)-(34,50) 6 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\Index.cshtml"
Write(webhook.Token ?? "--None--");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 36 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n</div>\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591