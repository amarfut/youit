#pragma checksum "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c65bbc0b532dd703c7f6329e95d1472b16525c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TopMenu_Default))]
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
#line 1 "C:\Users\omarf\Desktop\site\Web\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "C:\Users\omarf\Desktop\site\Web\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c65bbc0b532dd703c7f6329e95d1472b16525c4", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Views.Components.TopMenu.TopMenuViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 214, true);
            WriteLiteral("\r\n<ul class=\"menu\">\r\n    <li>\r\n        <label for=\"drop-1\" class=\"toggle\">Карьера в IT</label>\r\n        <a href=\"#\" class=\"top-link\">Карьера в IT</a>\r\n        <input type=\"checkbox\" id=\"drop-1\" />\r\n\r\n        <ul>\r\n");
            EndContext();
#line 10 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
             foreach (var career in Model.CareerPosts)
            {

#line default
#line hidden
            BeginContext(339, 22, true);
            WriteLiteral("                <li>\r\n");
            EndContext();
#line 13 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                      string imagePath = $"https://storage.cloud.google.com/youit/{career.Url}/mini.png"; 

#line default
#line hidden
            BeginContext(470, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 494, "\"", 510, 1);
#line 14 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 500, imagePath, 500, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(511, 37, true);
            WriteLiteral(" />\r\n                    <a href=\"#\">");
            EndContext();
            BeginContext(549, 12, false);
#line 15 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                           Write(career.Title);

#line default
#line hidden
            EndContext();
            BeginContext(561, 83, true);
            WriteLiteral("</a>\r\n                    <div style=\"clear: left;\"></div>\r\n                </li>\r\n");
            EndContext();
#line 18 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(659, 227, true);
            WriteLiteral("        </ul>\r\n    </li>\r\n\r\n    <li>\r\n        <label for=\"drop-2\" class=\"toggle\">Программирование</label>\r\n        <a href=\"#\" class=\"top-link\">Программирование</a>\r\n        <input type=\"checkbox\" id=\"drop-2\" />\r\n        <ul>\r\n");
            EndContext();
#line 27 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
             foreach (var career in Model.ProgrammingPosts)
            {

#line default
#line hidden
            BeginContext(962, 22, true);
            WriteLiteral("                <li>\r\n");
            EndContext();
#line 30 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                      string imagePath = $"https://storage.cloud.google.com/youit/{career.Url}/mini.png"; 

#line default
#line hidden
            BeginContext(1093, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1117, "\"", 1133, 1);
#line 31 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 1123, imagePath, 1123, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1134, 37, true);
            WriteLiteral(" />\r\n                    <a href=\"#\">");
            EndContext();
            BeginContext(1172, 12, false);
#line 32 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                           Write(career.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1184, 83, true);
            WriteLiteral("</a>\r\n                    <div style=\"clear: left;\"></div>\r\n                </li>\r\n");
            EndContext();
#line 35 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(1282, 215, true);
            WriteLiteral("        </ul>\r\n    </li>\r\n\r\n    <li>\r\n        <label for=\"drop-3\" class=\"toggle\">Секреты IT</label>\r\n        <a href=\"#\" class=\"top-link\">Секреты IT</a>\r\n        <input type=\"checkbox\" id=\"drop-3\" />\r\n        <ul>\r\n");
            EndContext();
#line 44 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
             foreach (var career in Model.JuniorPosts)
            {

#line default
#line hidden
            BeginContext(1568, 22, true);
            WriteLiteral("                <li>\r\n");
            EndContext();
#line 47 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                      string imagePath = $"https://storage.cloud.google.com/youit/{career.Url}/mini.png"; 

#line default
#line hidden
            BeginContext(1699, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1723, "\"", 1739, 1);
#line 48 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 1729, imagePath, 1729, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1740, 37, true);
            WriteLiteral(" />\r\n                    <a href=\"#\">");
            EndContext();
            BeginContext(1778, 12, false);
#line 49 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
                           Write(career.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1790, 83, true);
            WriteLiteral("</a>\r\n                    <div style=\"clear: left;\"></div>\r\n                </li>\r\n");
            EndContext();
#line 52 "C:\Users\omarf\Desktop\site\Web\Web\Views\Shared\Components\TopMenu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(1888, 33, true);
            WriteLiteral("        </ul>\r\n    </li>\r\n\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Views.Components.TopMenu.TopMenuViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
