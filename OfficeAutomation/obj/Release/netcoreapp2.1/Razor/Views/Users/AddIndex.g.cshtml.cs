#pragma checksum "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82e8715cc60da144dd798f3d2ba6ee7cfe4b623a"
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
#line 1 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\_ViewImports.cshtml"
using OfficeAutomation;

#line default
#line hidden
#line 2 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\_ViewImports.cshtml"
using OfficeAutomation.DAL.Helper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82e8715cc60da144dd798f3d2ba6ee7cfe4b623a", @"/Views/Users/AddIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f4f90d70adeb54b7b2218114d7f7b67819af638", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(50, 24, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(74, 309, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3efebbd3c39c40e9a05480e9c82bafc6", async() => {
                BeginContext(80, 146, true);
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1\">\n    <title>添加用户</title>\n    ");
                EndContext();
                BeginContext(226, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aded1e92ac4f4fd8b0652c0ad473e264", async() => {
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
                BeginContext(270, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(275, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e063c29dcc114f678ee133b8be3827c8", async() => {
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
                BeginContext(324, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(330, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd793e912ad489db85fcdec3b6c6ba9", async() => {
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
                BeginContext(375, 1, true);
                WriteLiteral("\n");
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
            BeginContext(383, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(384, 7923, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70eb0b8596204bdda5a83ea91e5ee42f", async() => {
                BeginContext(422, 182, true);
                WriteLiteral("\n    <div class=\"layui-container\">\n        <div class=\"layui-row \">\n\n            <div class=\"layui-col-md12\">\n\n                <div style=\"margin-top: 3.5em; \">\n\n                    ");
                EndContext();
                BeginContext(604, 4322, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "339473003e4349edb875f15d03457268", async() => {
                    BeginContext(629, 223, true);
                    WriteLiteral("\n\n\n                        <div class=\"layui-form-item\">\n                            <label class=\"layui-form-label\"><span class=\"text-red\">*</span>用户姓名：</label>\n                            <div class=\"layui-input-block\">\n\n");
                    EndContext();
#line 29 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                  
                                    if (Model != null)
                                    {

#line default
#line hidden
                    BeginContext(980, 160, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"name\" required lay-verify=\"required\" placeholder=\"请输入姓名\" autocomplete=\"off\" class=\"layui-input\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1140, "\"", 1159, 1);
#line 32 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
WriteAttributeValue("", 1148, Model.name, 1148, 11, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1160, 2, true);
                    WriteLiteral(">\n");
                    EndContext();
#line 33 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                    BeginContext(1279, 162, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"name\" required lay-verify=\"required\" placeholder=\"请输入姓名\" autocomplete=\"off\" class=\"layui-input\">\n");
                    EndContext();
#line 37 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                    }
                                

#line default
#line hidden
                    BeginContext(1513, 286, true);
                    WriteLiteral(@"                            </div>
                        </div>

                        <div class=""layui-form-item"">
                            <label class=""layui-form-label""><span class=""text-red"">*</span>用户名：</label>
                            <div class=""layui-input-block"">

");
                    EndContext();
#line 46 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                  
                                    if (Model != null)
                                    {

#line default
#line hidden
                    BeginContext(1927, 165, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"username\" required lay-verify=\"required\" placeholder=\"请输入用户名\" autocomplete=\"off\" class=\"layui-input\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2092, "\"", 2115, 1);
#line 49 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
WriteAttributeValue("", 2100, Model.username, 2100, 15, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2116, 72, true);
                    WriteLiteral(">\n                                        <input type=\"hidden\" id=\"role\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2188, "\"", 2211, 1);
#line 50 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
WriteAttributeValue("", 2196, Model.dicvalue, 2196, 15, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2212, 77, true);
                    WriteLiteral(" />\n                                        <input type=\"hidden\" id=\"college\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2289, "\"", 2316, 1);
#line 51 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
WriteAttributeValue("", 2297, Model.college_name, 2297, 19, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2317, 3, true);
                    WriteLiteral("/>\n");
                    EndContext();
#line 52 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                    BeginContext(2437, 167, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"username\" required lay-verify=\"required\" placeholder=\"请输入用户名\" autocomplete=\"off\" class=\"layui-input\">\n");
                    EndContext();
#line 56 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                    }
                                

#line default
#line hidden
                    BeginContext(2676, 284, true);
                    WriteLiteral(@"                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label""><span class=""text-red"">*</span>密码：</label>
                            <div class=""layui-input-block"">

");
                    EndContext();
#line 64 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                  
                                    if (Model != null)
                                    {

#line default
#line hidden
                    BeginContext(3088, 164, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"password\" required lay-verify=\"required\" placeholder=\"请输入密码\" autocomplete=\"off\" class=\"layui-input\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 3252, "\"", 3275, 1);
#line 67 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
WriteAttributeValue("", 3260, Model.password, 3260, 15, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3276, 2, true);
                    WriteLiteral(">\n");
                    EndContext();
#line 68 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                    BeginContext(3395, 166, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"password\" required lay-verify=\"required\" placeholder=\"请输入密码\" autocomplete=\"off\" class=\"layui-input\">\n");
                    EndContext();
#line 72 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
                                    }
                                

#line default
#line hidden
                    BeginContext(3633, 1286, true);
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
                    WriteLiteral(@"  <button class=""layui-btn"" lay-submit lay-filter=""formDemo"">立即提交</button>
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
                BeginContext(4926, 2239, true);
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
                    continue;
      ");
                WriteLiteral(@"          }
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
            var index = layer.msg('数据提交中，请稍候', { icon: 16, shade: 0.01,");
                WriteLiteral(" time: 10 });\n            var upData = data.field;\n\n            $.ajax({\n                type: \"post\",\n                url: \"../Users/AddUser\",\n                data: {\n                    id:");
                EndContext();
                BeginContext(7166, 14, false);
#line 154 "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Users\AddIndex.cshtml"
                  Write(ViewData["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(7180, 1120, true);
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
                    console.log(data);

");
                WriteLiteral("                }\n            });\n\n            return false;\n        });\n\n    });\n    </script>\n");
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
            BeginContext(8307, 8, true);
            WriteLiteral("\n</html>");
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
