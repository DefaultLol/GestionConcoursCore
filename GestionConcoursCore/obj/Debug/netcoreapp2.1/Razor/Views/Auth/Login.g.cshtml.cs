#pragma checksum "C:\Users\AndroidStar\Desktop\Folders\ProjetASP\GestionConcoursCore\GestionConcoursCore\Views\Auth\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b45e6907f76acfb22d3ef21e6a3f2b548c87ca9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Login), @"mvc.1.0.view", @"/Views/Auth/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/Login.cshtml", typeof(AspNetCore.Views_Auth_Login))]
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
#line 1 "C:\Users\AndroidStar\Desktop\Folders\ProjetASP\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore;

#line default
#line hidden
#line 2 "C:\Users\AndroidStar\Desktop\Folders\ProjetASP\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b45e6907f76acfb22d3ef21e6a3f2b548c87ca9d", @"/Views/Auth/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/user_register.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons_user/graduation.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:32%; height:32%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" parent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("parent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\AndroidStar\Desktop\Folders\ProjetASP\GestionConcoursCore\GestionConcoursCore\Views\Auth\Login.cshtml"
  
    ViewBag.Title = "Login";
    Layout = null;

#line default
#line hidden
            BeginContext(57, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(92, 506, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89d4a9a50b2c4ef1aff7b1d041eea601", async() => {
                BeginContext(98, 229, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <link href=\"//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css\" rel=\"stylesheet\" id=\"bootstrap-css\">\r\n    ");
                EndContext();
                BeginContext(327, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb87d3a333654593b0d7b18beaef0688", async() => {
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
                EndContext();
                BeginContext(381, 210, true);
                WriteLiteral("\r\n    <script src=\"//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js\"></script>\r\n    <script src=\"//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js\"></script>\r\n    <title>Login</title>\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(598, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(602, 3567, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37516a7e69c34c1a806180df625a8600", async() => {
                BeginContext(636, 229, true);
                WriteLiteral("\r\n    <div id=\"child\" class=\"child\">\r\n        <div class=\" container register align-content-between\" style=\"opacity:0.9;\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-5 register-left\">\r\n                    ");
                EndContext();
                BeginContext(865, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8706d720c5ff418dae86ff71e6139b91", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(951, 494, true);
                WriteLiteral(@"
                    <h3>Bienvenue à l'ENSA</h3>
                    <p>Pour s'inscrire au concours d'accès à l'ENSA de SAFI en 3ème ou 4ème année</p>

                </div>
                <div class=""col-md-7 register-right"">
                    <div class=""tab-content"" id=""myTabContent"">
                        <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                            <h3 class=""register-heading"">Login Portal</h3>
");
                EndContext();
#line 32 "C:\Users\AndroidStar\Desktop\Folders\ProjetASP\GestionConcoursCore\GestionConcoursCore\Views\Auth\Login.cshtml"
                             using (Html.BeginForm())
                            {

#line default
#line hidden
                BeginContext(1531, 134, true);
                WriteLiteral("                                <div class=\"row register-form\">\r\n                                    <div class=\"col-md-8 offset-2\">\r\n");
                EndContext();
#line 36 "C:\Users\AndroidStar\Desktop\Folders\ProjetASP\GestionConcoursCore\GestionConcoursCore\Views\Auth\Login.cshtml"
                                         if (TempData["message"] != null)
                                        {

#line default
#line hidden
                BeginContext(1783, 211, true);
                WriteLiteral("                                            <div class=\"form-group\">\r\n                                                <div class=\"alert alert-success\">\r\n                                                    <span>");
                EndContext();
                BeginContext(1995, 19, false);
#line 40 "C:\Users\AndroidStar\Desktop\Folders\ProjetASP\GestionConcoursCore\GestionConcoursCore\Views\Auth\Login.cshtml"
                                                     Write(TempData["message"]);

#line default
#line hidden
                EndContext();
                BeginContext(2014, 117, true);
                WriteLiteral("</span>\r\n                                                </div>\r\n                                            </div>\r\n");
                EndContext();
#line 43 "C:\Users\AndroidStar\Desktop\Folders\ProjetASP\GestionConcoursCore\GestionConcoursCore\Views\Auth\Login.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2174, 40, true);
                WriteLiteral("                                        ");
                EndContext();
#line 44 "C:\Users\AndroidStar\Desktop\Folders\ProjetASP\GestionConcoursCore\GestionConcoursCore\Views\Auth\Login.cshtml"
                                         if (TempData["error"] != null)
                                        {

#line default
#line hidden
                BeginContext(2290, 210, true);
                WriteLiteral("                                            <div class=\"form-group\">\r\n                                                <div class=\"alert alert-danger\">\r\n                                                    <span>");
                EndContext();
                BeginContext(2501, 17, false);
#line 48 "C:\Users\AndroidStar\Desktop\Folders\ProjetASP\GestionConcoursCore\GestionConcoursCore\Views\Auth\Login.cshtml"
                                                     Write(TempData["error"]);

#line default
#line hidden
                EndContext();
                BeginContext(2518, 117, true);
                WriteLiteral("</span>\r\n                                                </div>\r\n                                            </div>\r\n");
                EndContext();
#line 51 "C:\Users\AndroidStar\Desktop\Folders\ProjetASP\GestionConcoursCore\GestionConcoursCore\Views\Auth\Login.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2678, 1317, true);
                WriteLiteral(@"                                        <div class=""form-group"">
                                            <input type=""text"" class=""form-control"" placeholder=""Cin"" value="""" name=""cin"" />
                                        </div>
                                        <div class=""form-group"">
                                            <input type=""text"" class=""form-control"" placeholder=""Cne"" value="""" name=""cne"" />
                                        </div>
                                        <div class=""form-group"">
                                            <input type=""password"" class=""form-control"" placeholder=""Password"" value="""" name=""password"" />
                                        </div>
                                        <div class=""form-group"">
                                            <input type=""submit"" class=""btnRegister"" value=""Login"" /><br /><br>
                                            <a href=""Register"">S'inscrire !</a><br />
                        ");
                WriteLiteral(@"                    <a href=""PasswordOublie"">Mot de passe oublié</a><br />
                                            <a href=""/Landing"">Landing Page</a>
                                        </div>


                                    </div>
                                </div>
");
                EndContext();
#line 71 "C:\Users\AndroidStar\Desktop\Folders\ProjetASP\GestionConcoursCore\GestionConcoursCore\Views\Auth\Login.cshtml"
                            }

#line default
#line hidden
                BeginContext(4026, 136, true);
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4169, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
