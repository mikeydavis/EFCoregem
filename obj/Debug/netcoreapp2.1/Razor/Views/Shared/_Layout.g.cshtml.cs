#pragma checksum "/Users/mikedavis/development/EFGetStarted.AspNetCore.NewDb/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cfcb47065bb4312464154dfff0f241879707c8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "/Users/mikedavis/development/EFGetStarted.AspNetCore.NewDb/Views/_ViewImports.cshtml"
using EFGetStarted.AspNetCore.NewDb;

#line default
#line hidden
#line 2 "/Users/mikedavis/development/EFGetStarted.AspNetCore.NewDb/Views/_ViewImports.cshtml"
using EFGetStarted.AspNetCore.NewDb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cfcb47065bb4312464154dfff0f241879707c8d", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12cb27665797f39a67346b5bbf3aa4027c4dccc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 1093, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "244794d422364e138a6903a2d8457fb6", async() => {
                BeginContext(6, 1080, true);
                WriteLiteral(@"
  <!-- Site made with Mobirise Website Builder v4.7.2,  -->
  <meta charset=""UTF-8"">
  <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
  <meta name=""generator"" content="""">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1, minimum-scale=1"">
  <link rel=""shortcut icon"" href=""/assets/images/mdxlogo-148x63.png"" type=""image/x-icon"">
  <meta name=""description"" content=""Midax Ltd"">
  <link rel=""stylesheet"" href=""/assets/web/assets/mobirise-icons/mobirise-icons.css"">
  <link rel=""stylesheet"" href=""/assets/tether/tether.min.css"">
  <link rel=""stylesheet"" href=""/assets/bootstrap/css/bootstrap.min.css"">
  <link rel=""stylesheet"" href=""/assets/bootstrap/css/bootstrap-grid.min.css"">
  <link rel=""stylesheet"" href=""/assets/bootstrap/css/bootstrap-reboot.min.css"">
  <link rel=""stylesheet"" href=""/assets/socicon/css/styles.css"">
  <link rel=""stylesheet"" href=""/assets/dropdown/css/style.css"">
  <link rel=""stylesheet"" href=""/assets/theme/css/style.css"">
  <link rel=""stylesheet"" href=""/as");
                WriteLiteral("sets/mobirise/css/mbr-additional.css\" type=\"text/css\">\r\n");
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
            BeginContext(1093, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1095, 8159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b18ff7d778464790958263dc8ae78557", async() => {
                BeginContext(1101, 2215, true);
                WriteLiteral(@"
  <section class=""menu cid-qRtqvFSj9q"" once=""menu"" id=""menu1-e"">

    <nav class=""navbar navbar-expand beta-menu navbar-dropdown align-items-center navbar-fixed-top navbar-toggleable-sm"">
        <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <div class=""hamburger"">
                <span></span>
                <span></span>
                <span></span>
                <span></span>
            </div>
        </button>
        <div class=""menu-logo"">
            <div class=""navbar-brand"">
                <span class=""navbar-logo"">
                    <a href="""">
                         <img src=""/assets/images/mdxlogo-148x63.png"" alt=""Mobirise"" title="""" style=""height: 4.3rem;"">
                    </a>
                </span>
                <span class=""navbar-caption-wrap""><a class=""navbar-caption text-w");
                WriteLiteral(@"hite display-4"" href=""""></a></span>
            </div>
        </div>
        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav nav-dropdown"" data-app-modern-menu=""true""><li class=""nav-item"">
                    <a class=""nav-link link text-white display-4"" href=""/"">
                        <span class=""mbri-home mbr-iconfont mbr-iconfont-btn""></span>
                        Home<br></a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link link text-white display-4"" href=""/home/about""><span class=""mbri-edit mbr-iconfont mbr-iconfont-btn""></span>
                        About Us
                    </a>
                </li></ul>
            <div class=""navbar-buttons mbr-section-btn""><a class=""btn btn-sm btn-secondary display-4"" href=""/blogs""><span class=""mbri-letter mbr-iconfont mbr-iconfont-btn""></span>Blog</a></div>
        </div>
    </nav>
</section>

<section class=""engine""><a href="""">how ");
                WriteLiteral("to create a website</a></section><section class=\"cid-qRtqvGHBOr mbr-fullscreen mbr-parallax-background\" id=\"header2-f\">\r\n<div class=\"container align-center\">\r\n        ");
                EndContext();
                BeginContext(3317, 12, false);
#line 59 "/Users/mikedavis/development/EFGetStarted.AspNetCore.NewDb/Views/Shared/_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3329, 5336, true);
                WriteLiteral(@"
    </div>
    <div class=""mbr-arrow hidden-sm-down"" aria-hidden=""true"">
        <a href=""#next"">
            <i class=""mbri-down mbr-iconfont""></i>
        </a>
    </div>
</section>

<section class=""cid-qRtqvHzeWv"" id=""footer1-g"">
    <div class=""container"">
        <div class=""media-container-row content text-white"">
            <div class=""col-12 col-md-3"">
                <div class=""media-wrap"">
                    
                </div>
            </div>
            <div class=""col-12 col-md-3 mbr-fonts-style display-7"">
                <h5 class=""pb-3"">
                    Address
                </h5>
                <p class=""mbr-text"">Business Centre<br>26 - 28 Queensway &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<br>Enfield EN3 4SA</p>
            </div>
            <div class=""col-12 col-md-3 mbr-fonts-style display-7"">
                <h5 class=""pb-3"">
                    Contacts
                </h5>
                <p class=""mbr-text"">
");
                WriteLiteral(@"                    Email: michael@midax.co.uk<br></p>
            </div>
            <div class=""col-12 col-md-3 mbr-fonts-style display-7"">
                <h5 class=""pb-3"">
                    Links
                </h5>
                <p class=""mbr-text"">
                    <a class=""text-primary"" href="""">Website builder</a>
                    <br>&nbsp;<br><br></p>
            </div>
        </div>
        <div class=""footer-lower"">
            <div class=""media-container-row"">
                <div class=""col-sm-12"">
                    <hr>
                </div>
            </div>
            <div class=""media-container-row mbr-white"">
                <div class=""col-sm-6 copyright"">
                    <p class=""mbr-text mbr-fonts-style display-7"">
                        © Copyright 2018 Midax Ltd - All Rights Reserved
                    </p>
                </div>
                <div class=""col-md-6"">
                    <div class=""social-list align-right"">
           ");
                WriteLiteral(@"             <div class=""soc-item"">
                            <a href="""" target=""_blank"">
                                <span class=""socicon-twitter socicon mbr-iconfont mbr-iconfont-social""></span>
                            </a>
                        </div>
                        <div class=""soc-item"">
                            <a href=""https://www.facebook.com/pages/Mobirise/1616226671953247"" target=""_blank"">
                                <span class=""socicon-facebook socicon mbr-iconfont mbr-iconfont-social""></span>
                            </a>
                        </div>
                        <div class=""soc-item"">
                            <a href=""https://www.youtube.com/c/mobirise"" target=""_blank"">
                                <span class=""socicon-youtube socicon mbr-iconfont mbr-iconfont-social""></span>
                            </a>
                        </div>
                        <div class=""soc-item"">
                            <a href="""" target=""");
                WriteLiteral(@"_blank"">
                                <span class=""socicon-instagram socicon mbr-iconfont mbr-iconfont-social""></span>
                            </a>
                        </div>
                        <div class=""soc-item"">
                            <a href=""https://plus.google.com/u/0/+Mobirise"" target=""_blank"">
                                <span class=""socicon-googleplus socicon mbr-iconfont mbr-iconfont-social""></span>
                            </a>
                        </div>
                        <div class=""soc-item"">
                            <a href=""https://www.behance.net/Mobirise"" target=""_blank"">
                                <span class=""socicon-behance socicon mbr-iconfont mbr-iconfont-social""></span>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""header9 cid-r7GIDv9Qnt mbr-fullscreen mbr-parallax-background"" id=");
                WriteLiteral(@"""header9-l"">
    <div class=""container"">
        <div class=""media-container-column mbr-white col-md-8"">
            <h1 class=""mbr-section-title align-left mbr-bold pb-3 mbr-fonts-style display-1"">
                Relax while we work</h1>
            <h3 class=""mbr-section-subtitle align-left mbr-light pb-3 mbr-fonts-style display-2"">
                Beautiful mobile websites
            </h3>
            <p class=""mbr-text align-left pb-3 mbr-fonts-style display-5"">
                Click any text to edit or style it. Select text to insert a link. Click blue ""Gear"" icon in the top right corner to hide/show buttons, text, title and change the block background. Click red ""+"" in the bottom right corner to add a new block. Use the top left menu to create new pages, sites and add themes.
            </p>
            <div class=""mbr-section-btn align-left""><a class=""btn btn-md btn-primary display-4"" href="""">Reactive</a>
                <a class=""btn btn-md btn-black-outline display-4"" href="""">Easy</a><");
                WriteLiteral("/div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"mbr-arrow hidden-sm-down\" aria-hidden=\"true\">\r\n        <a href=\"#next\">\r\n            <i class=\"mbri-down mbr-iconfont\"></i>\r\n        </a>\r\n    </div>\r\n</section>\r\n");
                EndContext();
                BeginContext(8666, 17, false);
#line 171 "/Users/mikedavis/development/EFGetStarted.AspNetCore.NewDb/Views/Shared/_Layout.cshtml"
Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(8683, 564, true);
                WriteLiteral(@"

  <script src=""/assets/web/assets/jquery/jquery.min.js""></script>
  <script src=""/assets/popper/popper.min.js""></script>
  <script src=""/assets/tether/tether.min.js""></script>
  <script src=""/assets/bootstrap/js/bootstrap.min.js""></script>
  <script src=""/assets/dropdown/js/script.min.js""></script>
  <script src=""/assets/touchswipe/jquery.touch-swipe.min.js""></script>
  <script src=""/assets/parallax/jarallax.min.js""></script>
  <script src=""/assets/smoothscroll/smooth-scroll.js""></script>
  <script src=""/assets/theme/js/script.js""></script>
  
");
                EndContext();
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
            EndContext();
            BeginContext(9254, 12, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
