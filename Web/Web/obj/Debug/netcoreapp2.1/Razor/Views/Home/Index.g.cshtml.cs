#pragma checksum "C:\Users\omarf\Desktop\site\Web\Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f3820a7944a2dce11c614107cd329438ee59b5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f3820a7944a2dce11c614107cd329438ee59b5b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Services.PostPreviewDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\omarf\Desktop\site\Web\Web\Views\Home\Index.cshtml"
 foreach (var post in Model)
{

#line default
#line hidden
            BeginContext(80, 31, true);
            WriteLiteral("    <div class=\"box content\">\r\n");
            EndContext();
#line 6 "C:\Users\omarf\Desktop\site\Web\Web\Views\Home\Index.cshtml"
          
            string url = $"/Home/GetPost/{post.Url}";
            string imagePath = $"https://storage.cloud.google.com/youit/{post.Url}/thumbnail.png";
        

#line default
#line hidden
            BeginContext(289, 14, true);
            WriteLiteral("\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 303, "\"", 319, 1);
#line 11 "C:\Users\omarf\Desktop\site\Web\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 309, imagePath, 309, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(320, 91, true);
            WriteLiteral(" style=\"max-width:100%\" />\r\n        <div class=\"post-button-wrapper\">\r\n            <div>v: ");
            EndContext();
            BeginContext(412, 15, false);
#line 13 "C:\Users\omarf\Desktop\site\Web\Web\Views\Home\Index.cshtml"
               Write(post.LikesCount);

#line default
#line hidden
            EndContext();
            BeginContext(427, 28, true);
            WriteLiteral("</div>\r\n            <div>c: ");
            EndContext();
            BeginContext(456, 18, false);
#line 14 "C:\Users\omarf\Desktop\site\Web\Web\Views\Home\Index.cshtml"
               Write(post.DislikesCount);

#line default
#line hidden
            EndContext();
            BeginContext(474, 28, true);
            WriteLiteral("</div>\r\n            <div>l: ");
            EndContext();
            BeginContext(503, 18, false);
#line 15 "C:\Users\omarf\Desktop\site\Web\Web\Views\Home\Index.cshtml"
               Write(post.CommentsCount);

#line default
#line hidden
            EndContext();
            BeginContext(521, 28, true);
            WriteLiteral("</div>\r\n            <div>d: ");
            EndContext();
            BeginContext(550, 15, false);
#line 16 "C:\Users\omarf\Desktop\site\Web\Web\Views\Home\Index.cshtml"
               Write(post.ViewsCount);

#line default
#line hidden
            EndContext();
            BeginContext(565, 32, true);
            WriteLiteral("</div>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(597, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef9f5587ad10438bb02c1c0acfad3dd8", async() => {
                BeginContext(669, 18, true);
                WriteLiteral("\r\n            <h3>");
                EndContext();
                BeginContext(688, 10, false);
#line 19 "C:\Users\omarf\Desktop\site\Web\Web\Views\Home\Index.cshtml"
           Write(post.Title);

#line default
#line hidden
                EndContext();
                BeginContext(698, 15, true);
                WriteLiteral("</h3>\r\n        ");
                EndContext();
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-url", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "C:\Users\omarf\Desktop\site\Web\Web\Views\Home\Index.cshtml"
                                                         WriteLiteral(post.Url);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-url", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(717, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 22 "C:\Users\omarf\Desktop\site\Web\Web\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(734, 2441, true);
            WriteLiteral(@"
<!-- ko foreach: posts -->
<div class=""box content"">
    <img style=""max-width:100%"" data-bind=""attr: { src: imageUrl }"" />
    <div class=""post-button-wrapper"">
        <div>v: <span data-bind=""text: viewsCount""></span></div>
        <div>c: <span data-bind=""text: commentsCount""></span></div>
        <div>l: <span data-bind=""text: likesCount""></span></div>
        <div>d: <span data-bind=""text: dislikesCount""></span></div>
    </div>
    <a data-bind=""attr: { href: postUrl }"">
        <h3 data-bind=""text: title""></h3>
    </a>
</div>
<!-- /ko -->

<div class=""box more-posts-button"" >
    <a href=""#"" data-bind=""click: addPosts, visible: morePostsButtonVisible""><u>загрузить больше постов</u></a>
    <h3 data-bind=""visible: endPostsTextVisible"">Извините, посты закончились</h3>
</div>

<script>

    class Post {
        constructor(title, imageUrl, postUrl, viewsCount, commentsCount, likesCount, dislikesCount) {
            this.title = title;
            this.viewsCount = viewsCount;");
            WriteLiteral(@"
            this.commentsCount = commentsCount;
            this.likesCount = likesCount;
            this.dislikesCount = dislikesCount;
            this.imageUrl = imageUrl;
            this.postUrl = postUrl;
        }
    }

    function AppViewModel() {
        let self = this;
        self.posts = ko.observableArray([]);
        self.morePostsButtonVisible = ko.observable(true);
        self.endPostsTextVisible = ko.observable(false);
        const initialPostsCount = 9; 

        self.addPosts = function () {
            let skip = initialPostsCount + self.posts().length;
            $.get('https://localhost:5001/home/loadposts?skip=' + skip, function (posts) {
                if (!posts || posts.length === 0) {
                    self.morePostsButtonVisible(false);
                    self.endPostsTextVisible(true);
                    return;
                }

                for (let post of posts) {
                    let imageUrl = 'https://storage.cloud.google.com/you");
            WriteLiteral(@"it/' + post.url + '/thumbnail.png';
                    let postUrl = 'https://localhost:5001/home/getpost?url=' + post.url;
                    self.posts.push(new Post(post.title, imageUrl, postUrl, post.viewsCount, post.commentsCount, post.likesCount, post.dislikesCount));
                }
            });
        };
    }

    ko.applyBindings(new AppViewModel());

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Services.PostPreviewDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
