#pragma checksum "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38bb569b211d865c293e791026e54bc51c75afad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tenant_Details), @"mvc.1.0.view", @"/Views/Tenant/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38bb569b211d865c293e791026e54bc51c75afad", @"/Views/Tenant/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a404fd9a658f8190f492e5cd722997a6a3665345", @"/Views/_ViewImports.cshtml")]
    public class Views_Tenant_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<rentManagement.Models.Tenant>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">Full Name:</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 6 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
                        Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">Address:</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 9 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
                        Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">Postal Code:</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 12 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
                        Write(Model.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        \r\n        <dt class=\"col-sm-3\">City:</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 15 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
                        Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">Id Proof Provided:</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 18 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
                        Write(Model.IdProof);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">Deposit paid:</dt>\r\n        <dd class=\"col-sm-9\">");
#nullable restore
#line 21 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
                        Write(Model.Deposit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt class=\"col-sm-3\">Is assigned a Unit?</dt>\r\n");
#nullable restore
#line 24 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
         if(Model.IsAssigned == true){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-9\">Yes</dd>\r\n");
#nullable restore
#line 26 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
        }
        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-9\">No</dd>    \r\n");
#nullable restore
#line 29 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38bb569b211d865c293e791026e54bc51c75afad7376", async() => {
                WriteLiteral("Edit Tenant");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
                                                       WriteLiteral(Model.TenantId);

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
            WriteLiteral("\r\n    </div>\r\n    </br>\r\n");
#nullable restore
#line 36 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
     if(@Model.IsAssigned == false){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38bb569b211d865c293e791026e54bc51c75afad9934", async() => {
                WriteLiteral("Remove Tenant");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
                                                             WriteLiteral(Model.TenantId);

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
            WriteLiteral("\r\n        </div>\r\n        <br>\r\n");
#nullable restore
#line 41 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
        }
    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1299, "\"", 1306, 0);
            EndWriteAttribute();
            WriteLiteral(">Remove Tenant</a>\r\n        </div>\r\n            <div class=\"alert alert-warning\">\r\n                <strong>Warning!</strong> <br>\r\n                <p style=\"color: red;\">Please UnAssign the unit that has been assigned to ");
#nullable restore
#line 48 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
                                                                                     Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", then come back to delete the tenant.</p>\r\n            </div>\r\n        <div>\r\n            \r\n        </div>\r\n        <br>\r\n");
#nullable restore
#line 54 "C:\Users\user\Desktop\rentManagementMvc\rentManagementMVC\Views\Tenant\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<rentManagement.Models.Tenant> Html { get; private set; }
    }
}
#pragma warning restore 1591
