#pragma checksum "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\WebhooksList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5fb50d14d3ea9d85d8c8dd7c9ea04be88e1dabc7906b7a48b5a80a1c1d3b569b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebhookClient.Pages.Pages_WebhooksList), @"mvc.1.0.razor-page", @"/Pages/WebhooksList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5fb50d14d3ea9d85d8c8dd7c9ea04be88e1dabc7906b7a48b5a80a1c1d3b569b", @"/Pages/WebhooksList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5d33b745c7df386adaa239950f441e421e608cbc98c1a3b1c7a5ca1b06ffd503", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_WebhooksList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\WebhooksList.cshtml"
  
    ViewData["Title"] = "WebhooksList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>List of Webhooks registered by user ");
#nullable restore
#line (7,42)-(7,60) 6 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\WebhooksList.cshtml"
Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<table class=\"table\">\n    <thead class=\"thead-light\">\n        <tr>\n            <th scope=\"col\">Date</th>\n            <th scope=\"col\">Destination Url</th>\n            <th scope=\"col\">Validation token</th>\n        </tr>\n    </thead>\n\n");
#nullable restore
#line 18 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\WebhooksList.cshtml"
     foreach (var whr in Model.Webhooks)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line (21,18)-(21,26) 6 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\WebhooksList.cshtml"
Write(whr.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line (22,18)-(22,29) 6 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\WebhooksList.cshtml"
Write(whr.DestUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line (23,18)-(23,27) 6 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\WebhooksList.cshtml"
Write(whr.Token);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 25 "C:\Users\roberto.mencia\Downloads\eShopOnContainers-main\eShopOnContainers-main\src\Web\WebhookClient\Pages\WebhooksList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebhookClient.Pages.WebhooksListModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebhookClient.Pages.WebhooksListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebhookClient.Pages.WebhooksListModel>)PageContext?.ViewData;
        public WebhookClient.Pages.WebhooksListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
