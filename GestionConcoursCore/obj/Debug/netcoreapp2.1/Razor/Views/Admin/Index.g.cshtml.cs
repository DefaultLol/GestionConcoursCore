#pragma checksum "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a14c3e36119d2e796d13ae854ea393f34de68b5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
#line 1 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore;

#line default
#line hidden
#line 2 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\_ViewImports.cshtml"
using GestionConcoursCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a14c3e36119d2e796d13ae854ea393f34de68b5f", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d40043f5e6a50be129fc5644635f682c8f7c25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestionConcoursCore.Models.IndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/admin_pic/statistic3.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" ml-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(137, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(355, 935, true);
            WriteLiteral(@"

<!-- Begin Page Content -->
<div class=""container-fluid"">

    <h2 class=""font-weight-bold text-center py-2"">
        <i class=""fas fa-home fa-1x mr-3 ""></i>
        Bienvenue Admin !
    </h2>

    <hr class=""offset-2 col-8 pb-1"" />

    <div class=""row mb-5"">
        <div class=""col-lg-5 offset-lg-1 mt-5 col-md-8 offset-md-2"">
            <div class="" col-lg-10 mt-5 "">

                <div class=""card border-left-warning shadow h-100 py-2"">
                    
                        <div class=""card-body pt-3"">
                            <div class=""row no-gutters align-items-center"">
                                <div class=""col mr-2"">
                                    <div class=""h6 font-weight-bold text-warning text-uppercase mb-3"">Total des candidats</div>
                                    <div class=""h4 mb-0 font-weight-bold text-gray-800"">
                                        ");
            EndContext();
            BeginContext(1291, 11, false);
#line 33 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                                   Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1302, 575, true);
            WriteLiteral(@"
                                        <span class=""small "">candidats</span>
                                    </div>
                                </div>
                                <div class=""col-auto"">
                                    <i class=""fas fa-users fa-2x text-gray-500""></i>
                                </div>
                            </div>
                        </div>
                   
                </div>
            </div>
        </div>
        
        <div class="" col-lg-6 offset-sm-2 offset-lg-0"">
            ");
            EndContext();
            BeginContext(1877, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f4e799291f94e9d9f3a32895ffc7025", async() => {
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
            BeginContext(1938, 735, true);
            WriteLiteral(@"
        </div>
    </div>

    <div class=""row"">
        <!-- ###################################################  TOTAL INSCRITS 3 ###################################-->
        <div class=""col-lg-6"">
            <div class=""card shadow mb-4"">
                <!-- Card Header -->
                <div class=""card-header py-3 d-flex flex-row align-items-center "">
                    <i class=""fas fa-dice-three fa-2x text-primary mr-3 ""></i>
                    <h5 class=""m-0 font-weight-bold text-primary"">
                        Total des Inscrits en 3ème Année
                        <i class=""fas fa-arrow-right mx-2""></i>
                        <span class=""h4 font-weight-bold"">
                            ");
            EndContext();
            BeginContext(2674, 14, false);
#line 63 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                       Write(Model.Inscrit3);

#line default
#line hidden
            EndContext();
            BeginContext(2688, 825, true);
            WriteLiteral(@"
                        </span>
                    </h5>
                </div>

                <!-- INFO -->
                <row class=""d-lg-inline-flex px-2"">
                    <div class=""col-lg-6 col-sm-10 offset-md-1 offset-lg-0 mt-4 "">
                        <div class=""card border-left-danger border-bottom-danger shadow h-100 py-2"">
                            <div class=""card-body pt-3"">
                                <div class=""row no-gutters align-items-center"">
                                    <div class=""col mr-2"">
                                        <div class=""text-xs font-weight-bold text-danger text-uppercase mb-2"">Informatique</div>
                                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">
                                            ");
            EndContext();
            BeginContext(3514, 11, false);
#line 77 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                                       Write(Model.Info3);

#line default
#line hidden
            EndContext();
            BeginContext(3525, 1193, true);
            WriteLiteral(@"
                                            <span class=""small "">candidats</span>
                                        </div>
                                    </div>
                                    <div class=""col-auto"">
                                        <i class=""fas fa-laptop-code fa-2x text-gray-400""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- GTR -->
                    <div class=""col-lg-6 col-sm-10 offset-md-1 offset-lg-0 mt-4"">
                        <div class=""card border-left-warning border-bottom-warning shadow h-100 py-2"">
                            <div class=""card-body pt-3"">
                                <div class=""row no-gutters align-items-center"">
                                    <div class=""col mr-2"">
                                        <div class=""text-xs font-weight-bold text-warning t");
            WriteLiteral("ext-uppercase mb-2\">GTR</div>\r\n                                        <div class=\"h5 mb-0 font-weight-bold text-gray-800\">\r\n                                            ");
            EndContext();
            BeginContext(4719, 10, false);
#line 96 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                                       Write(Model.Gtr3);

#line default
#line hidden
            EndContext();
            BeginContext(4729, 1282, true);
            WriteLiteral(@"
                                            <span class=""small "">candidats</span>
                                        </div>
                                    </div>
                                    <div class=""col-auto"">
                                        <i class=""fas fa-network-wired fa-2x text-gray-400""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </row>
                <!-- INDUS -->
                <row class=""d-lg-inline-flex mb-4 px-2"">
                    <div class=""col-lg-6 col-sm-10 offset-md-1 offset-lg-0 mt-2"">
                        <div class=""card border-left-success border-bottom-success shadow h-100 py-2"">
                            <div class=""card-body pt-3"">
                                <div class=""row no-gutters align-items-center"">
                                    <div class=""col mr-2"">
         ");
            WriteLiteral(@"                               <div class=""text-xs font-weight-bold text-success text-uppercase mb-2"">Industriel</div>
                                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">
                                            ");
            EndContext();
            BeginContext(6012, 12, false);
#line 117 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                                       Write(Model.Indus3);

#line default
#line hidden
            EndContext();
            BeginContext(6024, 1198, true);
            WriteLiteral(@"
                                            <span class=""small "">candidats</span>
                                        </div>
                                    </div>
                                    <div class=""col-auto"">
                                        <i class=""fas fa-industry fa-2x text-gray-400""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- GPMC -->
                    <div class=""col-lg-6 col-sm-10 offset-md-1 offset-lg-0 mt-2"">
                        <div class=""card border-left-secondary border-bottom-secondary shadow h-100 py-2"">
                            <div class=""card-body pt-3"">
                                <div class=""row no-gutters align-items-center"">
                                    <div class=""col mr-2"">
                                        <div class=""text-xs font-weight-bold text-seconda");
            WriteLiteral("ry text-uppercase mb-2\">GPMC</div>\r\n                                        <div class=\"h5 mb-0 font-weight-bold text-gray-800\">\r\n                                            ");
            EndContext();
            BeginContext(7223, 11, false);
#line 136 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                                       Write(Model.Gpmc3);

#line default
#line hidden
            EndContext();
            BeginContext(7234, 1253, true);
            WriteLiteral(@"
                                            <span class=""small "">candidats</span>
                                        </div>
                                    </div>
                                    <div class=""col-auto"">
                                        <i class=""fas fa-vials fa-2x text-gray-400""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </row>

            </div>
        </div>

        <!-- ###################################################  TOTAL INSCRITS 4 ###################################-->

        <div class=""col-lg-6"">
            <div class=""card shadow mb-4"">
                <!-- Card Header -->

                <div class=""card-header py-3 d-flex flex-row align-items-center"">
                    <i class=""fas fa-dice-four fa-2x text-primary mr-3 ""></i>
                    <h5 class=""m-0 font-weight-bol");
            WriteLiteral("d text-primary\">\r\n                        Total des Inscrits en 4ème Année\r\n                        <i class=\"fas fa-arrow-right mx-2\"></i>\r\n                        <span class=\"h4 font-weight-bold\">\r\n                            ");
            EndContext();
            BeginContext(8488, 14, false);
#line 164 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                       Write(Model.Inscrit4);

#line default
#line hidden
            EndContext();
            BeginContext(8502, 823, true);
            WriteLiteral(@"
                        </span>
                    </h5>
                </div>
                <!-- INFO -->
                <row class=""d-lg-inline-flex px-2"">
                    <div class=""col-lg-6 col-sm-10 offset-md-1 offset-lg-0 mt-4 "">
                        <div class=""card border-left-danger border-bottom-danger shadow h-100 py-2"">
                            <div class=""card-body pt-3"">
                                <div class=""row no-gutters align-items-center"">
                                    <div class=""col mr-2"">
                                        <div class=""text-xs font-weight-bold text-danger text-uppercase mb-2"">Informatique</div>
                                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">
                                            ");
            EndContext();
            BeginContext(9326, 11, false);
#line 177 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                                       Write(Model.Info4);

#line default
#line hidden
            EndContext();
            BeginContext(9337, 1193, true);
            WriteLiteral(@"
                                            <span class=""small "">candidats</span>
                                        </div>
                                    </div>
                                    <div class=""col-auto"">
                                        <i class=""fas fa-laptop-code fa-2x text-gray-400""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- GTR -->
                    <div class=""col-lg-6 col-sm-10 offset-md-1 offset-lg-0 mt-4"">
                        <div class=""card border-left-warning border-bottom-warning shadow h-100 py-2"">
                            <div class=""card-body pt-3"">
                                <div class=""row no-gutters align-items-center"">
                                    <div class=""col mr-2"">
                                        <div class=""text-xs font-weight-bold text-warning t");
            WriteLiteral("ext-uppercase mb-2\">GTR</div>\r\n                                        <div class=\"h5 mb-0 font-weight-bold text-gray-800\">\r\n                                            ");
            EndContext();
            BeginContext(10531, 10, false);
#line 196 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                                       Write(Model.Gtr4);

#line default
#line hidden
            EndContext();
            BeginContext(10541, 1282, true);
            WriteLiteral(@"
                                            <span class=""small "">candidats</span>
                                        </div>
                                    </div>
                                    <div class=""col-auto"">
                                        <i class=""fas fa-network-wired fa-2x text-gray-400""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </row>
                <!-- INDUS -->
                <row class=""d-lg-inline-flex mb-4 px-2"">
                    <div class=""col-lg-6 col-sm-10 offset-md-1 offset-lg-0 mt-2"">
                        <div class=""card border-left-success border-bottom-success shadow h-100 py-2"">
                            <div class=""card-body pt-3"">
                                <div class=""row no-gutters align-items-center"">
                                    <div class=""col mr-2"">
         ");
            WriteLiteral(@"                               <div class=""text-xs font-weight-bold text-success text-uppercase mb-2"">Industriel</div>
                                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">
                                            ");
            EndContext();
            BeginContext(11824, 12, false);
#line 217 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                                       Write(Model.Indus4);

#line default
#line hidden
            EndContext();
            BeginContext(11836, 1198, true);
            WriteLiteral(@"
                                            <span class=""small "">candidats</span>
                                        </div>
                                    </div>
                                    <div class=""col-auto"">
                                        <i class=""fas fa-industry fa-2x text-gray-400""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- GPMC -->
                    <div class=""col-lg-6 col-sm-10 offset-md-1 offset-lg-0 mt-2"">
                        <div class=""card border-left-secondary border-bottom-secondary shadow h-100 py-2"">
                            <div class=""card-body pt-3"">
                                <div class=""row no-gutters align-items-center"">
                                    <div class=""col mr-2"">
                                        <div class=""text-xs font-weight-bold text-seconda");
            WriteLiteral("ry text-uppercase mb-2\">GPMC</div>\r\n                                        <div class=\"h5 mb-0 font-weight-bold text-gray-800\">\r\n                                            ");
            EndContext();
            BeginContext(13035, 11, false);
#line 236 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                                       Write(Model.Gpmc4);

#line default
#line hidden
            EndContext();
            BeginContext(13046, 1286, true);
            WriteLiteral(@"
                                            <span class=""small "">candidats</span>
                                        </div>
                                    </div>
                                    <div class=""col-auto"">
                                        <i class=""fas fa-vials fa-2x text-gray-400""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </row>

            </div>
        </div>


    </div>



    <!-- ###################################################  TOTAL SUPPRIMES  ###################################-->
    <div class=""row"">
        <div class=""col-lg-6 offset-lg-3 "">
            <div class=""card shadow mb-4"">
                <!-- Card Header -->
                <div class=""card-header py-3 d-flex flex-row align-items-center"">
                    <i class=""fas fa-trash-alt fa-2x text-danger mr-3 ""></i>
   ");
            WriteLiteral(@"                 <h5 class=""m-0 font-weight-bold text-danger"">
                        Total des Supprimés
                        <i class=""fas fa-arrow-right mx-2""></i>
                        <span class=""h4 font-weight-bold"">
                            ");
            EndContext();
            BeginContext(14333, 12, false);
#line 268 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                       Write(Model.Suprim);

#line default
#line hidden
            EndContext();
            BeginContext(14345, 795, true);
            WriteLiteral(@"
                        </span>
                    </h5>
                </div>
                <!-- 3e annee -->
                <row class=""d-lg-inline-flex"">
                    <div class=""col-10 offset-1 mt-4"">
                        <div class=""card border-left-success border-bottom-success shadow h-100 py-2"">
                            <div class=""card-body pt-3"">
                                <div class=""row no-gutters align-items-center"">
                                    <div class=""col mr-2"">
                                        <div class=""text-xs font-weight-bold text-success text-uppercase mb-2"">3ème Année</div>
                                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">
                                            ");
            EndContext();
            BeginContext(15141, 13, false);
#line 281 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                                       Write(Model.Suprim3);

#line default
#line hidden
            EndContext();
            BeginContext(15154, 1259, true);
            WriteLiteral(@"
                                            <span class=""small "">candidats</span>
                                        </div>
                                    </div>
                                    <div class=""col-auto"">
                                        <i class=""fas fa-dice-three fa-2x text-gray-400""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                </row>
                <row class=""mb-4"">
                    <!-- 4e annee -->
                    <div class=""col-10 offset-1 mt-2"">
                        <div class=""card border-left-warning border-bottom-warning shadow h-100 py-2"">
                            <div class=""card-body pt-3"">
                                <div class=""row no-gutters align-items-center"">
                                    <div class=""col mr-2"">
                                ");
            WriteLiteral("        <div class=\"text-xs font-weight-bold text-warning text-uppercase mb-2\">4ème Année</div>\r\n                                        <div class=\"h5 mb-0 font-weight-bold text-gray-800\">\r\n                                            ");
            EndContext();
            BeginContext(16414, 13, false);
#line 303 "D:\2emeGI-S2\DotNet\Projet3\V3\GestionConcoursCore\GestionConcoursCore\Views\Admin\Index.cshtml"
                                       Write(Model.Suprim4);

#line default
#line hidden
            EndContext();
            BeginContext(16427, 621, true);
            WriteLiteral(@"
                                            <span class=""small "">candidats</span>
                                        </div>
                                    </div>
                                    <div class=""col-auto"">
                                        <i class=""fas fa-dice-four fa-2x text-gray-400""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </row>

            </div>
        </div>


    </div>



</div>

</div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionConcoursCore.Models.IndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
