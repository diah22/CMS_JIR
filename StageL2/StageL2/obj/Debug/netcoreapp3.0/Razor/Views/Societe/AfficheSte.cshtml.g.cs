#pragma checksum "D:\stagiaire2020\StageL2\StageL2\Views\Societe\AfficheSte.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9bcd4e223fe11281a5d25bfff4ff0e9823c119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Societe_AfficheSte), @"mvc.1.0.view", @"/Views/Societe/AfficheSte.cshtml")]
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
#line 1 "D:\stagiaire2020\StageL2\StageL2\Views\_ViewImports.cshtml"
using StageL2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\stagiaire2020\StageL2\StageL2\Views\_ViewImports.cshtml"
using StageL2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\stagiaire2020\StageL2\StageL2\Views\Societe\AfficheSte.cshtml"
using StageL2.Views.Societe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\stagiaire2020\StageL2\StageL2\Views\Societe\AfficheSte.cshtml"
using Oracle.ManagedDataAccess.Client;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9bcd4e223fe11281a5d25bfff4ff0e9823c119", @"/Views/Societe/AfficheSte.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fae29495dd02049f7d9426ea7b04bf919d0dc7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Societe_AfficheSte : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Societe/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cmxform form-horizontal tasi-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Societe/ModifierSte"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\stagiaire2020\StageL2\StageL2\Views\Societe\AfficheSte.cshtml"
  
    ViewData["Title"] = "AfficheSte";
    FonctionSociete user4 = new FonctionSociete();
    var code = ViewBag.Message1;
    OracleDataReader sql = user4.GetSte(code);
    sql.Read();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container"">
        <div class=""col-sm-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"" id=""ajout""><h3 class=""panel-title"">Modifier une societe</h3></div>
                <div class=""panel-body"">
                    <div class="" form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f9bcd4e223fe11281a5d25bfff4ff0e9823c1195765", async() => {
                WriteLiteral(@"
                            <div class=""form-group "">
                                <label for=""date"" class=""control-label col-lg-2"">Date</label>
                                <div class=""col-lg-9"">
                                    <input class=""form-control "" name=""date"" type=""text"" placeholder=""mm/jj/aaaa""");
                BeginWriteAttribute("value", " value=\"", 1010, "\"", 1040, 1);
#nullable restore
#line 21 "D:\stagiaire2020\StageL2\StageL2\Views\Societe\AfficheSte.cshtml"
WriteAttributeValue("", 1018, sql.GetOracleValue(4), 1018, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                </div>
                            </div>
                            <div class=""form-group "">
                                <label for=""code"" class=""control-label col-lg-2"">Code société</label>
                                <div class=""col-lg-9"">
                                    <input class="" form-control"" name=""code"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1431, "\"", 1456, 1);
#nullable restore
#line 27 "D:\stagiaire2020\StageL2\StageL2\Views\Societe\AfficheSte.cshtml"
WriteAttributeValue("", 1439, sql.GetString(0), 1439, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 1457, "\"", 1468, 0);
                EndWriteAttribute();
                WriteLiteral(@" readonly>
                                </div>
                            </div>
                            <div class=""form-group "">
                                <label for=""nom"" class=""control-label col-lg-2"">Libelle</label>
                                <div class=""col-lg-9"">
                                    <input class="" form-control"" name=""lib"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1852, "\"", 1877, 1);
#nullable restore
#line 33 "D:\stagiaire2020\StageL2\StageL2\Views\Societe\AfficheSte.cshtml"
WriteAttributeValue("", 1860, sql.GetString(1), 1860, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 1878, "\"", 1889, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                            <div class=""form-group "">
                                <label for=""code_prest"" class=""control-label col-lg-2"">Type client</label>
                                <div class=""col-lg-9"">
                                    <input class=""form-control "" name=""type"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2276, "\"", 2301, 1);
#nullable restore
#line 39 "D:\stagiaire2020\StageL2\StageL2\Views\Societe\AfficheSte.cshtml"
WriteAttributeValue("", 2284, sql.GetString(2), 2284, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 2302, "\"", 2313, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                            <div class=""form-group "">
                                <label for=""date"" class=""control-label col-lg-2"">Adressse</label>
                                <div class=""col-lg-9"">
                                    <input class=""form-control "" name=""adr"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2690, "\"", 2720, 1);
#nullable restore
#line 45 "D:\stagiaire2020\StageL2\StageL2\Views\Societe\AfficheSte.cshtml"
WriteAttributeValue("", 2698, sql.GetOracleValue(3), 2698, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""User medecin"">
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""col-lg-offset-2 col-lg-10"">
                                    <input type=""submit"" value=""Enregistrer"" class=""btn btn-success "">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f9bcd4e223fe11281a5d25bfff4ff0e9823c11910558", async() => {
                    WriteLiteral("<input type=\"button\" value=\"Annuler\" class=\"btn btn-default waves-effect waves-lignt\">");
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
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div> <!-- form -->\r\n                </div> <!-- panel-body -->\r\n            </div> <!-- panel -->\r\n        </div> <!-- col -->\r\n    </div><!-- container ajout-->\r\n");
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
