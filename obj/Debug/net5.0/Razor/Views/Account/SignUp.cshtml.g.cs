#pragma checksum "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "354c1468b2175020ffa6bf7d7b1d31963d149f83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SignUp), @"mvc.1.0.view", @"/Views/Account/SignUp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"354c1468b2175020ffa6bf7d7b1d31963d149f83", @"/Views/Account/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d200e741e36eecf04c973e89596fef1077609f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignUp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "354c1468b2175020ffa6bf7d7b1d31963d149f835508", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Dreams Chat - Html Template</title>

    <!-- Подключение стилей CSS по ссылке -->
    <link rel=""icon""");
                BeginWriteAttribute("href", " href=", 297, "", 343, 1);
#nullable restore
#line 10 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml"
WriteAttributeValue("", 303, Url.Content("~/assets/img/favicon.png"), 303, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=", 371, "", 423, 1);
#nullable restore
#line 11 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml"
WriteAttributeValue("", 377, Url.Content("~/assets/css/bootstrap.min.css"), 377, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=", 451, "", 525, 1);
#nullable restore
#line 12 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml"
WriteAttributeValue("", 457, Url.Content("~/assets/plugins/fontawesome/css/fontawesome.min.css"), 457, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=", 553, "", 619, 1);
#nullable restore
#line 13 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml"
WriteAttributeValue("", 559, Url.Content("~/assets/plugins/fontawesome/css/all.min.css"), 559, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=", 647, "", 727, 1);
#nullable restore
#line 14 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml"
WriteAttributeValue("", 653, Url.Content("~/assets/plugins/mcustomscroll/jquery.mCustomScrollbar.css"), 653, 74, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=", 755, "", 797, 1);
#nullable restore
#line 15 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml"
WriteAttributeValue("", 761, Url.Content("~/assets/css/app.css"), 761, 36, false);

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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "354c1468b2175020ffa6bf7d7b1d31963d149f839314", async() => {
                WriteLiteral(@"

    <div class=""main-wrapper"">

        <!-- Форма регистрации -->
        <div class=""content align-items-center"">
            <div class=""w-100 "">
                <div class=""login-left"">

                    <div class=""account-content"">
                        <!-- Заголовок регистрации -->
                        <div class=""login-header"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "354c1468b2175020ffa6bf7d7b1d31963d149f839958", async() => {
                    WriteLiteral("\n                                <img");
                    BeginWriteAttribute("src", " src=", 1275, "", 1322, 1);
#nullable restore
#line 31 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml"
WriteAttributeValue("", 1280, Url.Content("~/assets/img/logo-full.png"), 1280, 42, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("alt", " alt=\"", 1322, "\"", 1328, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <!-- Форма регистрации -->
                        <div class=""form-col"">
                            <div class=""login-text-details"">
                                <h3>Sign up</h3>
                                <p>Lets get you all setup so you can verify your personal account and begin setting up your Profile.</p>
                            </div>

                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "354c1468b2175020ffa6bf7d7b1d31963d149f8312123", async() => {
                    WriteLiteral("                        \n                                ");
#nullable restore
#line 42 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml"
                           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                                <div class=""form-group"">
                                    <label>First Name</label>
                                    <input class=""form-control form-control-lg group_formcontrol"" name=""model.FirstName"" type=""text"" placeholder=""Pavel"" autofocus=""autofocus"" maxlength=15 required> 
                                </div>
                                <div class=""form-group"">
                                    <label>Last Name</label>
                                    <input class=""form-control form-control-lg group_formcontrol"" name=""model.LastName"" type=""text"" placeholder=""Skakodub"" maxlength=20 required>
                                </div>
                                <div class=""form-group"">
                                    <label>Email</label>
                                    <input class=""form-control form-control-lg group_formcontrol""  name=""model.Email"" type=""email"" placeholder=""pavel.skakodub@list.ru"" maxlength=50 required>                
          ");
                    WriteLiteral(@"                      </div>
                                <div class=""form-group"">
                                    <label>Password</label>
                                    <input class=""form-control form-control-lg group_formcontrol"" name=""model.Password"" type=""password"" required>
                                    
                                </div>
                                <div class=""form-group"">
                                    <label>Confirm Password</label>
                                    <input class=""form-control form-control-lg group_formcontrol"" name=""model.PasswordConfirm"" type=""password"" required>
                                </div>
                                <div class=""form-group"">
                                    <label>
                                        <input type=""checkbox"" required value=""true""> I agreed to all the <a href=""#"" data-bs-toggle=""modal"" data-bs-target=""#terms""> Terms & Conditions,  </a><a href=""#""> Privacy Policy.</a>
              ");
                    WriteLiteral(@"                          <span class=""checkmark""></span>
                                    </label>
                                </div>
                                <div class=""pt-1"">
                                    <div class=""text-center"">
                                        <button class=""btn newgroup_create btn-block d-block w-100"" type=""submit"">Create Account</button>
                                    </div>
                                </div>
                                <div class=""text-center dont-have"">Already have an Account? ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "354c1468b2175020ffa6bf7d7b1d31963d149f8315466", async() => {
                        WriteLiteral("Login");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("</div>\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                        </div>\n                        <!-- Вернуться назад -->\n                        <div class=\"back-btn-col text-center\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "354c1468b2175020ffa6bf7d7b1d31963d149f8318526", async() => {
                    WriteLiteral("<span><i class=\"fas fa-caret-left\"></i></span> Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                <div class=""login-right signup-bg"">
                </div>
            </div>
        </div>

        <!-- Окно Terms&Conditions -->
        <div class=""modal fade"" id=""terms"">
            <div class=""modal-dialog modal-dialog-centered"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"">
                            Terms & Conditions
                        </h5>
                        <button type=""button"" class=""close"" data-bs-dismiss=""modal"" aria-label=""Close"">
                            <span class=""material-icons"">close</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""terms-card"">
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Elementum vulputate facilisi eu ultricies integer dia");
                WriteLiteral(@"m. Eu ullamcorper arcu dui, eget volutpat risus dui. Donec nulla mi neque, egestas tristique non. Vel pellentesque dolor nibh scelerisque turpis. Lacus magna vestibulum, quis aliquam nunc, euismod amet.</p>
                            <p>Aliquet elit sapien orci ipsum faucibus fermentum habitant. Ac quam sit leo posuere nulla dignissim. In mi, velit vitae dictum ac. Suscipit orci, sit amet mi massa gravida lectus elit. Auctor lorem arcu quis commodo nibh ipsum. Lectus amet, ultrices nec amet sed condimentum donec.</p>
                            <p class=""mb-0"">Arcu sed aenean venenatis arcu in at varius. Elementum, nunc, malesuada pretium cras sed praesent mi arcu urna. Erat maecenas lectus pharetra, blandit lectus.</p>
                        </div>
                        <div class=""text-end mt-3 align-items-center"">
                            <button type=""button"" class=""btn newgroup_create mb-0 close-btn"" data-bs-dismiss=""modal"" aria-label=""Close"">
                                Close
                ");
                WriteLiteral("            </button>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n\n    </div>\n\n    <!-- Подключение скриптов JS по ссылке -->\n    <script");
                BeginWriteAttribute("src", " src=", 7153, "", 7205, 1);
#nullable restore
#line 122 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml"
WriteAttributeValue("", 7158, Url.Content("~/assets/js/jquery-3.6.0.min.js"), 7158, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"></script>
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validate/1.16.0/jquery.validate.min.js""></script>

<script src=""https://ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusive/3.2.6/jquery.validate.unobtrusive.min.js""></script>
    <script");
                BeginWriteAttribute("src", " src=", 7461, "", 7517, 1);
#nullable restore
#line 126 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml"
WriteAttributeValue("", 7466, Url.Content("~/assets/js/bootstrap.bundle.min.js"), 7466, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=", 7539, "", 7596, 1);
#nullable restore
#line 127 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml"
WriteAttributeValue("", 7544, Url.Content("~/assets/js/jquery.nicescroll.min.js"), 7544, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=", 7618, "", 7696, 1);
#nullable restore
#line 128 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml"
WriteAttributeValue("", 7623, Url.Content("~/assets/plugins/mcustomscroll/jquery.mCustomScrollbar.js"), 7623, 73, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=", 7718, "", 7760, 1);
#nullable restore
#line 129 "C:\Users\win10\source\repos\DreamMessenger\Views\Account\SignUp.cshtml"
WriteAttributeValue("", 7723, Url.Content("~/assets/js/script.js"), 7723, 37, false);

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