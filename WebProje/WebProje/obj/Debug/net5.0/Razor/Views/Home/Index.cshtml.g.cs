#pragma checksum "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12c75c682e68dd8fd112bcf2730834d47fd178f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c75c682e68dd8fd112bcf2730834d47fd178f0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d42a14c21bd296542f3e0008809d9d79bb0784", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AnaSayfa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"/lib/bootstrap/dist/assets/css/sty.css\">\r\n\r\n");
            DefineSection("MessageBox", async() => {
                WriteLiteral("\r\n    <div class=\"alert alert-success text-center m-3\">\r\n        Bana utkubilgin47@gmail adresinden ulaşabilirsiniz\r\n    </div>\r\n");
            }
            );
            WriteLiteral(@"



<section class=""call-to-action"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""main-content"">
                    <div class=""row"">
                        <div class=""col-lg-8"">
                            <h4>");
#nullable restore
#line 21 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                           Write(localizer["BenKimim"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
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
<div class=""section layout_padding"">
    <div class=""container"">

        <div class=""row"">
            <div class=""col-md-6"">
                <img src=""/lib/bootstrap/dist/images/antakya.gif"" alt=""#"" />
            </div>
            <div class=""col-md-6 center"">
                <div class=""full blog_cont"">
                    <h4>");
#nullable restore
#line 43 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                   Write(localizer["Antakya"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h5>MAY 16 2021 5 READ</h5>\r\n                    <p>");
#nullable restore
#line 45 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                  Write(localizer["Benp4"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                    <p>");
#nullable restore
#line 46 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                  Write(localizer["Benp5"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                    <p>");
#nullable restore
#line 47 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                  Write(localizer["Benp6"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@".</p>

                </div>
            </div>
        </div>
        <div class=""row margin_top_30"">
            <div class=""col-md-6 center"">
                <img src=""/lib/bootstrap/dist/images/utku.jpg"" alt=""#"" />
            </div>
            <div class=""col-md-6"">
                <div class=""full blog_cont"">
                    <h4>");
#nullable restore
#line 58 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                   Write(localizer["Ben"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h5>MAY 19 2019  5 READ</h5>\r\n                    <p>");
#nullable restore
#line 60 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                  Write(localizer["Benp1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                    <p>");
#nullable restore
#line 61 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                  Write(localizer["Benp2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                    <p>");
#nullable restore
#line 62 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                  Write(localizer["Benp3"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                    <a href=\"#\"><p>https://github.com/utku-c ");
#nullable restore
#line 63 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                                                        Write(localizer["Benp7"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p></a>
                </div>
            </div>
        </div>
        <div class=""row margin_top_30"">
            <div class=""col-md-6 center"">
                <img src=""/lib/bootstrap/dist/images/kunefegif.jpg"" alt=""#"" />
            </div>
            <div class=""col-md-6"">
                <div class=""full blog_cont"">
                    <h4>");
#nullable restore
#line 73 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                   Write(localizer["Benp8"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h5>MAY 14 2019 5 READ</h5>\r\n                    <p>");
#nullable restore
#line 75 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                  Write(localizer["Benp9"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
        <div class=""row margin_top_30"">
            <div class=""col-md-6"">
                <img src=""/lib/bootstrap/dist/images/favoriyemek.png"" alt=""#"" />
            </div>
            <div class=""col-md-6"">
                <div class=""full blog_cont"">
                    <h4>");
#nullable restore
#line 85 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                   Write(localizer["Benp10"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h5>MAY 19 2019  5 READ</h5>\r\n                    <p>");
#nullable restore
#line 87 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                  Write(localizer["Benp11"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                    <p>Herkese tavsiye ederim.</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-lg-12 container p-5\">\r\n            <div class=\"main-button\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12c75c682e68dd8fd112bcf2730834d47fd178f011527", async() => {
#nullable restore
#line 95 "C:\Users\utkub\source\repos\GitHub\WebProje\WebProje\Views\Home\Index.cshtml"
                                                               Write(localizer["Benp12"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
</div>
<!-- end section -->

<section class=""blog-posts grid-system"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-2"">

            </div>
            <div class=""col-lg-8"">
                <div class=""all-blog-posts"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""blog-post"">
                                <div class=""blog-thumb"">
                                    <img src=""/lib/bootstrap/dist/assets/images/""");
            BeginWriteAttribute("alt", " alt=\"", 4006, "\"", 4012, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""down-content"">
                                    <span>Lifestyle</span>
                                    <a href=""post-details.html""><h4>Aenean pulvinar gravida sem nec</h4></a>
                                    <ul class=""post-info"">
                                        <li><a href=""#"">Admin</a></li>
                                        <li><a href=""#"">May 12, 2020</a></li>
                                        <li><a href=""#"">10 Comments</a></li>
                                    </ul>
                                    <p>
                                    <p>UTKU</p>
                                    <br><br>Donec tincidunt leo nec magna gravida varius. Suspendisse felis orci, egestas ac sodales quis, venenatis et neque. Vivamus facilisis dignissim arcu et blandit. Maecenas finibus dui non pulvinar lacinia. Ut lacinia finibus lorem vel porttitor. Suspendisse et metus nec libero ultrices v");
            WriteLiteral(@"arius eget in risus. Cras id nibh at erat pulvinar malesuada et non ipsum. Suspendisse id ipsum leo.

                                    <div class=""post-options"">
                                        <div class=""row"">
                                            <div class=""col-6"">
                                                <ul class=""post-tags"">
                                                    <li><i class=""fa fa-tags""></i></li>
                                                    <li><a href=""#"">Best Templates</a>,</li>
                                                    <li><a href=""#"">TemplateMo</a></li>
                                                </ul>
                                            </div>
                                            <div class=""col-6"">
                                                <ul class=""post-share"">
                                                    <li><i class=""fa fa-share-alt""></i></li>
                                                 ");
            WriteLiteral(@"   <li><a href=""#"">Facebook</a>,</li>
                                                    <li><a href=""#""> Twitter</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-12"">
                            <div class=""sidebar-item comments"">
                                <div class=""sidebar-heading"">
                                    <h2>Benimle ilgili ne düşünüyorsun? ☻</h2>
                                    <h2>4 comments</h2>
                                </div>
                                <div class=""content"">
                                    <ul>
                                        <li>
                                            <div class=""author-thumb"">
                      ");
            WriteLiteral("                          <img src=\"/lib/bootstrap/dist/assets/images/comment-author-01.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 7177, "\"", 7183, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                            <div class=""right-content"">
                                                <h4>Charles Kate<span>May 16, 2020</span></h4>
                                                <p>Fusce ornare mollis eros. Duis et diam vitae justo fringilla condimentum eu quis leo. Vestibulum id turpis porttitor sapien facilisis scelerisque. Curabitur a nisl eu lacus convallis eleifend posuere id tellus.</p>
                                            </div>
                                        </li>
                                        <li class=""replied"">
                                            <div class=""author-thumb"">
                                                <img src=""/lib/bootstrap/dist/assets/images/comment-author-02.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8022, "\"", 8028, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                            <div class=""right-content"">
                                                <h4>Thirteen Man<span>May 20, 2020</span></h4>
                                                <p>In porta urna sed venenatis sollicitudin. Praesent urna sem, pulvinar vel mattis eget.</p>
                                            </div>
                                        </li>
                                        <li>
                                            <div class=""author-thumb"">
                                                <img src=""/lib/bootstrap/dist/assets/images/comment-author-03.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8727, "\"", 8733, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                            <div class=""right-content"">
                                                <h4>Belisimo Mama<span>May 16, 2020</span></h4>
                                                <p>Nullam nec pharetra nibh. Cras tortor nulla, faucibus id tincidunt in, ultrices eget ligula. Sed vitae suscipit ligula. Vestibulum id turpis volutpat, lobortis turpis ac, molestie nibh.</p>
                                            </div>
                                        </li>
                                        <li class=""replied"">
                                            <div class=""author-thumb"">
                                                <img src=""/lib/bootstrap/dist/assets/images/comment-author-02.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9548, "\"", 9554, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                            <div class=""right-content"">
                                                <h4>Thirteen Man<span>May 22, 2020</span></h4>
                                                <p>Mauris sit amet justo vulputate, cursus massa congue, vestibulum odio. Aenean elit nunc, gravida in erat sit amet, feugiat viverra leo.</p>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-12"">
                            <div class=""sidebar-item submit-comment"">
                                <div class=""sidebar-heading"">
                                    <h2>Your comment</h2>
                                </div>
                                <div class=""content"">
                     ");
            WriteLiteral("               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12c75c682e68dd8fd112bcf2730834d47fd178f021171", async() => {
                WriteLiteral(@"
                                        <div class=""row"">
                                            <div class=""col-md-6 col-sm-12"">
                                                <fieldset>
                                                    <input name=""name"" type=""text"" id=""name"" placeholder=""Your name""");
                BeginWriteAttribute("required", " required=\"", 10953, "\"", 10964, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                </fieldset>
                                            </div>
                                            <div class=""col-md-6 col-sm-12"">
                                                <fieldset>
                                                    <input name=""email"" type=""text"" id=""email"" placeholder=""Your email""");
                BeginWriteAttribute("required", " required=\"", 11338, "\"", 11349, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                </fieldset>
                                            </div>
                                            <div class=""col-md-12 col-sm-12"">
                                                <fieldset>
                                                    <input name=""subject"" type=""text"" id=""subject"" placeholder=""Subject"">
                                                </fieldset>
                                            </div>
                                            <div class=""col-lg-12"">
                                                <fieldset>
                                                    <textarea name=""message"" rows=""6"" id=""message"" placeholder=""Type your comment""");
                BeginWriteAttribute("required", " required=\"", 12100, "\"", 12111, 0);
                EndWriteAttribute();
                WriteLiteral(@"></textarea>
                                                </fieldset>
                                            </div>
                                            <div class=""col-lg-12"">
                                                <fieldset>
                                                    <button type=""submit"" id=""form-submit"" class=""main-button"">Submit</button>
                                                </fieldset>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
                    </div>
                </div>
            </div>
            <div class=""col-lg-2"">


            </div>
        </div>
    </div>
</section>
<br />

<div class=""container-fuild hidden-sm hidden-xs"">
    <div style=""border-bottom: 1px solid #F3F3F3;"">
        <div class=""header-campaign"">
            <marquee behavior=""scroll"" direction=""left"" onmouseover=""this.stop();"" onmouseout=""this.start();"" scrollamount=""13"">
                <p>
                    <a href=""#"">
                        ♦ Yorum yapmak için giriş yapın ♦
                    </a>
                    &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
                    &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
                    <a href=""#"">
                        ♦ Yorum y");
            WriteLiteral("apmak için giriş yapın ♦\r\n                    </a>\r\n                </p>\r\n            </marquee>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
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
