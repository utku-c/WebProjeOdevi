#pragma checksum "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a9ee669d2aaea27f464eb7c48cf96baa5fe0e31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnaSayfa_Index), @"mvc.1.0.view", @"/Views/AnaSayfa/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a9ee669d2aaea27f464eb7c48cf96baa5fe0e31", @"/Views/AnaSayfa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d42a14c21bd296542f3e0008809d9d79bb0784", @"/Views/_ViewImports.cshtml")]
    public class Views_AnaSayfa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebProje.Models.Content>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AnaSayfa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogEntries", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:mediumblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"
  
    List<Kategori> categories = (List<Kategori>)ViewData["categories"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<link rel=\"stylesheet\" href=\"/lib/bootstrap/dist/assets/css/sty.css\">\r\n\r\n");
            DefineSection("MessageBox", async() => {
                WriteLiteral("\r\n    <div class=\"alert alert-success text-center m-3\">\r\n        Açken sen sen değilsin haydi bir bilet al Hatay\'a\r\n    </div>\r\n");
            }
            );
            WriteLiteral(@"
<!-- ŞEHRİM YAZISI-->
<section class=""call-to-action"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""main-content"">
                    <div class=""row"">
                        <div class=""col-lg-8"">
                            <h4>ŞEHRİM </h4>
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""main-button"">

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<style>
    .devamınıoku a:hover {
        background-color: lightgrey;
        font-size: 15px;
        font-weight: 700;
        border-radius: 8px 8px 8px 8px;
        padding: 8px;
        margin: -7px 0px
    }
</style>

<section class=""blog-posts grid-system"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
     ");
            WriteLiteral(@"           <div class=""sidebar"">
                    <div class=""row"">
                        <div class=""col-lg-10"">
                            <div class=""sidebar-item categories"">
                                <div class=""sidebar-heading"">
                                    <h2>KATEGORİLER</h2>
                                </div>

                                <ul>


");
#nullable restore
#line 67 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"
                                     foreach (var item in categories)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1987, "\"", 2018, 2);
            WriteAttributeValue("", 1994, "/AnaSayfa/Index/", 1994, 16, true);
#nullable restore
#line 69 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"
WriteAttributeValue("", 2010, item.Id, 2010, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 69 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"
                                                                          Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 70 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </ul>
                            </div>
                        </div>
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
      ");
            WriteLiteral(@"                                          <h5>Suspendisse et metus nec libero ultrices varius eget in risus</h5>
                                                <span>May 28, 2020</span>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""post-details.html"">
                                                <h5>Swag hella echo park leggings, shaman cornhole ethical coloring</h5>
                                                <span>May 14, 2020</span>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>


                        <div class=""col-lg-10"">
                            <div class=""sidebar-item tags"">
                                <div class=""sidebar-heading");
            WriteLiteral(@""">
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
");
            WriteLiteral("                    </div>\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"col-lg-8\">\r\n                <div class=\"all-blog-posts\">\r\n                    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 133 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"
                         if (Model.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-lg-10  text-center"" style=""background-color:red; font-weight:bold; color:white; border-radius:8px;font-size:20px; padding:20px"">
                                Bu Kategoride şuan için bir içerik yoktur
                            </div>
");
#nullable restore
#line 138 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"

                        }
                        else
                        {
                            foreach (var item in Model)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-lg-6\">\r\n                                    <div class=\"blog-post\">\r\n                                        <div class=\"blog-thumb\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 6044, "\"", 6071, 1);
#nullable restore
#line 148 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"
WriteAttributeValue("", 6050, item.ContentResimUrl, 6050, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6072, "\"", 6078, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                        </div>\r\n                                        <div class=\"down-content\">\r\n                                            <span>");
#nullable restore
#line 152 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"
                                             Write(item.KonuBasligi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a9ee669d2aaea27f464eb7c48cf96baa5fe0e3113186", async() => {
                WriteLiteral("<h4>Detaylar için tıkla</h4>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 153 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"
                                                                                                    WriteLiteral(item.Id);

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
            WriteLiteral(@"
                                            <ul class=""post-info"">
                                                <li><a href=""/Anasayfa/AboutMe"">Admin</a></li>
                                                <li><a href=""#"">May 22, 2020</a></li>
                                                <!--Yoruma tıklandığında indexin hemen altındaki yorumlar seçeneğine gidecek-->
                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 6866, "\"", 6904, 3);
            WriteAttributeValue("", 6873, "/AnaSayfa/Index/", 6873, 16, true);
#nullable restore
#line 158 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"
WriteAttributeValue("", 6889, item.Id, 6889, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6897, "/#yorum", 6897, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">Comments</a></li>
                                            </ul>
                                            <div>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur adipiscing elit,sed do
                                                    eiusmod tempor incididunt ut labore et dolore magna aliqua.
                                                    Ut enim ad minim veniam, quis nostrud exercitation ullamco
                                                </p>

                                                <p class=""center devamınıoku"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a9ee669d2aaea27f464eb7c48cf96baa5fe0e3117269", async() => {
                WriteLiteral("Devamını oku");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 168 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"
                                                                                                                               WriteLiteral(item.Id);

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
            WriteLiteral(@"
                                                </p>
                                            </div>
                                            <div class=""post-options"">
                                                <div class=""row"">
                                                    <div class=""col-lg-12"">
                                                        <ul class=""post-tags"">
                                                            <li><i class=""fa fa-tags""></i></li>
                                                            <li><a href=""#"">");
#nullable restore
#line 176 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"
                                                                       Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
                                                        </ul>
                                                        <ul class=""post-tags"">
                                                            <li><i class=""fa fa-tags""></i></li>
                                                            <li><a href=""#"">Hatay-Antakya</a></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 188 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col-lg-2"">

            </div>
        </div>
        <div class=""col-lg-12"">
            <ul class=""page-numbers"">
                <li><a href=""#"">1</a></li>
                <li class=""active""><a href=""#"">2</a></li>
                <li><a href=""#"">3</a></li>
                <li><a href=""#""><i class=""fa fa-angle-double-right""></i></a></li>
            </ul>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebProje.Models.Content>> Html { get; private set; }
    }
}
#pragma warning restore 1591
