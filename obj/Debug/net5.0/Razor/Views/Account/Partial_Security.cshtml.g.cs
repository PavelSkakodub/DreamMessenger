#pragma checksum "C:\Users\win10\source\repos\DreamMessenger\Views\Account\Partial_Security.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63c08f59a0d3d4cfdc33e83f4d0af46f4dc7ec6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Partial_Security), @"mvc.1.0.view", @"/Views/Account/Partial_Security.cshtml")]
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
#line 1 "C:\Users\win10\source\repos\DreamMessenger\Views\_ViewImports.cshtml"
using DreamMessenger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\win10\source\repos\DreamMessenger\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\win10\source\repos\DreamMessenger\Views\_ViewImports.cshtml"
using DreamMessenger.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63c08f59a0d3d4cfdc33e83f4d0af46f4dc7ec6b", @"/Views/Account/Partial_Security.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d200e741e36eecf04c973e89596fef1077609f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Partial_Security : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""tab-pane fade"" id=""security"">

    <div class=""settings-header"">
        <div class=""row align-items-center"">
            <div class=""col-md-8"">
                <h5>Change your password</h5>
                <p>We will email you a confirmation when changing your password, so please expect that email after submitting.</p>
            </div>
            <div class=""col-md-4 text-md-end"">
                <button class=""btn logout-btn""");
            BeginWriteAttribute("onclick", " onclick=\"", 455, "\"", 520, 3);
            WriteAttributeValue("", 465, "location.href=\'", 465, 15, true);
#nullable restore
#line 10 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\Partial_Security.cshtml"
WriteAttributeValue("", 480, Url.Action("ForgotPassword","Account"), 480, 39, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 519, "\'", 519, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Forgot password</button>
            </div>
        </div>
    </div>
    <div class=""security-settings"">
        <div class=""password-updation"">
            <div class=""row"">
                <div class=""col-xl-4"">
                    <div class=""form-col form-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63c08f59a0d3d4cfdc33e83f4d0af46f4dc7ec6b5420", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 20 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\Partial_Security.cshtml"
                       Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <div class=""form-group"">
                                <label>Current password</label>
                                <input class=""form-control form-control-lg group_formcontrol"" name=""model.CurrentPassword"" type=""password"" required>
                            </div>
                            <div class=""form-group"">
                                <label>New password</label>
                                <input class=""form-control form-control-lg group_formcontrol"" name=""model.NewPassword"" type=""password"" required>
                            </div>
                            <div class=""form-group"">
                                <label>Confirm password</label>
                                <input class=""form-control form-control-lg group_formcontrol"" name=""model.ConfirmPassword"" type=""password"" required>
                            </div>
                            <div class=""form-row profile_form m-0 align-items-center"">
                           ");
                WriteLiteral(@"     <div class=""me-4"">
                                    <button type=""submit"" class=""btn btn-update  mb-0"">
                                        Update Password
                                    </button>
                                </div>

                                <div class=""cancel-btn"">
                                    ");
#nullable restore
#line 41 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\Partial_Security.cshtml"
                               Write(Html.ActionLink("Cancel","Settings","Account"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-xl-8"">
                    <div class=""requirment-card"">
                        <h4>Password requirements</h4>
                        <p class=""py-3 mb-0"">To create a new password, you have to meet all of the following requirements:</p>
                        <div class=""requirements-list"">
                            <p>Minimum 6 character</p>
                            <p>At least one lowercase character</p>
                            <p>At least one number</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <hr>
        <div class=""authentication"">
            <h4>Two Factor Authentication</h4>
            <div class=""align-items-center"">
                <label class=""custom-radio me-2"">
                    Password <br> <span><a href=""#"" data-bs-toggle=""modal"" data-bs-target=""#password-authentication"">edit</a></span>
      ");
            WriteLiteral(@"              <input type=""radio"" name=""radio"">
                    <span class=""checkmark""></span>
                </label>
                <label class=""custom-radio me-2"">
                    Sequrity Question <br> <span><a href=""#"" data-bs-toggle=""modal"" data-bs-target=""#question-authentication"">edit</a></span>
                    <input type=""radio"" name=""radio"">
                    <span class=""checkmark""></span>
                </label>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AppUserManager UserManager { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
