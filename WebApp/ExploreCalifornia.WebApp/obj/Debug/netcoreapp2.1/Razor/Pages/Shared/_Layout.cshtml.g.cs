#pragma checksum "/home/azureuser/helloRabbit/WebApp/ExploreCalifornia.WebApp/Pages/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c376a6247418a5939719a88bc7102ea7ef4be8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExploreCalifornia.WebApp.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_Layout.cshtml", typeof(ExploreCalifornia.WebApp.Pages.Shared.Pages_Shared__Layout))]
namespace ExploreCalifornia.WebApp.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/azureuser/helloRabbit/WebApp/ExploreCalifornia.WebApp/Pages/_ViewImports.cshtml"
using ExploreCalifornia.WebApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c376a6247418a5939719a88bc7102ea7ef4be8f", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"889949180b08da63ba2a27ee60b067df1ebfab35", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("no-js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 1341, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c376a6247418a5939719a88bc7102ea7ef4be8f3707", async() => {
                BeginContext(41, 41, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>");
                EndContext();
                BeginContext(83, 17, false);
#line 5 "/home/azureuser/helloRabbit/WebApp/ExploreCalifornia.WebApp/Pages/Shared/_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(100, 1269, true);
                WriteLiteral(@"</title>
    <meta name=""description"" content=""A lynda.com example of HTML5 and CSS3"">
    <meta name=""keywords"" content=""html5, css3, lynda, local storage, canvas, forms, semantics, web apps"">
    <!--make sure mobile devices display the page at the proper scale	-->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <!--[if lt IE 9]>
        <script src=""http://html5shiv.googlecode.com/svn/trunk/html5.js""></script>
    <![endif]-->
    <link href=""css/main.css"" rel=""stylesheet"" type=""text/css"" media=""screen, projection"">
    <link href=""css/jquery_widgets.css"" rel=""stylesheet"" media=""screen, projection"" />
    <link href=""css/tablet.css"" rel=""stylesheet"" type=""text/css"" media=""all and (min-width: 481px) and (max-width: 768px)"" />
    <link href=""css/mobile.css"" rel=""stylesheet"" type=""text/css"" media=""all and (min-width: 0px) and (max-width: 480px)"" />
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js"" integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8H");
                WriteLiteral("fCJo=\" crossorigin=\"anonymous\"></script>\r\n    <script src=\"https://code.jquery.com/jquery-3.4.1.min.js\" integrity=\"sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=\" crossorigin=\"anonymous\"></script>\r\n    <script src=\"/js/menus.js\"></script>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1376, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1378, 6193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c376a6247418a5939719a88bc7102ea7ef4be8f6626", async() => {
                BeginContext(1398, 2944, true);
                WriteLiteral(@"
    <div id=""wrapper"">
        <header id=""mainHeader"">
            <a href=""/"" title=""home"" class=""logo"">
                <!-- I need this div because IE is an affront to mankind-->
                <div id=""logo"">
                    <h1>Explore California</h1>
                </div>
            </a>
            <nav id=""siteNav"">
                <h1>Where do you want to go?</h1>
                <ul>
                    <li>
                        <a href=""/tours"" title=""Our tours"" class=""current"">Tours <br /><span class=""tagline"">follow our bliss</span></a>
                        <ul>
                            <li><a href=""/tours"" title=""Our tours"">All Tours</a></li>
                            <li><a href=""/tours"" title=""find tours"">Tours by Activity</a></li>
                            <li><a href=""/tours"" title=""find tours"">Tours by Region</a></li>
                            <li><a href=""/tours"" title=""find tours"">Tour Finder</a></li>
                        </ul>
              ");
                WriteLiteral(@"      </li>
                    <li><a href=""mission.htm"" title=""What we believe"">Mission <br /><span class=""tagline"">what makes us different?</span></a></li>
                    <li>
                        <a href=""resources.htm"" title=""planning resources"">Resources <br /><span class=""tagline"">plan your trip</span></a>
                        <ul>
                            <li><a href=""resources/faq.htm"" title=""Got questions?"">Tour FAQs</a></li>
                            <li><a href=""resources/links.htm"" title=""additional resources"">Tour Information</a></li>
                            <li><a href=""resources/terms.htm"" title=""terms and conditions"">Site Terms</a></li>
                        </ul>
                    </li>
                    <li>
                        <a href=""explorers.htm"" title=""Our community"">Explorers <br /><span class=""tagline"">join our community</span></a>
                        <ul>
                            <li><a href=""explorers/join.htm"" title=""join our comm");
                WriteLiteral(@"unity"">Join the Explorers</a></li>
                            <li><a href=""blog/index.htm"" title=""read our blog!"">Read our Blog</a></li>
                            <li><a href=""explorers/gallery.htm"" title=""contributor photos"">Tour Photos</a></li>
                            <li><a href=""_video/EC_podcast_full version.mov"" title=""check out our podcast"">Video podcast</a></li>
                        </ul>
                    </li>
                    <li>
                        <a href=""/contact"" title=""contact us"" class=""last"">Contact <br /><span class=""tagline"">we're listening</span></a>
                        <ul>
                            <li><a href=""support.htm"" title=""need help?"">Support</a></li>
                        </ul>
                    </li>
                </ul>
            </nav>
        </header>
        <section id=""mainContent"">
            ");
                EndContext();
                BeginContext(4343, 12, false);
#line 70 "/home/azureuser/helloRabbit/WebApp/ExploreCalifornia.WebApp/Pages/Shared/_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4355, 3209, true);
                WriteLiteral(@"
        </section>
        <aside id=""secondaryContent"">
            <div id=""specials"" class=""callOut"">
                <h1>Monthly Specials</h1>
                <h2 class=""top""><img src=""images/calm_bug.gif"" alt=""California Calm"" width=""75"" height=""75"" />California Calm</h2>
                <p>
                    Day Spa Package <br />
                    <a href=""tours/tour_detail_cycle.htm"">$250</a>
                </p>
                <h2><img src=""images/desert_bug.gif"" alt=""From desert to sea"" width=""75"" height=""75"" />From Desert to Sea</h2>
                <p>
                    2 Day Salton Sea <br />
                    <a href=""tours/tour_detail_cycle.htm"">$350</a>
                </p>
                <h2><img src=""images/backpack_bug.gif"" alt=""Backpack Cali"" width=""75"" height=""41"" />Backpack Cali</h2>
                <p>
                    Big Sur Retreat <br />
                    <a href=""tours/tour_detail_cycle.htm"">$620</a>
                </p>
                <h2><img ");
                WriteLiteral(@"src=""images/taste_bug.gif"" alt=""Taste of California"" width=""75"" height=""75"" />Taste of California</h2>
                <p>
                    Tapas &amp; Groves <br />
                    <a href=""tours/tour_detail_taste.htm"">$150</a>
                </p>
            </div>
            <div id=""trivia"" class=""callOut"">
                <h1>Did You Know?</h1>
                <p>Among the prehistoric species associated with the La Brea Tar Pits are mammoths, dire wolves, short-faced bears, ground sloths, and the state fossil of California, the sabertoothed cat, <em>Smilodon californicus</em>.</p>
            </div>
        </aside>
        <footer id=""pageFooter"">
            <section id=""quickLinks"">
                <h1>Quick Nav</h1>
                <ul id=""quickNav"">
                    <li><a href=""index.htm"" title=""Our home page"">Home</a></li>
                    <li><a href=""/tours"" title=""Explore our tours"">Tours</a></li>
                    <li><a href=""mission.htm"" title=""What we think");
                WriteLiteral(@""">Mission</a></li>
                    <li><a href=""resources.htm"" title=""Guidance and planning"">Resources</a></li>
                    <li><a href=""explorers.htm"" title=""Join our community"">Explorers</a></li>
                    <li><a href=""contact.htm"" title=""Contact and support"">Contact</a></li>
                </ul>
            </section>
            <section id=""footerResources"">
                <h1>Resources</h1>
                <ul id=""quickNav"">
                    <li><a href=""resources/faq.htm"" title=""Our home page"">FAQ</a></li>
                    <li><a href=""support.htm"" title=""Need help?"">Support</a></li>
                    <li><a href=""resources/legal.htm"" title=""The fine print"">Legal</a></li>
                </ul>
            </section>
            <section id=""companyInfo"">
                <h1>Contact</h1>
                <h2>Explore California</h2>
                <p>
                    5605 Nota Street<br />
                    Ventura, CA 93003
                </p>
");
                WriteLiteral("                <p>866.555.4310<br />866.555.4315 <em>(24 hour support)</em></p>\r\n            </section>\r\n        </footer>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7571, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
