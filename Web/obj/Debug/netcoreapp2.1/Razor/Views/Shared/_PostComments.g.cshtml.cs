#pragma checksum "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb15defdee06747469685ed27d880375cad2bb2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PostComments), @"mvc.1.0.view", @"/Views/Shared/_PostComments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PostComments.cshtml", typeof(AspNetCore.Views_Shared__PostComments))]
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
#line 1 "C:\Users\omarf\Desktop\site\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "C:\Users\omarf\Desktop\site\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb15defdee06747469685ed27d880375cad2bb2d", @"/Views/Shared/_PostComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PostComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Services.DTOs.PostDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignInExternal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-externalProvider", "Google", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-externalProvider", "Facebook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-externalProvider", "VK", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 86, true);
            WriteLiteral("\r\n    <div class=\"comments-wrapper\">\r\n        <input id=\"post-id-hidden\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 116, "\"", 133, 1);
#line 4 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
WriteAttributeValue("", 124, Model.Id, 124, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(134, 7, true);
            WriteLiteral(" />\r\n\r\n");
            EndContext();
#line 6 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
            BeginContext(197, 53, true);
            WriteLiteral("            <input id=\"username-hidden\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 250, "\"", 277, 1);
#line 8 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
WriteAttributeValue("", 258, User.Identity.Name, 258, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(278, 193, true);
            WriteLiteral(" />\r\n            <textarea id=\"comment-box\" style=\"width: 100%\" cols=\"4\" placeholder=\"Комментировать...\"></textarea>\r\n            <button data-bind=\"click: addComment\">Комментировать</button>\r\n");
            EndContext();
#line 11 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(507, 91, true);
            WriteLiteral("            <p><b>Авторизируйтесь в один клик для участия в дискуссии</b></p>\r\n            ");
            EndContext();
            BeginContext(598, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52b8399b942c482e8d7082f43ca733b7", async() => {
                BeginContext(690, 61, true);
                WriteLiteral("\r\n                Авторизироваться через Google\r\n            ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-externalProvider", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["externalProvider"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(755, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
            BeginContext(766, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(778, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "416b6390e7364ac09686d757c132525a", async() => {
                BeginContext(871, 63, true);
                WriteLiteral("\r\n                Авторизироваться через Facebook\r\n            ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-externalProvider", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["externalProvider"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(938, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
            BeginContext(949, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(961, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c9ffe95d75046a782c5202b51124c69", async() => {
                BeginContext(1048, 57, true);
                WriteLiteral("\r\n                Авторизироваться через VK\r\n            ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-externalProvider", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["externalProvider"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1109, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"

        }

#line default
#line hidden
            BeginContext(1124, 56, true);
            WriteLiteral("        <p></p>\r\n        <!-- ko foreach: comments -->\r\n");
            EndContext();
            BeginContext(1904, 24, true);
            WriteLiteral("\r\n        <!-- /ko -->\r\n");
            EndContext();
#line 44 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
         if (Model.Comments.Count == 0)
        {

#line default
#line hidden
            BeginContext(1980, 51, true);
            WriteLiteral("            <h3>Оставьте комментарий первым!</h3>\r\n");
            EndContext();
#line 47 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
        }

#line default
#line hidden
            BeginContext(2042, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
         foreach (var comment in Model.Comments)
        {

#line default
#line hidden
            BeginContext(2105, 47, true);
            WriteLiteral("            <div class=\"single-comment-wrapper\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2152, "\"", 2184, 2);
#line 51 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
WriteAttributeValue("", 2157, comment.Id, 2157, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2168, "-comment-wrapper", 2168, 16, true);
            EndWriteAttribute();
            BeginContext(2185, 185, true);
            WriteLiteral(">\r\n                <div><img class=\"comment-ava\" src=\"https://storage.googleapis.com/youit/users/nophoto.jpg\" /></div>\r\n                <div>\r\n                    <div class=\"username\">");
            EndContext();
            BeginContext(2371, 16, false);
#line 54 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                     Write(comment.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2387, 31, true);
            WriteLiteral(" <span class=\"comment-created\">");
            EndContext();
            BeginContext(2419, 15, false);
#line 54 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                                                     Write(comment.Created);

#line default
#line hidden
            EndContext();
            BeginContext(2434, 61, true);
            WriteLiteral("</span></div>\r\n                    <div class=\"comment-text\">");
            EndContext();
            BeginContext(2496, 12, false);
#line 55 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                         Write(comment.Text);

#line default
#line hidden
            EndContext();
            BeginContext(2508, 88, true);
            WriteLiteral("</div>\r\n                    <span>\r\n                        <span class=\"comment-likes\">");
            EndContext();
            BeginContext(2597, 13, false);
#line 57 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                               Write(comment.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(2610, 89, true);
            WriteLiteral("</span>\r\n                        <a href=\"#\" data-bind=\"click: function() { setReaction(\'");
            EndContext();
            BeginContext(2700, 10, false);
#line 58 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                                           Write(comment.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2710, 82, true);
            WriteLiteral("\', \'\', true) }\">Like </a>\r\n                        <span class=\"comment-dislikes\">");
            EndContext();
            BeginContext(2793, 16, false);
#line 59 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                  Write(comment.Dislikes);

#line default
#line hidden
            EndContext();
            BeginContext(2809, 89, true);
            WriteLiteral("</span>\r\n                        <a href=\"#\" data-bind=\"click: function() { setReaction(\'");
            EndContext();
            BeginContext(2899, 10, false);
#line 60 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                                           Write(comment.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2909, 125, true);
            WriteLiteral("\', \'\', false) }\">Dislike </a>\r\n\r\n                        <a href=\"#\" data-bind=\"click: function() { displayAnswerCommentBox(\'");
            EndContext();
            BeginContext(3035, 10, false);
#line 62 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                                                       Write(comment.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3045, 107, true);
            WriteLiteral("\', true) }\"> <b>Ответить</b></a>\r\n                    </span>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
            BeginContext(3154, 65, true);
            WriteLiteral("            <div style=\"margin-left:65px;\">\r\n                <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3219, "\"", 3254, 2);
#line 68 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
WriteAttributeValue("", 3224, comment.Id, 3224, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3235, "-asnwer-comment-box", 3235, 19, true);
            EndWriteAttribute();
            BeginContext(3255, 169, true);
            WriteLiteral(" class=\"asnwer-comment-box\">\r\n                    <textarea style=\"width:100%;\"></textarea>\r\n                    <button data-bind=\"click: function() { answerToComment(\'");
            EndContext();
            BeginContext(3425, 10, false);
#line 70 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                                       Write(comment.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3435, 115, true);
            WriteLiteral("\') }\">Комментировать</button>\r\n                    <button data-bind=\"click: function() { displayAnswerCommentBox(\'");
            EndContext();
            BeginContext(3551, 10, false);
#line 71 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                                               Write(comment.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3561, 56, true);
            WriteLiteral("\', false) }\">Отмена</button>\r\n                </div>\r\n\r\n");
            EndContext();
#line 74 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                 foreach (var answer in comment.Answers)
                {

#line default
#line hidden
            BeginContext(3694, 55, true);
            WriteLiteral("                    <div class=\"single-comment-wrapper\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3749, "\"", 3780, 2);
#line 76 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
WriteAttributeValue("", 3754, answer.Id, 3754, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 3764, "-comment-wrapper", 3764, 16, true);
            EndWriteAttribute();
            BeginContext(3781, 209, true);
            WriteLiteral(">\r\n                        <div><img class=\"comment-ava\" src=\"https://storage.googleapis.com/youit/users/nophoto.jpg\" /></div>\r\n                        <div>\r\n                            <div class=\"username\">");
            EndContext();
            BeginContext(3991, 15, false);
#line 79 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                             Write(answer.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(4006, 31, true);
            WriteLiteral(" <span class=\"comment-created\">");
            EndContext();
            BeginContext(4038, 14, false);
#line 79 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                                                            Write(answer.Created);

#line default
#line hidden
            EndContext();
            BeginContext(4052, 69, true);
            WriteLiteral("</span></div>\r\n                            <div class=\"comment-text\">");
            EndContext();
            BeginContext(4122, 11, false);
#line 80 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                 Write(answer.Text);

#line default
#line hidden
            EndContext();
            BeginContext(4133, 104, true);
            WriteLiteral("</div>\r\n                            <span>\r\n                                <span class=\"comment-likes\">");
            EndContext();
            BeginContext(4238, 12, false);
#line 82 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                       Write(answer.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(4250, 97, true);
            WriteLiteral("</span>\r\n                                <a href=\"#\" data-bind=\"click: function() { setReaction(\'");
            EndContext();
            BeginContext(4348, 10, false);
#line 83 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                                                   Write(comment.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4358, 4, true);
            WriteLiteral("\', \'");
            EndContext();
            BeginContext(4363, 9, false);
#line 83 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                                                                  Write(answer.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4372, 86, true);
            WriteLiteral("\', true) }\">Like </a>\r\n                                <span class=\"comment-dislikes\">");
            EndContext();
            BeginContext(4459, 15, false);
#line 84 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                          Write(answer.Dislikes);

#line default
#line hidden
            EndContext();
            BeginContext(4474, 97, true);
            WriteLiteral("</span>\r\n                                <a href=\"#\" data-bind=\"click: function() { setReaction(\'");
            EndContext();
            BeginContext(4572, 10, false);
#line 85 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                                                   Write(comment.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4582, 4, true);
            WriteLiteral("\', \'");
            EndContext();
            BeginContext(4587, 9, false);
#line 85 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                                                                  Write(answer.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4596, 129, true);
            WriteLiteral("\', false) }\">Dislike </a>\r\n\r\n                                <a href=\"#\" data-bind=\"click: function() { displayAnswerCommentBox(\'");
            EndContext();
            BeginContext(4726, 9, false);
#line 87 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                                                                                               Write(answer.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4735, 131, true);
            WriteLiteral("\', true) }\"> <b>Ответить</b></a>\r\n                            </span>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 91 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
                }

#line default
#line hidden
            BeginContext(4885, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 93 "C:\Users\omarf\Desktop\site\Web\Views\Shared\_PostComments.cshtml"
        }

#line default
#line hidden
            BeginContext(4916, 3197, true);
            WriteLiteral(@"    </div>

<script>
    class Comment {
        constructor(name, text) {
            this.name = name;
            this.created = 'секунду назад';
            this.text = text;
            this.likes = 0;
            this.dislikes = 0;
        }
    }

    function AppCommentModel() {
        let self = this;
        self.comments = ko.observableArray([]);
        self.answerBoxVisibe = ko.observable(false);

        self.displayAnswerCommentBox = function (commentId, isVisible) {
            $('.asnwer-comment-box').hide();
            const answerComment = $('#' + commentId + '-asnwer-comment-box');
            isVisible ? answerComment.show() : answerComment.hide();
        }

        self.setReaction = function (parentCommentId, commentId, currentReaction) {

            $.ajax({
                url: '/comment/setcommentreaction',
                type: 'POST',
                contentType: ""application/json"",
                data: JSON.stringify({
                    Parent");
            WriteLiteral(@"CommentId: parentCommentId,
                    CommentId: commentId,
                    Liked: currentReaction
                }),
                success: (data) => {
                    $('#' + commentId + '-comment-wrapper .comment-likes').text(data.likes);
                    $('#' + commentId + '-comment-wrapper .comment-dislikes').text(data.dislikes);
                },
                error: (error) => {
                    console.log(error);
                }
            });
        }



        self.answerToComment = function (commentId) {
            const text = $('#' + commentId + '-asnwer-comment-box textarea').val();
            $.ajax({
                url: '/comment/answercomment',
                type: 'POST',
                contentType: ""application/json"",
                data: JSON.stringify({
                    ParentCommentId: commentId,
                    Text: text
                }),
                success: (data) => {
                    $('#' + comme");
            WriteLiteral(@"ntId + '-asnwer-comment-box textarea').val('');
                    //self.comments.push(new Comment($('#username-hidden').val(), text));
                    $('.answer-box').hide();

                },
                error: (error) => {
                    console.log(error);
                }
            });
        }

        self.addComment = function () {
            const text = $('#comment-box').val();
            $('#comment-box').val('');
            const postId = $('#post-id-hidden').val();

            $.ajax({
                url: '/comment/addcomment',
                type: 'POST',
                contentType: ""application/json"",
                data: JSON.stringify({
                    Text: text,
                    PostId: postId
                }),
                success: (data) => {
                    self.comments.push(new Comment($('#username-hidden').val(), text));
                },
                error: (error) => {
                    console.log(error");
            WriteLiteral(");\r\n                }\r\n            });\r\n        }\r\n    }\r\n\r\n    ko.applyBindings(new AppCommentModel());\r\n\r\n</script>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Services.DTOs.PostDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
