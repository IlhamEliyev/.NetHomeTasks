#pragma checksum "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdd502d135087b8cd54c750f32c4104cd35579a7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdd502d135087b8cd54c750f32c4104cd35579a7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a4cfa50364d7445a311a299631f82ca7302ef8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("        <div class=\"gtco-container\">\r\n            <div class=\"row\">\r\n              \r\n                <div class=\"col-md-12\">\r\n                    <div class=\"owl-carousel owl-carousel-fullwidth\">\r\n");
#nullable restore
#line 7 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                         foreach (Banner banner in Model.banners)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"item\">\r\n                                <a href=\"#\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 447, "\"", 473, 2);
            WriteAttributeValue("", 453, "images/", 453, 7, true);
#nullable restore
#line 11 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
WriteAttributeValue("", 460, banner.Image, 460, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Free Website Template by FreeHTML5.co\">\r\n                                    <div class=\"slider-copy\">\r\n                                        <h2>");
#nullable restore
#line 13 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                                       Write(banner.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    </div>\r\n                                </a>\r\n                            </div>\r\n");
#nullable restore
#line 17 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"gtco-section\">\r\n            <div class=\"gtco-container\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 26 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                     foreach (MainContext mainContext in Model.mainContexts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-8 col-md-offset-2 gtco-heading text-center\">\r\n                            <h2>");
#nullable restore
#line 29 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                           Write(mainContext.MainText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>");
#nullable restore
#line 30 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                          Write(mainContext.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 32 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"row\">\r\n\r\n                    <div class=\"col-md-12\">\r\n                        <div class=\"owl-carousel owl-carousel-carousel\">\r\n");
#nullable restore
#line 38 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                             foreach (Cities city in Model.cities)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"item\">\r\n                                    <div class=\"gtco-item\">\r\n                                        <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 1802, "\"", 1826, 2);
            WriteAttributeValue("", 1808, "images/", 1808, 7, true);
#nullable restore
#line 42 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
WriteAttributeValue("", 1815, city.Image, 1815, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1827, "\"", 1833, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\"></a>\r\n                                        <h2><a href=\"#\">");
#nullable restore
#line 43 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                                                   Write(city.PlaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                                        <p class=\"role\">");
#nullable restore
#line 44 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                                                   Write(city.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 47 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <!-- END Work -->

        <div class=""gtco-section"">
            <div class=""gtco-container"">
                <div class=""row"">
                    <div class=""col-md-6 gtco-news"">
                        <h2>News</h2>
                        <ul>
");
#nullable restore
#line 63 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                             foreach (News news in Model.news)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <a href=\"#\">\r\n                                        <span class=\"post-date\">");
#nullable restore
#line 67 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                                                           Write(news.NowDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <h3>");
#nullable restore
#line 68 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                                       Write(news.MainText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <p>");
#nullable restore
#line 69 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                                      Write(news.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 72 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </ul>
                        <p><a href=""#"" class=""btn btn-sm btn-special"">More News</a></p>
                    </div>
                    <!-- END News -->
                    <div class=""col-md-5 col-md-push-1 gtco-testimonials"">
                        <h2>Testimonials</h2>
");
#nullable restore
#line 81 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                         foreach (TestMonials testMonials in Model.testMonials)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <blockquote>\r\n                                <p>&ldquo;");
#nullable restore
#line 84 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                                     Write(testMonials.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("&ldquo;</p>\r\n                                <p class=\"author\"><cite>&mdash; ");
#nullable restore
#line 85 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                                                           Write(testMonials.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</cite></p>\r\n                            </blockquote>\r\n");
#nullable restore
#line 87 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                       
                    </div>
                </div>
            </div>
        </div>
        <!-- END  -->

        <div class=""gtco-section gto-features"">
            <div class=""gtco-container"">
                <div class=""row"">
");
#nullable restore
#line 98 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                     foreach (Project project in Model.projects)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4\">\r\n                            <div class=\"feature-left\">\r\n                                <i");
            BeginWriteAttribute("class", " class=\"", 4224, "\"", 4250, 2);
#nullable restore
#line 102 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
WriteAttributeValue("", 4232, project.Icon, 4232, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4245, "icon", 4246, 5, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                <div class=\"copy\">\r\n                                    <h3>");
#nullable restore
#line 104 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                                   Write(project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <p>");
#nullable restore
#line 105 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                                  Write(project.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p><a href=\"#\" class=\"gtco-more\">Learn more</a></p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 110 "C:\Users\Ilham\Desktop\.NetCore\30.05.2022HomeTask\HomeTask\HomeTask\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591