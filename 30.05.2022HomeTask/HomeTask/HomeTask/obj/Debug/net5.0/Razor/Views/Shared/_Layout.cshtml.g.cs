#pragma checksum "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca71f7f3c6682803184626aed0acb7637851b89e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\_ViewImports.cshtml"
using HomeTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\_ViewImports.cshtml"
using HomeTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\_ViewImports.cshtml"
using HomeTask.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca71f7f3c6682803184626aed0acb7637851b89e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a4cfa50364d7445a311a299631f82ca7302ef8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE HTML>\r\n<!--\r\n    Aesthetic by freehtml5.co\r\n    Twitter: http://twitter.com/fh5co\r\n    URL: http://freehtml5.co\r\n-->\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca71f7f3c6682803184626aed0acb7637851b89e4252", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Beryllium &mdash; Free Website Template, Free HTML5 Template by FreeHTML5.co</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""description"" content=""Free HTML5 Website Template by FreeHTML5.co"" />
    <meta name=""keywords"" content=""free website templates, free html5, free template, free bootstrap, free website template, html5, css3, mobile first, responsive"" />
    <meta name=""author"" content=""FreeHTML5.co"" />

    <!-- Facebook and Twitter integration -->
    <meta property=""og:title""");
                BeginWriteAttribute("content", " content=\"", 786, "\"", 796, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:image\"");
                BeginWriteAttribute("content", " content=\"", 831, "\"", 841, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:url\"");
                BeginWriteAttribute("content", " content=\"", 874, "\"", 884, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:site_name\"");
                BeginWriteAttribute("content", " content=\"", 923, "\"", 933, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:description\"");
                BeginWriteAttribute("content", " content=\"", 974, "\"", 984, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"twitter:title\"");
                BeginWriteAttribute("content", " content=\"", 1020, "\"", 1030, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"twitter:image\"");
                BeginWriteAttribute("content", " content=\"", 1066, "\"", 1076, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"twitter:url\"");
                BeginWriteAttribute("content", " content=\"", 1110, "\"", 1120, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"twitter:card\"");
                BeginWriteAttribute("content", " content=\"", 1155, "\"", 1165, 0);
                EndWriteAttribute();
                WriteLiteral(@" />

    <link href=""https://fonts.googleapis.com/css?family=Merriweather:300,400|Montserrat:400,700"" rel=""stylesheet"">

    <!-- Animate.css -->
    <link rel=""stylesheet"" href=""css/animate.css"">
    <!-- Icomoon Icon Fonts-->
    <link rel=""stylesheet"" href=""css/icomoon.css"">
    <!-- Themify Icons-->
    <link rel=""stylesheet"" href=""css/themify-icons.css"">
    <!-- Bootstrap  -->
    <link rel=""stylesheet"" href=""css/bootstrap.css"">

    <!-- Owl Carousel  -->
    <link rel=""stylesheet"" href=""css/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""css/owl.theme.default.min.css"">

    <!-- Theme style  -->
    <link rel=""stylesheet"" href=""css/style.css"">

    <!-- Modernizr JS -->
    <script src=""js/modernizr-2.6.2.min.js""></script>
    <!-- FOR IE9 below -->
    <!--[if lt IE 9]>
    <script src=""js/respond.min.js""></script>
    <![endif]-->

");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca71f7f3c6682803184626aed0acb7637851b89e8534", async() => {
                WriteLiteral(@"

    <div class=""gtco-loader""></div>

    <div id=""page"">

        <nav class=""gtco-nav"" role=""navigation"">
            <div class=""gtco-container"">

                <div class=""row"">
                    <div class=""col-sm-2 col-xs-12"">
                        <div id=""gtco-logo""><a href=""index.html"">Beryllium</div>
                    </div>
                    <div class=""col-xs-10 text-right menu-1"">
                        <ul>
                            <li class=""active""><a href=""index.html"">Home</a></li>
                            <li><a href=""about.html"">About</a></li>
                            <li class=""has-dropdown"">
                                <a href=""services.html"">Services</a>
                                <ul class=""dropdown"">
                                    <li><a href=""#"">Web Design</a></li>
                                    <li><a href=""#"">eCommerce</a></li>
                                    <li><a href=""#"">Branding</a></li>
                        ");
                WriteLiteral(@"            <li><a href=""#"">API</a></li>
                                </ul>
                            </li>
                            <li class=""has-dropdown"">
                                <a href=""#"">Dropdown</a>
                                <ul class=""dropdown"">
                                    <li><a href=""#"">HTML5</a></li>
                                    <li><a href=""#"">CSS3</a></li>
                                    <li><a href=""#"">Sass</a></li>
                                    <li><a href=""#"">jQuery</a></li>
                                </ul>
                            </li>
                            <li><a href=""portfolio.html"">Portfolio</a></li>
                            <li><a href=""contact.html"">Contact</a></li>
                        </ul>
                    </div>
                </div>

            </div>
        </nav>


        ");
#nullable restore
#line 99 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


        <footer id=""gtco-footer"" class=""gtco-section"" role=""contentinfo"">
            <div class=""gtco-container"">
                <div class=""row row-pb-md"">
                    <div class=""col-md-4 gtco-widget gtco-footer-paragraph"">
                        <h3>Beryllium</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et urna sagittis, rhoncus euismod.</p>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""row"">
                            <div class=""col-md-6 gtco-footer-link"">
                                <h3>Links</h3>
                                <ul class=""gtco-list-link"">
                                    <li><a href=""#"">Home</a></li>
                                    <li><a href=""#"">Features</a></li>
                                    <li><a href=""#"">Products</a></li>
                                    <li><a href=""#"">Testimonial</a></li>
          ");
                WriteLiteral(@"                          <li><a href=""#"">Contact</a></li>
                                </ul>
                            </div>
                            <div class=""col-md-6 gtco-footer-link"">
                                <h3>Work</h3>
                                <ul class=""gtco-list-link"">
                                    <li><a href=""#"">New York Arena</a></li>
                                    <li><a href=""#"">Eagle Park</a></li>
                                    <li><a href=""#"">Nationals Park</a></li>
                                    <li><a href=""#"">Manila Park</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4 gtco-footer-subscribe"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca71f7f3c6682803184626aed0acb7637851b89e13000", async() => {
                    WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label class=\"sr-only\" for=\"exampleInputEmail3\">Email address</label>\r\n                                <input type=\"email\" class=\"form-control\"");
                    BeginWriteAttribute("id", " id=\"", 6138, "\"", 6143, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"Email\">\r\n                            </div>\r\n                            <button type=\"submit\" class=\"btn btn-primary\">Send</button>\r\n                        ");
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
                WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""gtco-copyright"">
                <div class=""gtco-container"">
                    <div class=""row"">
                        <div class=""col-md-6 text-left"">
                            <p><small>&copy; 2016 Free HTML5. All Rights Reserved. </small></p>
                        </div>
                        <div class=""col-md-6 text-right"">
                            <p><small>Designed by <a href=""http://freehtml5.co/"" target=""_blank"">FreeHTML5.co</a> Demo Images: <a href=""http://pixeden.com/"" target=""_blank"">Pixeden</a> &amp; <a href=""http://unsplash.com"" target=""_blank"">Unsplash</a></small> </p>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
        <!-- END footer -->

    </div>

    <div class=""gototop js-top"">
        <a href=""#"" class=""js-gotop""><i class=""icon-arrow-up""></i></a>
    </div>

    <!-- jQuery -->
    ");
                WriteLiteral(@"<script src=""js/jquery.min.js""></script>
    <!-- jQuery Easing -->
    <script src=""js/jquery.easing.1.3.js""></script>
    <!-- Bootstrap -->
    <script src=""js/bootstrap.min.js""></script>
    <!-- Waypoints -->
    <script src=""js/jquery.waypoints.min.js""></script>
    <!-- Carousel -->
    <script src=""js/owl.carousel.min.js""></script>

    <!-- Main -->
    <script src=""js/main.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
