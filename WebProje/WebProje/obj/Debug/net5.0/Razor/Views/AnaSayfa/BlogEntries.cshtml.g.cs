#pragma checksum "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b92c739ab1099d485fda5ad7093a65f33e07b8a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnaSayfa_BlogEntries), @"mvc.1.0.view", @"/Views/AnaSayfa/BlogEntries.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92c739ab1099d485fda5ad7093a65f33e07b8a7", @"/Views/AnaSayfa/BlogEntries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d42a14c21bd296542f3e0008809d9d79bb0784", @"/Views/_ViewImports.cshtml")]
    public class Views_AnaSayfa_BlogEntries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebProje.Models.Content>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"


<link rel=""stylesheet"" href=""/lib/bootstrap/dist/assets/css/sty.css"">

<!-- Şehrim -->
<section class=""call-to-action"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""main-content"">
                    <div class=""row"">
                        <div class=""col-lg-8"">
                            <h4>ŞEHRİMM</h4>
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


<!-- İÇERİKK -->
<section class=""blog-posts pt-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""all-blog-posts container"">
                    <div class=""row"">
                        <div class=""col-lg-12 container p-2"">
");
#nullable restore
#line 42 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"blog-post\">\r\n                                    <div class=\"blog-thumb\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1370, "\"", 1399, 1);
#nullable restore
#line 46 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml"
WriteAttributeValue("", 1376, item.ContentResimUrl, 1376, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1400, "\"", 1406, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"down-content\">\r\n                                        <span>");
#nullable restore
#line 49 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml"
                                         Write(item.KonuBasligi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <a href=\"#\"><h4>");
#nullable restore
#line 50 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml"
                                                   Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4></a>
                                        <ul class=""post-info"">
                                            <li><a href=""/AnaSayfa/AboutMe"">Admin</a></li>
                                            <li><a href=""#"">May 31, 2020</a></li>
                                            <li><a href=""#yorum"">12 Comments</a></li>
                                        </ul>
                                        <br />
                                        <p>");
