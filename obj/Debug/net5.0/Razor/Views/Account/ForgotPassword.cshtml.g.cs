#pragma checksum "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97aae5d044e1efc3c57c43bc51396f0b941d5e59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ForgotPassword), @"mvc.1.0.view", @"/Views/Account/ForgotPassword.cshtml")]
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
#line 1 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/_ViewImports.cshtml"
using DreamMessenger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/_ViewImports.cshtml"
using DreamMessenger.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97aae5d044e1efc3c57c43bc51396f0b941d5e59", @"/Views/Account/ForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d200e741e36eecf04c973e89596fef1077609f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_ForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ForgotPassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/Settings"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("account-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97aae5d044e1efc3c57c43bc51396f0b941d5e595511", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Dreams Chat - Forgot Password</title>

    <!-- Подключение стилей CSS по ссылке -->
    <link rel=""icon""");
                BeginWriteAttribute("href", " href=", 314, "", 360, 1);
#nullable restore
#line 10 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml"
WriteAttributeValue("", 320, Url.Content("~/assets/img/favicon.png"), 320, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=", 388, "", 440, 1);
#nullable restore
#line 11 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml"
WriteAttributeValue("", 394, Url.Content("~/assets/css/bootstrap.min.css"), 394, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=", 468, "", 542, 1);
#nullable restore
#line 12 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml"
WriteAttributeValue("", 474, Url.Content("~/assets/plugins/fontawesome/css/fontawesome.min.css"), 474, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=", 570, "", 636, 1);
#nullable restore
#line 13 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml"
WriteAttributeValue("", 576, Url.Content("~/assets/plugins/fontawesome/css/all.min.css"), 576, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=", 664, "", 744, 1);
#nullable restore
#line 14 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml"
WriteAttributeValue("", 670, Url.Content("~/assets/plugins/mcustomscroll/jquery.mCustomScrollbar.css"), 670, 74, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=", 772, "", 814, 1);
#nullable restore
#line 15 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml"
WriteAttributeValue("", 778, Url.Content("~/assets/css/app.css"), 778, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97aae5d044e1efc3c57c43bc51396f0b941d5e599309", async() => {
                WriteLiteral(@"

    <div class=""main-wrapper"">

        <div class=""content align-items-center"">
            <div class=""w-100 "">
                <div class=""login-left"">

                    <div class=""account-content"">
                        <!-- Заголовок сброса пароля -->
                        <div class=""login-header"">
                            <a href=""index.html"">
                                <img");
                BeginWriteAttribute("src", " src=", 1253, "", 1300, 1);
#nullable restore
#line 29 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml"
WriteAttributeValue("", 1258, Url.Content("~/assets/img/logo-full.png"), 1258, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1300, "\"", 1306, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </a>
                        </div>
                        <!-- Форма сброса пароля -->
                        <div class=""form-col"">
                            <div class=""login-text-details"">
                                <h3>Forgot Password</h3>
                                <p>Confirm your email and enter the OTP to send to your Registered Email id.</p>
                            </div>
                            <!-- Форма сброса пароля -->
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97aae5d044e1efc3c57c43bc51396f0b941d5e5911004", async() => {
                    WriteLiteral("\n                                ");
#nullable restore
#line 40 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml"
                           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                <div class=""form-group"">
                                    <label>Your Email</label>
                                    <input class=""form-control form-control-lg group_formcontrol"" name=""Email"" type=""email"" required>
                                </div>
                                <div class=""pt-3"">
                                    <div class=""text-center"">
                                        <button class=""btn newgroup_create btn-block d-block w-100"" type=""submit"">Reset Password</button>
                                    </div>
                                </div>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </div>\n                        <!-- Вернуться назад -->\n                        <div class=\"back-btn-col text-center\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97aae5d044e1efc3c57c43bc51396f0b941d5e5914036", async() => {
                    WriteLiteral("<span><i class=\"fas fa-caret-left\"></i></span> Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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

                </div>
                <div class=""login-right pwd-bg"">
                </div>
            </div>
        </div>

    </div>

    <!-- Подключение скриптов JS по ссылке -->
    <script");
                BeginWriteAttribute("src", " src=", 3132, "", 3182, 1);
#nullable restore
#line 67 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml"
WriteAttributeValue("", 3137, Url.Content("assets/js/jquery-3.6.0.min.js"), 3137, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=", 3204, "", 3258, 1);
#nullable restore
#line 68 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml"
WriteAttributeValue("", 3209, Url.Content("assets/js/bootstrap.bundle.min.js"), 3209, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=", 3280, "", 3335, 1);
#nullable restore
#line 69 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml"
WriteAttributeValue("", 3285, Url.Content("assets/js/jquery.nicescroll.min.js"), 3285, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=", 3357, "", 3433, 1);
#nullable restore
#line 70 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml"
WriteAttributeValue("", 3362, Url.Content("assets/plugins/mcustomscroll/jquery.mCustomScrollbar.js"), 3362, 71, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=", 3455, "", 3495, 1);
#nullable restore
#line 71 "/Users/pskakodub/RiderProjects/DreamMessenger/Views/Account/ForgotPassword.cshtml"
WriteAttributeValue("", 3460, Url.Content("assets/js/script.js"), 3460, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
