#pragma checksum "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "237fc8ae3b77bb901d686292bee54d1091aa2fe6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Step2), @"mvc.1.0.view", @"/Views/Auth/Step2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/Step2.cshtml", typeof(AspNetCore.Views_Auth_Step2))]
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
#line 1 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore;

#line default
#line hidden
#line 2 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"237fc8ae3b77bb901d686292bee54d1091aa2fe6", @"/Views/Auth/Step2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Step2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionConcoursCore.Models.Baccalaureat>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("shortcut icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image/x-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/ensa_logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
  
    ViewBag.Title = "Step2";
    Layout = null;

#line default
#line hidden
            BeginContext(105, 17, true);
            WriteLiteral("\r\n<!-- icon -->\r\n");
            EndContext();
            BeginContext(122, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fad373dec02540e987b9c978ca6f5a2e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(200, 546, true);
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" />

<style>
    body {
        background: #7db4f3;
        background: -webkit-linear-gradient(-135deg, #7db4f3, #fdaee9dc);
        background: -o-linear-gradient(-135deg, #7db4f3, #fdaee9dc);
        background: -moz-linear-gradient(-135deg, #7db4f3, #fdaee9dc);
        background: linear-gradient(-135deg, #7db4f3, #fdaee9dc);
    }
</style>

<h2 class=""text-center mt-3 font-weight-bold"">Step 2 : Informations du Bac</h2>
");
            EndContext();
#line 22 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
 using (Html.BeginForm("Step2", "Auth", FormMethod.Post))
{


#line default
#line hidden
            BeginContext(810, 243, true);
            WriteLiteral("    <hr class=\"col-md-7 offset-md-2 mb-5\" />\r\n    <div class=\"row d-flex justify-content-center m-b-30 \">\r\n        <div class=\"offset-3\"></div>\r\n        <div class=\"col-md-7\">\r\n\r\n            <div class=\"form-horizontal \">\r\n\r\n\r\n                ");
            EndContext();
            BeginContext(1054, 64, false);
#line 33 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1137, 34, false);
#line 34 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
           Write(Html.HiddenFor(model => model.Cne));

#line default
#line hidden
            EndContext();
            BeginContext(1171, 68, true);
            WriteLiteral("\r\n\r\n\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1240, 142, false);
#line 38 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
               Write(Html.LabelFor(model => model.TypeBac, "Type du Bac :", htmlAttributes: new { @class = "control-label col-md-10 text-white font-weight-bold" }));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 70, true);
            WriteLiteral("\r\n                    <div class=\"col-md-7\">\r\n                        ");
            EndContext();
            BeginContext(1453, 553, false);
#line 40 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
                   Write(Html.DropDownListFor(model => model.TypeBac,
                       new List<SelectListItem>
                       {
                                    new SelectListItem{Text="SMA", Value="SMA"},
                                    new SelectListItem{Text="SMB", Value="SMB"},
                                    new SelectListItem{Text="SVT", Value="SVT"},
                                    new SelectListItem{Text="PC", Value="PC"}
                       }, "--- Séléctionner un type ---", htmlAttributes: new { @class = "form-control " }));

#line default
#line hidden
            EndContext();
            BeginContext(2006, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2033, 85, false);
#line 48 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
                   Write(Html.ValidationMessageFor(model => model.TypeBac, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2118, 118, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(2237, 163, false);
#line 53 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
               Write(Html.LabelFor(model => model.DateObtentionBac, "Date d'obtention du Bac :", htmlAttributes: new { @class = "control-label col-md-10 text-white font-weight-bold" }));

#line default
#line hidden
            EndContext();
            BeginContext(2400, 70, true);
            WriteLiteral("\r\n                    <div class=\"col-md-7\">\r\n                        ");
            EndContext();
            BeginContext(2471, 133, false);
#line 55 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
                   Write(Html.EditorFor(model => model.DateObtentionBac, new { htmlAttributes = new { @class = "form-control", placeholder = "YYYY/YYYY " } }));

#line default
#line hidden
            EndContext();
            BeginContext(2604, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2631, 94, false);
#line 56 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
                   Write(Html.ValidationMessageFor(model => model.DateObtentionBac, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2725, 118, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(2844, 142, false);
#line 61 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
               Write(Html.LabelFor(model => model.NoteBac, "Note du Bac :", htmlAttributes: new { @class = "control-label col-md-10 text-white font-weight-bold" }));

#line default
#line hidden
            EndContext();
            BeginContext(2986, 70, true);
            WriteLiteral("\r\n                    <div class=\"col-md-7\">\r\n                        ");
            EndContext();
            BeginContext(3057, 96, false);
#line 63 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
                   Write(Html.EditorFor(model => model.NoteBac, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3153, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3180, 85, false);
#line 64 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
                   Write(Html.ValidationMessageFor(model => model.NoteBac, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3265, 118, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(3384, 147, false);
#line 69 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
               Write(Html.LabelFor(model => model.MentionBac, "Metion du Bac :", htmlAttributes: new { @class = "control-label col-md-10 text-white font-weight-bold" }));

#line default
#line hidden
            EndContext();
            BeginContext(3531, 70, true);
            WriteLiteral("\r\n                    <div class=\"col-md-7\">\r\n                        ");
            EndContext();
            BeginContext(3602, 594, false);
#line 71 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
                   Write(Html.DropDownListFor(model => model.MentionBac,
                       new List<SelectListItem>
                        {
                            new SelectListItem{Text="Très Bien", Value="Très Bien"},
                            new SelectListItem{Text="Bien", Value="Bien"},
                            new SelectListItem{Text="Assez Bien", Value="Assez Bien"},
                            new SelectListItem{Text="Passable", Value="Passable"}
                        }
                       , "--- Séléctionner une mention ---", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4196, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(4223, 88, false);
#line 80 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"
                   Write(Html.ValidationMessageFor(model => model.MentionBac, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4311, 481, true);
            WriteLiteral(@"
                    </div>
                </div>

                <div class=""form-group"">
                    <div class=""row mt-5"">
                        <a class=""btn btn-info mt-2 px-5"" href=""Step1""> Previous </a>
                        <div class=""offset-4""></div>
                        <input type=""submit"" value="" Next "" class=""btn btn-primary px-5 mt-2"" />
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
#line 94 "C:\Users\Tarik Ouhamou\Source\Repos\DefaultLol\GestionConcoursCore\GestionConcoursCore\Views\Auth\Step2.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionConcoursCore.Models.Baccalaureat> Html { get; private set; }
    }
}
#pragma warning restore 1591