#nullable restore
#line 57 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml"
                                      Write(item.Icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <a rel=""nofollow"" href=""#"" target=""_parent"">Hatayda Nerde Yenir</a></p>
                                        <div class=""post-options"">
                                            <div class=""row"">
                                                <div class=""col-6"">
                                                    <ul class=""post-tags"">
                                                        <li><i class=""fa fa-tags""></i></li>
                                                        <li><a href=""#"">Hatay</a>,</li>
                                                        <li><a href=""#"">Antakya</a></li>
                                                    </ul>
                                                </div>
                                                <div class=""col-6"">
                                                    <ul class=""post-share"">
                                                        <li><i class=""fa fa-share-alt""></i></li>
                                           ");
            WriteLiteral(@"             <li><a href=""#"">Facebook</a>,</li>
                                                        <li><a href=""#""> Twitter</a></li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 78 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""list-group"">
                    <h2 class=""m-2"" style=""font-size:26px;font-weight:900;color:black;"">Son Yorumlar</h2>
                    <a href=""#"" class=""list-group-item list-group-item-action"" aria-current=""true"">
                        <div class=""d-flex w-100 justify-content-between"">
                            <h5 class=""mb-1"">List group item heading</h5>
                            <small>3 days ago</small>
                        </div>
                        <p class=""mb-1"">Some placeholder content in a paragraph.</p>
                        <small>Devamını oku</small>
                    </a>
                    <a href=""#"" class=""list-group-item list-group-item-action"">
                        <div class=""d-flex w-100 justify-content-between"">
                            <h5 class=""mb-1"">List group item heading</h5>
            WriteLiteral(@"
                            <small class=""text-muted"">3 days ago</small>
                        </div>
                        <p class=""mb-1"">Some placeholder content in a paragraph.</p>
                        <small class=""text-muted"">And some muted small print.</small>
                    </a>
                    <a href=""#"" class=""list-group-item list-group-item-action"">
                        <div class=""d-flex w-100 justify-content-between"">
                            <h5 class=""mb-1"">List group item heading</h5>
                            <small class=""text-muted"">3 days ago</small>
                        </div>
                        <p class=""mb-1"">Some placeholder content in a paragraph.</p>
                        <small class=""text-muted"">And some muted small print.</small>
                    </a>
                </div>
            </div>
        </div>
    </div>
</section>



<!-- Yorumlarr -->
<section class=""layout_padding"">
    <div class=""container"">
        ");
            WriteLiteral(@"<div class=""row"">
            <div class=""col-md-12"">
                <div id=""yorum"" class=""heading"" style=""padding-left: 15px;padding-right: 15px;"">
                    <h4 style=""border-bottom: solid #333 1px;"">Comments / 2</h4>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""full comment_blog_line"">
                    <div class=""row"">
                        <div class=""col-md-1"">
                            <img src=""/lib/bootstrap/dist/images/c_1.png"" alt=""#"" />
                        </div>
                        <div class=""col-md-9"">
                            <div class=""full contact_text"">
                                <h3>Veniam</h3>
                                <h4>Posted on Jan 10 / 2017 at 06:53 am</h4>
                                <p>
                                    Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidun");
            WriteLiteral("t ut laoreet\r\n                                    dolore magna aliquam erat volutpat.\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 145 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml"
                         if (ViewBag.admin == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-2\">\r\n                                <a class=\"reply_bt\" href=\"#\">Reply</a>\r\n                            </div>\r\n");
#nullable restore
#line 150 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
                <div class=""full comment_blog_line"">
                    <div class=""row "">
                        <div class=""col-md-1 "">

                        </div>
                        <div class=""col-md-1"" style=""border-left: 5px solid #cfa671;"">
                            <img src=""/lib/bootstrap/dist/images/c_1.png"" alt=""#"" />
                        </div>
                        <div class=""col-md-7"">
                            <div class=""full contact_text"">
                                <h3>Veniam</h3>
                                <h4>Posted on Jan 10 / 2017 at 06:53 am</h4>
                                <p>
                                    Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet
                                    dolore magna aliquam erat volutpat.
                                </p>
                            </div>
                       ");
            WriteLiteral(@" </div>
                        <div class=""col-md-3"">

                        </div>
                    </div>
                </div>
                <div class=""full comment_blog_line"">
                    <div class=""row"">
                        <div class=""col-md-1"">
                            <img src=""/lib/bootstrap/dist/images/c_2.png"" alt=""#"" />
                        </div>
                        <div class=""col-md-9"">
                            <div class=""full contact_text"">
                                <h3>Jack</h3>
                                <h4>Posted on Jan 10 / 2017 at 06:53 am</h4>
                                <p>
                                    Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet
                                    dolore magna aliquam erat volutpat.
                                </p>
                            </div>
                        </div>
                        <!");
            WriteLiteral("-- admin sayfasında olması lazım -->\r\n");
#nullable restore
#line 192 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml"
                         if (ViewBag.admin == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-2\">\r\n                                <a class=\"reply_bt\" href=\"#\">Reply</a>\r\n                            </div>\r\n");
#nullable restore
#line 197 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>

        <div class=""row margin_top_30"">
            <div class=""col-md-12 margin_top_30"">
                <div class=""heading"" style=""padding-left: 15px;padding-right: 15px;"">
                    <h4>Post : Your Comment</h4>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""full comment_form"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b92c739ab1099d485fda5ad7093a65f33e07b8a716396", async() => {
                WriteLiteral(@"
                        <fieldset>
                            <div class=""col-md-12"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <input type=""text"" name=""name"" placeholder=""Name"" required=""#"" />
                                        <input type=""email"" name=""email"" placeholder=""Email"" required=""#"" />
                                    </div>
                                    <div class=""col-md-6"">
                                        <textarea placeholder=""Comment""></textarea>
                                    </div>
                                </div>
");
#nullable restore
#line 225 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml"
                                 if (ViewBag.Yorum == 1)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <div class=""row margin_top_30"">
                                        <div class=""col-md-12"">
                                            <div class=""center"">
                                                <button>Send</button>
                                            </div>
                                        </div>
                                    </div>
");
#nullable restore
#line 234 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <div class=""row margin_top_30"">
                                        <div class=""col-md-12"">
                                            <div class=""center"">
                                                <button disabled>Send</button>
                                            </div>
                                            <br />
                                            <a href=""/AnaSayfa/Login""><p class=""center"" style=""color:red;"">Yorum yapabilmek için giriş yapınız</p></a>
                                        </div>
                                    </div>
");
#nullable restore
#line 247 "C:\Users\utkub\source\repos\WebProje\WebProje\Views\AnaSayfa\BlogEntries.cshtml"

                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                        </fieldset>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n\r\n\r\n");
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