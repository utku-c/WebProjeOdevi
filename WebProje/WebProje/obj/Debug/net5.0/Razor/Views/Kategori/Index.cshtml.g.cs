#pragma checksum "C:\Users\utkub\source\repos\WebProje\WebProje\Views\Kategori\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7705110f267fb5aeb66fb25500e1b128b5744c04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kategori_Index), @"mvc.1.0.view", @"/Views/Kategori/Index.cshtml")]
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
#line 1 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7705110f267fb5aeb66fb25500e1b128b5744c04", @"/Views/Kategori/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d42a14c21bd296542f3e0008809d9d79bb0784", @"/Views/_ViewImports.cshtml")]
    public class Views_Kategori_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebProje.Models.Kategori>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""sidebar"">
    <div class=""row"">
        <div class=""col-lg-10"">
            <div class=""sidebar-item recent-posts"">
                <div class=""sidebar-heading"">
                    <h2>SON GÖNDERİLER</h2>
                </div>
                <div class=""content"">
                    <ul>
                        <li>
                            <a href=""post-details.html"">
                                <h5>Vestibulum id turpis porttitor sapien facilisis scelerisque</h5>
                                <span>May 31, 2020</span>
                            </a>
                        </li>
                        <li>
                            <a href=""post-details.html"">
                                <h5>Suspendisse et metus nec libero ultrices varius eget in risus</h5>
                                <span>May 28, 2020</span>
                            </a>
                        </li>
                        <li>
                            <a href=""post-detai");
            WriteLiteral(@"ls.html"">
                                <h5>Swag hella echo park leggings, shaman cornhole ethical coloring</h5>
                                <span>May 14, 2020</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""col-lg-10"">
            <div class=""sidebar-item categories"">
                <div class=""sidebar-heading"">
                    <h2>KATEGORİ</h2>
                </div>
                ");
#nullable restore
#line 40 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\Kategori\Index.cshtml"
           Write(await Html.PartialAsync("_Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <div class=""col-lg-10"">
            <div class=""sidebar-item tags"">
                <div class=""sidebar-heading"">
                    <h2>Tag Clouds</h2>
                </div>
                <div class=""content"">
                    <ul>
                        <li><a href=""#"">Lifestyle</a></li>
                        <li><a href=""#"">Creative</a></li>
                        <li><a href=""#"">HTML5</a></li>
                        <li><a href=""#"">Inspiration</a></li>
                        <li><a href=""#"">Motivation</a></li>
                        <li><a href=""#"">PSD</a></li>
                        <li><a href=""#"">Responsive</a></li>
                    </ul>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebProje.Models.Kategori>> Html { get; private set; }
    }
}
#pragma warning restore 1591
