#pragma checksum "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "903b5c56dfc4e02631c6b6d053482c8e3d03cd72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tenant_Index), @"mvc.1.0.view", @"/Views/Tenant/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\_ViewImports.cshtml"
using rentManagementMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\_ViewImports.cshtml"
using rentManagementMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"903b5c56dfc4e02631c6b6d053482c8e3d03cd72", @"/Views/Tenant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a404fd9a658f8190f492e5cd722997a6a3665345", @"/Views/_ViewImports.cshtml")]
    public class Views_Tenant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<rentManagement.Models.Tenant>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Form", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h2>List of Tenants</h2>&nbsp;\r\n<div>\r\n    <div>Number of Tenants : ");
#nullable restore
#line 5 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Index.cshtml"
                        Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>&nbsp;\r\n");
            WriteLiteral(@"
    <table class=""table table-striped table-hover"">
        <thead class=""thead-dark"">
        <tr>
            <th><i class=""fa fa-user-circle fa-fw"" aria-hidden=""true""></i> Full Name of Tenants</th>
            <th><i class=""fa fa-address-book fa-fw"" aria-hidden=""true""></i> Full Address</th>
            <th><i class=""fa fa-credit-card fa-fw"" aria-hidden=""true""></i> Deposit Paid</th>
            <th><i class=""fa fa-building fa-fw"" aria-hidden=""true""></i></i> Is Assigned a Unit?</th>
            <th></th>
        </tr>
        </thead>
");
#nullable restore
#line 18 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Index.cshtml"
         for (var i = 0; i < Model.Count; i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Index.cshtml"
               Write(Model[i].FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Index.cshtml"
               Write(Model[i].Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Index.cshtml"
                                 Write(Model[i].PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Index.cshtml"
                                                      Write(Model[i].City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Index.cshtml"
               Write(Model[i].Deposit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 23 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Index.cshtml"
                 if(@Model[i].IsAssigned == false){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color: red;\">No</td>\r\n");
#nullable restore
#line 25 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Index.cshtml"
                }
                else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color: green;\">Yes</td>\r\n");
#nullable restore
#line 28 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "903b5c56dfc4e02631c6b6d053482c8e3d03cd727450", async() => {
                WriteLiteral("View Tenant");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Index.cshtml"
                                              WriteLiteral(Model[i].TenantId);

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
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    \r\n    </table>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "903b5c56dfc4e02631c6b6d053482c8e3d03cd729911", async() => {
                WriteLiteral("<i class=\"fa fa-plus fa-fw\" aria-hidden=\"true\"></i>Create New Tenant");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<rentManagement.Models.Tenant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
