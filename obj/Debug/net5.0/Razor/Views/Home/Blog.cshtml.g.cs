#pragma checksum "C:\Users\luisb\Desktop\RestauranteEtec\Views\Home\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e92c524db02b24fee82b8194ba8c80e2996fdb2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Blog), @"mvc.1.0.view", @"/Views/Home/Blog.cshtml")]
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
#line 1 "C:\Users\luisb\Desktop\RestauranteEtec\Views\_ViewImports.cshtml"
using RestauranteEtec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\luisb\Desktop\RestauranteEtec\Views\_ViewImports.cshtml"
using RestauranteEtec.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e92c524db02b24fee82b8194ba8c80e2996fdb2d", @"/Views/Home/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec6ffb7a6cb3ace4e99614baab6122d53ef1c87", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index.html", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\luisb\Desktop\RestauranteEtec\Views\Home\Blog.cshtml"
  
    ViewData["Title"] = "Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"hero-wrap hero-wrap-2\"");
            BeginWriteAttribute("style", " style=\"", 78, "\"", 143, 4);
            WriteAttributeValue("", 86, "background-image:", 86, 17, true);
            WriteAttributeValue(" ", 103, "url(", 104, 5, true);
#nullable restore
#line 4 "C:\Users\luisb\Desktop\RestauranteEtec\Views\Home\Blog.cshtml"
WriteAttributeValue("", 108, Url.Content("~/images/bg_5.jpg"), 108, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 141, ");", 141, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"
    data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-end justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center mb-5"">
                <h1 class=""mb-2 bread"">Blog</h1>
                <p class=""breadcrumbs""><span class=""mr-2"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e92c524db02b24fee82b8194ba8c80e2996fdb2d4495", async() => {
                WriteLiteral("Home <i\r\n                                class=\"fa fa-chevron-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</span> <span>Blog <i
                            class=""fa fa-chevron-right""></i></span></p>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-4 ftco-animate"">
                <div class=""blog-entry"">
                    <a href=""blog-single.html"" class=""block-20""");
            BeginWriteAttribute("style", " style=\"", 1026, "\"", 1094, 4);
            WriteAttributeValue("", 1034, "background-image:", 1034, 17, true);
            WriteAttributeValue(" ", 1051, "url(", 1052, 5, true);
#nullable restore
#line 24 "C:\Users\luisb\Desktop\RestauranteEtec\Views\Home\Blog.cshtml"
WriteAttributeValue("", 1056, Url.Content("~/images/image_1.jpg"), 1056, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1092, ");", 1092, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    </a>
                    <div class=""text px-4 pt-3 pb-4"">
                        <div class=""meta"">
                            <div><a href=""#"">August 3, 2020</a></div>
                            <div><a href=""#"">Admin</a></div>
                        </div>
                        <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind
                                texts</a></h3>
                        <p class=""clearfix"">
                            <a href=""#"" class=""float-left read btn btn-primary"">Read more</a>
                            <a href=""#"" class=""float-right meta-chat""><span class=""fa fa-comment""></span> 3</a>
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 ftco-animate"">
                <div class=""blog-entry"">
                    <a href=""blog-single.html"" class=""block-20""");
            BeginWriteAttribute("style", " style=\"", 2065, "\"", 2133, 4);
            WriteAttributeValue("", 2073, "background-image:", 2073, 17, true);
            WriteAttributeValue(" ", 2090, "url(", 2091, 5, true);
#nullable restore
#line 42 "C:\Users\luisb\Desktop\RestauranteEtec\Views\Home\Blog.cshtml"
WriteAttributeValue("", 2095, Url.Content("~/images/image_2.jpg"), 2095, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2131, ");", 2131, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    </a>
                    <div class=""text px-4 pt-3 pb-4"">
                        <div class=""meta"">
                            <div><a href=""#"">August 3, 2020</a></div>
                            <div><a href=""#"">Admin</a></div>
                        </div>
                        <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind
                                texts</a></h3>
                        <p class=""clearfix"">
                            <a href=""#"" class=""float-left read btn btn-primary"">Read more</a>
                            <a href=""#"" class=""float-right meta-chat""><span class=""fa fa-comment""></span> 3</a>
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 ftco-animate"">
                <div class=""blog-entry"">
                    <a href=""blog-single.html"" class=""block-20""");
            BeginWriteAttribute("style", " style=\"", 3104, "\"", 3172, 4);
            WriteAttributeValue("", 3112, "background-image:", 3112, 17, true);
            WriteAttributeValue(" ", 3129, "url(", 3130, 5, true);
#nullable restore
#line 60 "C:\Users\luisb\Desktop\RestauranteEtec\Views\Home\Blog.cshtml"
WriteAttributeValue("", 3134, Url.Content("~/images/image_3.jpg"), 3134, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3170, ");", 3170, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    </a>
                    <div class=""text px-4 pt-3 pb-4"">
                        <div class=""meta"">
                            <div><a href=""#"">August 3, 2020</a></div>
                            <div><a href=""#"">Admin</a></div>
                        </div>
                        <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind
                                texts</a></h3>
                        <p class=""clearfix"">
                            <a href=""#"" class=""float-left read btn btn-primary"">Read more</a>
                            <a href=""#"" class=""float-right meta-chat""><span class=""fa fa-comment""></span> 3</a>
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 ftco-animate"">
                <div class=""blog-entry"">
                    <a href=""blog-single.html"" class=""block-20""");
            BeginWriteAttribute("style", " style=\"", 4143, "\"", 4211, 4);
            WriteAttributeValue("", 4151, "background-image:", 4151, 17, true);
            WriteAttributeValue(" ", 4168, "url(", 4169, 5, true);
#nullable restore
#line 78 "C:\Users\luisb\Desktop\RestauranteEtec\Views\Home\Blog.cshtml"
WriteAttributeValue("", 4173, Url.Content("~/images/image_4.jpg"), 4173, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4209, ");", 4209, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    </a>
                    <div class=""text px-4 pt-3 pb-4"">
                        <div class=""meta"">
                            <div><a href=""#"">August 3, 2020</a></div>
                            <div><a href=""#"">Admin</a></div>
                        </div>
                        <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind
                                texts</a></h3>
                        <p class=""clearfix"">
                            <a href=""#"" class=""float-left read btn btn-primary"">Read more</a>
                            <a href=""#"" class=""float-right meta-chat""><span class=""fa fa-comment""></span> 3</a>
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 ftco-animate"">
                <div class=""blog-entry"">
                    <a href=""blog-single.html"" class=""block-20""");
            BeginWriteAttribute("style", " style=\"", 5182, "\"", 5250, 4);
            WriteAttributeValue("", 5190, "background-image:", 5190, 17, true);
            WriteAttributeValue(" ", 5207, "url(", 5208, 5, true);
#nullable restore
#line 96 "C:\Users\luisb\Desktop\RestauranteEtec\Views\Home\Blog.cshtml"
WriteAttributeValue("", 5212, Url.Content("~/images/image_5.jpg"), 5212, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5248, ");", 5248, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    </a>
                    <div class=""text px-4 pt-3 pb-4"">
                        <div class=""meta"">
                            <div><a href=""#"">August 3, 2020</a></div>
                            <div><a href=""#"">Admin</a></div>
                        </div>
                        <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind
                                texts</a></h3>
                        <p class=""clearfix"">
                            <a href=""#"" class=""float-left read btn btn-primary"">Read more</a>
                            <a href=""#"" class=""float-right meta-chat""><span class=""fa fa-comment""></span> 3</a>
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 ftco-animate"">
                <div class=""blog-entry"">
                    <a href=""blog-single.html"" class=""block-20""");
            BeginWriteAttribute("style", " style=\"", 6221, "\"", 6289, 4);
            WriteAttributeValue("", 6229, "background-image:", 6229, 17, true);
            WriteAttributeValue(" ", 6246, "url(", 6247, 5, true);
#nullable restore
#line 114 "C:\Users\luisb\Desktop\RestauranteEtec\Views\Home\Blog.cshtml"
WriteAttributeValue("", 6251, Url.Content("~/images/image_6.jpg"), 6251, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6287, ");", 6287, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    </a>
                    <div class=""text px-4 pt-3 pb-4"">
                        <div class=""meta"">
                            <div><a href=""#"">August 3, 2020</a></div>
                            <div><a href=""#"">Admin</a></div>
                        </div>
                        <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind
                                texts</a></h3>
                        <p class=""clearfix"">
                            <a href=""#"" class=""float-left read btn btn-primary"">Read more</a>
                            <a href=""#"" class=""float-right meta-chat""><span class=""fa fa-comment""></span> 3</a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row no-gutters my-5"">
            <div class=""col text-center"">
                <div class=""block-27"">
                    <ul>
                        <li><a href=""#"">");
            WriteLiteral(@"&lt;</a></li>
                        <li class=""active""><span>1</span></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li><a href=""#"">4</a></li>
                        <li><a href=""#"">5</a></li>
                        <li><a href=""#"">&gt;</a></li>
                    </ul>
                </div>
            </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
