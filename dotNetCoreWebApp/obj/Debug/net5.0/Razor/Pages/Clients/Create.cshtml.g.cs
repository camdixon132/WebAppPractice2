#pragma checksum "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Create.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b0973dd0ce7d49579df78d14a56580828f44259997265393f6fcb590d719a65a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(dotNetCoreWebApp.Pages.Clients.Pages_Clients_Create), @"mvc.1.0.razor-page", @"/Pages/Clients/Create.cshtml")]
namespace dotNetCoreWebApp.Pages.Clients
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
#line 1 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\_ViewImports.cshtml"
using dotNetCoreWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b0973dd0ce7d49579df78d14a56580828f44259997265393f6fcb590d719a65a", @"/Pages/Clients/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7c3e757c8754b018264949bb16353c32705edd26f4430d2feb7eba27ba492d4b", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Clients_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
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
            WriteLiteral("\r\n<br />\r\n<h2>New Client</h2>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Create.cshtml"
 if (Model.errorMessage.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\'alert alert-warning alert-dismissible fade show\' role=\'alert\'>\r\n        <strong>");
#nullable restore
#line 13 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Create.cshtml"
           Write(Model.errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        <button type=\'button\' class=\'btn-close\' data-bs-dismiss=\'alert\' aria-label=\'Close\'></button>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0973dd0ce7d49579df78d14a56580828f44259997265393f6fcb590d719a65a4516", async() => {
                WriteLiteral("\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Name</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 589, "\"", 619, 1);
#nullable restore
#line 21 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Create.cshtml"
WriteAttributeValue("", 597, Model.clientInfo.name, 597, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Email</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 839, "\"", 870, 1);
#nullable restore
#line 27 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Create.cshtml"
WriteAttributeValue("", 847, Model.clientInfo.email, 847, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Phone</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"phone\"");
                BeginWriteAttribute("value", " value=\"", 1090, "\"", 1121, 1);
#nullable restore
#line 33 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Create.cshtml"
WriteAttributeValue("", 1098, Model.clientInfo.phone, 1098, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Address</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"address\"");
                BeginWriteAttribute("value", " value=\"", 1345, "\"", 1378, 1);
#nullable restore
#line 39 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Create.cshtml"
WriteAttributeValue("", 1353, Model.clientInfo.address, 1353, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 43 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Create.cshtml"
     if (Model.successMessage.Length > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\'alert alert-success alert-dismissible fade show\' role=\'alert\'>\r\n            <strong>");
#nullable restore
#line 46 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Create.cshtml"
               Write(Model.successMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n            <button type=\'button\' class=\'btn-close\' data-bs-dismiss=\'alert\' aria-label=\'Close\'></button>\r\n        </div>\r\n");
#nullable restore
#line 49 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""row mb-3"">
        <div class=""offset-sm-3 col-sm-3 "">
            <button type=""submit"" class=""btn btn-outline-primary"">Submit</button>
        </div>
        <div class=""offset-sm-2 "">
            <a class=""btn btn-outline-danger"" href=""/"" role=""button"">Cancel</a>
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dotNetCoreWebApp.Pages.Clients.CreateModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dotNetCoreWebApp.Pages.Clients.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dotNetCoreWebApp.Pages.Clients.CreateModel>)PageContext?.ViewData;
        public dotNetCoreWebApp.Pages.Clients.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
