#pragma checksum "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "59e85e6c8bdf56110864d8cc6759dac4e4a78cc7177b4d86786f0df9bcee8823"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(dotNetCoreWebApp.Pages.Clients.Pages_Clients_Index), @"mvc.1.0.razor-page", @"/Pages/Clients/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"59e85e6c8bdf56110864d8cc6759dac4e4a78cc7177b4d86786f0df9bcee8823", @"/Pages/Clients/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7c3e757c8754b018264949bb16353c32705edd26f4430d2feb7eba27ba492d4b", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Clients_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<br />
<h2>List of Clients</h2>
<a class='btn btn-primary btn-sm' href='/Clients/Create'>New Client</a>
<table class=""table"">
    <thead>
         <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Phone</th>
            <th>Address</th>
            <th>Created At</th>
            <th>Action</th>
         </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Index.cshtml"
         foreach(var item in Model.listClients)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Index.cshtml"
               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Index.cshtml"
               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Index.cshtml"
               Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Index.cshtml"
               Write(item.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Index.cshtml"
               Write(item.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Index.cshtml"
               Write(item.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\'btn btn-outline-primary btn-sm\'");
            BeginWriteAttribute("href", " href=\"", 857, "\"", 889, 2);
            WriteAttributeValue("", 864, "/Clients/Edit?id=", 864, 17, true);
#nullable restore
#line 31 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Index.cshtml"
WriteAttributeValue("", 881, item.id, 881, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                    <a class=\'btn btn-outline-danger btn-sm\'");
            BeginWriteAttribute("href", " href=\"", 961, "\"", 995, 2);
            WriteAttributeValue("", 968, "/Clients/Delete?id=", 968, 19, true);
#nullable restore
#line 32 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Index.cshtml"
WriteAttributeValue("", 987, item.id, 987, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\camdi\source\repos\dotNetCoreWebApp\dotNetCoreWebApp\Pages\Clients\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dotNetCoreWebApp.Pages.Clients.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dotNetCoreWebApp.Pages.Clients.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dotNetCoreWebApp.Pages.Clients.IndexModel>)PageContext?.ViewData;
        public dotNetCoreWebApp.Pages.Clients.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
