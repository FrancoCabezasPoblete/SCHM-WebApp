#pragma checksum "/home/orig3n/Escritorio/inf236-2021-2-grupo-11-p-002/Views/Home/Buscador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86abbd49af555593c750e2a76e68cec3fc72c780"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Buscador), @"mvc.1.0.view", @"/Views/Home/Buscador.cshtml")]
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
#line 1 "/home/orig3n/Escritorio/inf236-2021-2-grupo-11-p-002/Views/_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/orig3n/Escritorio/inf236-2021-2-grupo-11-p-002/Views/_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86abbd49af555593c750e2a76e68cec3fc72c780", @"/Views/Home/Buscador.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Buscador : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/planner.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mx-auto d-flex flex-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/home/orig3n/Escritorio/inf236-2021-2-grupo-11-p-002/Views/Home/Buscador.cshtml"
  
    ViewData["Title"] = "Buscador";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "86abbd49af555593c750e2a76e68cec3fc72c7804573", async() => {
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
            WriteLiteral("\n\n<div class=\"row top\">\n    <div class=\"col text-center\">\n        <h2>Buscador</h2>\n    </div>\n</div>\n\n\n\n<div class=\"container-fluid mt-3\">\n\n    <div class=\"row\">\n        <div class=\"col-7\">\n            <div class=\"row mt-2\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86abbd49af555593c750e2a76e68cec3fc72c7805930", async() => {
                WriteLiteral(@"
            <input class=""form-control my-2 my-sm-0 mr-sm-2 flex-1"" type=""search"" placeholder=""Buscar"" aria-label=""Search"">
                <button class=""btn btn-outline-secondary my-2 my-sm-0 mr-sm-2 buttonGray"" type=""submit""><i class=""fas fa-search""></i></button>
            <div class=""dropdown my-2 my-sm-0"">
                <button class=""btn btn-outline-secondary dropdown-toggle buttonGray"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <i class=""fas fa-filter""></i> Filtro
                </button>
                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownMenuButton"">
                    <a class=""dropdown-item"" href=""#"">Action</a>
                    <a class=""dropdown-item"" href=""#"">Another action</a>
                    <a class=""dropdown-item"" href=""#"">Something else here</a>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
            <h3 class=""my-3"">Resultados</h3>
            <div class=""row mb-3"">
                <div class=""col"">
                    <div class=""card text-left"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Historiografía musical chilena, una aproximación</h5>
                            <p class=""card-text scroll-text"">El presente escrito se deriva de un reciente proyecto de investigación en torno a la historiografía de la música chilena.[1] Nos habíamos propuesto caracterizar y comprender el relato historiográfico sobre música de todo tipo en Chile, a través del análisis de libros publicados,[2] por lo que, durante dos años, nos abocamos a la ubicación de ese material, a su evaluación y a la elaboración de criterios que permitieron la constitución final del universo de estudio.[3] El solo acto de comunicar tales contenidos de manera pública, estimábamos, podría revelar implícitamente al menos tres cuestiones fundamentales: una conceptualizac");
            WriteLiteral(@"ión de lo musical (que discrimina y distingue), cierta teoría cultural (que fundamenta la operación previa) y algún concepto de sociedad (a la que pretende contribuir). El acto de enunciación podría, además, remitir a otros dos aspectos, como son la ideología del autor y el contexto de producción que habría condicionado su aporte. En su conjunto esta producción configuraría un ejercicio </p>
                            <div class=""ml-1 row"">
                                <a href=""http://resonancias.uc.cl/es/N%C2%BA-38/historiografia-musical-chilena-una-aproximacion-2.html"" class=""btn btn-blue my-2 my-sm-0 mr-sm-2""><i class=""fas fa-link""></i> Enlace</a>
                                <a href=""#"" class=""btn btn-green my-2 my-sm-0 mr-sm-2""><i class=""fas fa-plus""></i> Agregar a expediente</a>
                            </div>
                        </div>
                        <div class=""card-footer text-muted"">
                            http://resonancias.uc.cl/es/N%C2%BA-38/historiografia-musical-chil");
            WriteLiteral(@"ena-una-aproximacion-2.html
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row mb-3"">
                <div class=""col"">
                    <div class=""card text-left"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Stock, Freddy. Corazones Rojos. Biografía no autorizada de ""Los Prisioneros""</h5>
                            <p class=""card-text scroll-text""> - </p>
                            <div class=""ml-1 row"">
                                <a href=""http://resonancias.uc.cl/es/N%C2%BA-38/historiografia-musical-chilena-una-aproximacion-2.html"" class=""btn btn-blue my-2 my-sm-0 mr-sm-2""><i class=""fas fa-link""></i> Enlace</a>
                                <a href=""#"" class=""btn btn-green my-2 my-sm-0 mr-sm-2""><i class=""fas fa-plus""></i> Agregar a expediente</a>
                            </div>
                        </div>
                        <div class=""card-footer text-m");
            WriteLiteral(@"uted"">
                            http://resonancias.uc.cl/es/N%C2%BA-38/historiografia-musical-chilena-una-aproximacion-2.html
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row mb-3"">
                <div class=""col"">
                    <div class=""card text-left"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">La dictadura y la música popular en Chile: los primeros años de plomo</h5>
                            <p class=""card-text scroll-text""> Resumen
                            Este estudio contempla el impacto del régimen represivo de Augusto Pinochet (1973-1990) sobre los artistas y la vida cultural en Chile, particularmente sobre los músicos que formaron parte del movimiento de la Nueva Canción Chilena (NCCh), en los primeros años de la dictadura (1973-1977), usando el instrumento analítico de la microhistoria. Examina también, de manera comparativa, la expresión cultural ");
            WriteLiteral(@"llamada Canto Nuevo, que surgió después del golpe de Estado. Este trabajo considera la vida cotidiana expresada en la microhistoria como un reflejo de los cambios ideológicos y estructurales que hizo la dictadura en un esfuerzo por borrar la historia reciente de la Unidad Popular (UP) y los sueños de las clases populares de Chile. </p>
                            <div class=""ml-1 row"">
                                <a href=""http://resonancias.uc.cl/es/N%C2%BA-45/la-dictadura-y-la-musica-popular-en-chile-los-primeros-anos-de-plomo.html"" class=""btn btn-blue my-2 my-sm-0 mr-sm-2""><i class=""fas fa-link""></i> Enlace</a>
                                <a href=""#"" class=""btn btn-green my-2 my-sm-0 mr-sm-2""><i class=""fas fa-plus""></i> Agregar a expediente</a>
                            </div>
                        </div>
                        <div class=""card-footer text-muted"">
                            http://resonancias.uc.cl/es/N%C2%BA-45/la-dictadura-y-la-musica-popular-en-chile-los-primeros-anos-de-pl");
            WriteLiteral(@"omo.html
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-5""><h3 class=""text-right mb-3"">Expedientes</h3>
            <div class=""row mb-2"">
                <div class=""col"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">¿Está siendo Jorge Gonzalez bien?</h5>
                            <h6 class=""card-subtitle mb-2 text-muted"">Por Paulina Vega</h6>
                            <p class=""card-text"" maxlength=""10"">Desde que Jorge Gonzalez y la Fliquiteada salen juntos, Jorge ha hecho una cantidad alarmante de distintos posts en instagram.</p>
                            <a href=""#"" class=""card-link"">Descargar <i class=""fa fa-download""></i></a>
                            <a href=""#"" class=""card-link"">Eliminar <i class=""fas fa-trash-alt""></i></a>
                            <a href=""#"" class=""card-link"">Fuente <i class=""fas fa-link"">");
            WriteLiteral(@"</i></a>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Card title</h5>
                            <h6 class=""card-subtitle mb-2 text-muted"">Card subtitle</h6>
                            <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <a href=""#"" class=""card-link"">Descargar <i class=""fa fa-download""></i></a>
                            <a href=""#"" class=""card-link"">Eliminar <i class=""fas fa-trash-alt""></i></a>
                            <a href=""#"" class=""card-link"">Fuente <i class=""fas fa-link""></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
