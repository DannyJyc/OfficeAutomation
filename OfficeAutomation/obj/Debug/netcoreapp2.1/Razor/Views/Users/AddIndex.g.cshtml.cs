#pragma checksum "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "506eb3f8588007f53b3928b0595149ff055b1320"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_AddIndex), @"mvc.1.0.view", @"/Views/Users/AddIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/AddIndex.cshtml", typeof(AspNetCore.Views_Users_AddIndex))]
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
#line 1 "D:\项目\OfficeAutomation\OfficeAutomation\Views\_ViewImports.cshtml"
using OfficeAutomation;

#line default
#line hidden
#line 2 "D:\项目\OfficeAutomation\OfficeAutomation\Views\_ViewImports.cshtml"
using OfficeAutomation.DAL.Helper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"506eb3f8588007f53b3928b0595149ff055b1320", @"/Views/Users/AddIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1092c2d1af773145c1a29f194d573162fd48e90", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_AddIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OfficeAutomation.Models.view_users_college>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/s.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/extend.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plus/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(78, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4213fe78c4944158b43273344175d9e8", async() => {
                BeginContext(84, 150, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1\">\r\n    <title>添加用户</title>\r\n    ");
                EndContext();
                BeginContext(234, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e04e90de6026437dbd08376566673c00", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(278, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(284, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f4fddfa222be48d49a179c7bdd762fbe", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(333, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(341, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1224aefd34194d62a0453f8c3dfeb13e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(386, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(395, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(397, 8096, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64196e6bb0274c2884f974259a99b22c", async() => {
                BeginContext(435, 190, true);
                WriteLiteral("\r\n    <div class=\"layui-container\">\r\n        <div class=\"layui-row \">\r\n\r\n            <div class=\"layui-col-md12\">\r\n\r\n                <div style=\"margin-top: 3.5em; \">\r\n\r\n                    ");
                EndContext();
                BeginContext(625, 4395, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76044fddf45e4019bbedb21beab045f2", async() => {
                    BeginContext(650, 230, true);
                    WriteLiteral("\r\n\r\n\r\n                        <div class=\"layui-form-item\">\r\n                            <label class=\"layui-form-label\"><span class=\"text-red\">*</span>用户姓名：</label>\r\n                            <div class=\"layui-input-block\">\r\n\r\n");
                    EndContext();
#line 29 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                  
                                    if (Model != null)
                                    {

#line default
#line hidden
                    BeginContext(1011, 160, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"name\" required lay-verify=\"required\" placeholder=\"请输入姓名\" autocomplete=\"off\" class=\"layui-input\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1171, "\"", 1190, 1);
#line 32 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
WriteAttributeValue("", 1179, Model.name, 1179, 11, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1191, 3, true);
                    WriteLiteral(">\r\n");
                    EndContext();
#line 33 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                    BeginContext(1314, 163, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"name\" required lay-verify=\"required\" placeholder=\"请输入姓名\" autocomplete=\"off\" class=\"layui-input\">\r\n");
                    EndContext();
#line 37 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                    }
                                

#line default
#line hidden
                    BeginContext(1551, 293, true);
                    WriteLiteral(@"                            </div>
                        </div>

                        <div class=""layui-form-item"">
                            <label class=""layui-form-label""><span class=""text-red"">*</span>用户名：</label>
                            <div class=""layui-input-block"">

");
                    EndContext();
#line 46 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                  
                                    if (Model != null)
                                    {

#line default
#line hidden
                    BeginContext(1975, 165, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"username\" required lay-verify=\"required\" placeholder=\"请输入用户名\" autocomplete=\"off\" class=\"layui-input\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2140, "\"", 2163, 1);
#line 49 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
WriteAttributeValue("", 2148, Model.username, 2148, 15, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2164, 73, true);
                    WriteLiteral(">\r\n                                        <input type=\"hidden\" id=\"role\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2237, "\"", 2260, 1);
#line 50 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
WriteAttributeValue("", 2245, Model.dicvalue, 2245, 15, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2261, 78, true);
                    WriteLiteral(" />\r\n                                        <input type=\"hidden\" id=\"college\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2339, "\"", 2366, 1);
#line 51 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
WriteAttributeValue("", 2347, Model.college_name, 2347, 19, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2367, 4, true);
                    WriteLiteral("/>\r\n");
                    EndContext();
#line 52 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                    BeginContext(2491, 168, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"username\" required lay-verify=\"required\" placeholder=\"请输入用户名\" autocomplete=\"off\" class=\"layui-input\">\r\n");
                    EndContext();
#line 56 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                    }
                                

#line default
#line hidden
                    BeginContext(2733, 290, true);
                    WriteLiteral(@"                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label""><span class=""text-red"">*</span>密码：</label>
                            <div class=""layui-input-block"">

");
                    EndContext();
#line 64 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                  
                                    if (Model != null)
                                    {

#line default
#line hidden
                    BeginContext(3154, 164, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"password\" required lay-verify=\"required\" placeholder=\"请输入密码\" autocomplete=\"off\" class=\"layui-input\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 3318, "\"", 3341, 1);
#line 67 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
WriteAttributeValue("", 3326, Model.password, 3326, 15, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3342, 3, true);
                    WriteLiteral(">\r\n");
                    EndContext();
#line 68 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                    BeginContext(3465, 167, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"password\" required lay-verify=\"required\" placeholder=\"请输入密码\" autocomplete=\"off\" class=\"layui-input\">\r\n");
                    EndContext();
#line 72 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                    }
                                

#line default
#line hidden
                    BeginContext(3706, 1307, true);
                    WriteLiteral(@"                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label""><span class=""text-red"">*</span>选择学院：</label>
                            <div class=""layui-input-block"">
                                <select name=""college"" lay-filter=""province"" lay-search="""" lay-verify=""required""></select>
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label""><span class=""text-red"">*</span>选择角色：</label>
                            <div class=""layui-input-block"">
                                <select name=""role"" lay-filter=""province"" lay-search="""" lay-verify=""required""></select>
                            </div>
                        </div>

                        <div class=""layui-form-item"">
                            <div class=""layui-input-block"">
             ");
                    WriteLiteral(@"                   <button class=""layui-btn"" lay-submit lay-filter=""formDemo"">立即提交</button>
                                <button type=""reset"" class=""layui-btn layui-btn-primary"">重置</button>
                            </div>
                        </div>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5020, 2298, true);
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>

    <script>

    var layui = layui.config({
        base: '/plus/' //静态资源所在路径
    }).use(['layer', 'form', 'jquery','upload'], function () {
        var form = layui.form;
        var $ = layui.jquery;
        var layer = layui.layer;

        $(""select[name='role']"").empty();
        $.get(""../Users/ListRole"", function (result) {

            console.log(result);
            var role = $(""#role"").val();
            if (role == 0) {
                $(""select[name='role']"").append('<option selected = ""selected"" value=""0"">超级管理员</option>');
            } else {
                $(""select[name='role']"").append('<option value=""0"">超级管理员</option>');

            }
            for (var i = 0; i < result.length; i++) {
                if (role == result[i].value) {
                    $(""select[name='role']"").append('<option selected = ""selected"" value=""' + result[i].value + '"">' + result[i].value + '</option>');
       ");
                WriteLiteral(@"             continue;
                }
                $(""select[name='role']"").append('<option value=""' + result[i].value + '"">' + result[i].value+'</option>');
            }

            form.render('select'); //刷新select选择框渲染
        });
        $(""select[name='college']"").empty();
        $.get(""../Users/GetCollege"", function (result) {

            console.log(result);
            var college = $(""#college"").val();
            for (var i = 0; i < result.length; i++) {
                if (college == result[i].name) {
                    $(""select[name='college']"").append('<option selected = ""selected"" value=""' + result[i].id + '"">' + result[i].name + '</option>');
                    continue;
                }
                $(""select[name='college']"").append('<option value=""' + result[i].id + '"">' + result[i].name + '</option>');
            }

            form.render('select'); //刷新select选择框渲染
        });
        form.on('submit(formDemo)', function (data) {
            var ind");
                WriteLiteral("ex = layer.msg(\'数据提交中，请稍候\', { icon: 16, shade: 0.01, time: 10 });\r\n            var upData = data.field;\r\n\r\n            $.ajax({\r\n                type: \"post\",\r\n                url: \"../Users/AddUser\",\r\n                data: {\r\n                    id:");
                EndContext();
                BeginContext(7319, 14, false);
#line 154 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Users\AddIndex.cshtml"
                  Write(ViewData["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(7333, 1153, true);
                WriteLiteral(@",
                    name: upData.name,
                    username: upData.username,
                    password: upData.password,
                    dicvalue: upData.role,
                    collegeid: upData.college
                },
                dataType: ""json"",
                success: function(data) {
                    layer.close(index);
                    if (data.code == ""0"" || data.code == 0) {
                        layer.alert(""操作成功"", { icon: 6 },
                            function (index) {
                                var index = parent.layer.getFrameIndex(window.name); //先得到当前iframe层的索引
                                parent.layer.close(index); //再执行关闭
                                parent.location.reload(); // 刷新父级
                        });

                        //location.reload();
                        return false;
                    } else {
                        layer.alert(data.msg, { icon: 5 });
                    }
                 ");
                WriteLiteral("   console.log(data);\r\n\r\n                }\r\n            });\r\n\r\n            return false;\r\n        });\r\n\r\n    });\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8493, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OfficeAutomation.Models.view_users_college> Html { get; private set; }
    }
}
#pragma warning restore 1591
