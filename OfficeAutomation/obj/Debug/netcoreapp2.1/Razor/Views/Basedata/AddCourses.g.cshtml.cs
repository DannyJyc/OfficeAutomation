#pragma checksum "D:\项目\OfficeAutomation\OfficeAutomation\Views\Basedata\AddCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c8330df554ef5d941a7fbbc5e1234fddf1c2653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basedata_AddCourses), @"mvc.1.0.view", @"/Views/Basedata/AddCourses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Basedata/AddCourses.cshtml", typeof(AspNetCore.Views_Basedata_AddCourses))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c8330df554ef5d941a7fbbc5e1234fddf1c2653", @"/Views/Basedata/AddCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1092c2d1af773145c1a29f194d573162fd48e90", @"/Views/_ViewImports.cshtml")]
    public class Views_Basedata_AddCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OfficeAutomation.Models.view_courses_teachers>
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
            BeginContext(54, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(79, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc581388c40544409903089827011bb5", async() => {
                BeginContext(85, 150, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1\">\r\n    <title>添加课程</title>\r\n    ");
                EndContext();
                BeginContext(235, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb2db24dad704446b1475dca207aab8c", async() => {
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
                BeginContext(279, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(285, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0065f9f9cf034e889ca1c5c90b7b520f", async() => {
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
                BeginContext(334, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(342, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e94b931c8307447faed4b1924d153afe", async() => {
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
                BeginContext(387, 2, true);
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
            BeginContext(396, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(398, 6880, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cadbffe99be48e5926c9aaa5029298d", async() => {
                BeginContext(436, 188, true);
                WriteLiteral("\r\n    <div class=\"layui-container\">\r\n        <div class=\"layui-row \">\r\n\r\n            <div class=\"layui-col-md12\">\r\n                <div style=\"margin-top: 3.5em; \">\r\n\r\n                    ");
                EndContext();
                BeginContext(624, 4089, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a45921892b1465786226b64e57f601d", async() => {
                    BeginContext(649, 230, true);
                    WriteLiteral("\r\n\r\n\r\n                        <div class=\"layui-form-item\">\r\n                            <label class=\"layui-form-label\"><span class=\"text-red\">*</span>课程名称：</label>\r\n                            <div class=\"layui-input-block\">\r\n\r\n");
                    EndContext();
#line 27 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Basedata\AddCourses.cshtml"
                                  
                                    if (Model != null)
                                    {

#line default
#line hidden
                    BeginContext(1010, 160, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"name\" required lay-verify=\"required\" placeholder=\"请输入名称\" autocomplete=\"off\" class=\"layui-input\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1170, "\"", 1189, 1);
#line 30 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Basedata\AddCourses.cshtml"
WriteAttributeValue("", 1178, Model.name, 1178, 11, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1190, 3, true);
                    WriteLiteral(">\r\n");
                    EndContext();
                    BeginContext(1195, 74, true);
                    WriteLiteral("                                        <input type=\"hidden\" id=\"teachers\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1269, "\"", 1295, 1);
#line 32 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Basedata\AddCourses.cshtml"
WriteAttributeValue("", 1277, Model.teachers_id, 1277, 18, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1296, 5, true);
                    WriteLiteral(" />\r\n");
                    EndContext();
#line 33 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Basedata\AddCourses.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                    BeginContext(1421, 163, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"name\" required lay-verify=\"required\" placeholder=\"请输入名称\" autocomplete=\"off\" class=\"layui-input\">\r\n");
                    EndContext();
#line 37 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Basedata\AddCourses.cshtml"
                                    }
                                

#line default
#line hidden
                    BeginContext(1658, 294, true);
                    WriteLiteral(@"                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label""><span class=""text-red"">*</span>开始/结束周：</label>
                            <div class=""layui-input-block"">

");
                    EndContext();
#line 45 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Basedata\AddCourses.cshtml"
                                  
                                    if (Model != null)
                                    {

#line default
#line hidden
                    BeginContext(2083, 232, true);
                    WriteLiteral("                                        <div class=\"layui-input-inline\" style=\"width: 100px;\">\r\n                                            <input type=\"text\" name=\"startweek\" placeholder=\"开始周\" autocomplete=\"off\" class=\"layui-input\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2315, "\"", 2339, 1);
#line 49 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Basedata\AddCourses.cshtml"
WriteAttributeValue("", 2323, Model.startweek, 2323, 16, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2340, 358, true);
                    WriteLiteral(@">
                                        </div>
                                        <div class=""layui-form-mid"">-</div>
                                        <div class=""layui-input-inline"" style=""width: 100px;"">
                                            <input type=""text"" name=""endweek"" placeholder=""结束周"" autocomplete=""off"" class=""layui-input""");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2698, "\"", 2720, 1);
#line 53 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Basedata\AddCourses.cshtml"
WriteAttributeValue("", 2706, Model.endweek, 2706, 14, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2721, 152, true);
                    WriteLiteral(">\r\n                                        </div>\r\n                                        <div class=\"layui-form-mid layui-word-aux\">空白，默认为1-18</div>\r\n");
                    EndContext();
#line 56 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Basedata\AddCourses.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                    BeginContext(2993, 742, true);
                    WriteLiteral(@"                                        <div class=""layui-input-inline"" style=""width: 100px;"">
                                            <input type=""text"" name=""startweek"" placeholder=""开始周"" autocomplete=""off"" class=""layui-input"">
                                        </div>
                                        <div class=""layui-form-mid"">-</div>
                                        <div class=""layui-input-inline"" style=""width: 100px;"">
                                            <input type=""text"" name=""endweek"" placeholder=""结束周"" autocomplete=""off"" class=""layui-input"">
                                        </div>
                                        <div class=""layui-form-mid layui-word-aux"">空白，默认为1-18</div>
");
                    EndContext();
#line 67 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Basedata\AddCourses.cshtml"
                                    }
                                

#line default
#line hidden
                    BeginContext(3809, 897, true);
                    WriteLiteral(@"                            </div>
                        </div>

                        <div class=""layui-form-item"">
                            <label class=""layui-form-label""><span class=""text-red"">*</span>选择教师：</label>
                            <div class=""layui-input-block"">
                                <select name=""teachers"" lay-filter=""province"" lay-search="""" lay-verify=""required""></select>
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <div class=""layui-input-block"">
                                <button class=""layui-btn"" lay-submit lay-filter=""formDemo"">立即提交</button>
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
                BeginContext(4713, 1366, true);
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


        $(""select[name='teachers']"").empty();
        $.get(""../Basedata/GetTeachers"", function (result) {

            console.log(result);
            var teachers = $(""#teachers"").val();
            for (var i = 0; i < result.length; i++) {
                if (teachers == result[i].id) {
                    $(""select[name='teachers']"").append('<option selected = ""selected"" value=""' + result[i].id + '"">' + result[i].name + '</option>');
                    continue;
                }
                $(""select[name='teachers']"").append('<option value=""' + result[i].id + '"">' + result[i].name + '</option>');
            }

            form.render('select'); //刷新select选择框渲染
    ");
                WriteLiteral(@"    });
        form.on('submit(formDemo)', function (data) {
            var index = layer.msg('数据提交中，请稍候', { icon: 16, shade: 0.01, time: 10 });
            var upData = data.field;

            $.ajax({
                type: ""post"",
                url: ""../Basedata/UpdateCourses"",
                data: {
                    id:");
                EndContext();
                BeginContext(6080, 14, false);
#line 123 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Basedata\AddCourses.cshtml"
                  Write(ViewData["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(6094, 1177, true);
                WriteLiteral(@",
                    name: upData.name,
                    teachersid: upData.teachers,
                    startweek: upData.startweek,
                    endweek: upData.endweek,
                    week: upData.week,
                    option:upData.option
                },
                dataType: ""json"",
                success: function(data) {
                    layer.close(index);
                    if (data.code == ""0"" || data.code == 0) {
                        layer.alert(""操作成功"", { icon: 6 },
                        function(index) {
                            var index = parent.layer.getFrameIndex(window.name); //先得到当前iframe层的索引
                            parent.layer.close(index); //再执行关闭
                            parent.location.reload(); // 刷新父级
                        });

                        //location.reload();
                        return false;
                    } else {
                        layer.alert(data.msg, { icon: 5 });
                ");
                WriteLiteral("    }\r\n                    console.log(data);\r\n\r\n                }\r\n            });\r\n\r\n            return false;\r\n        });\r\n\r\n    });\r\n    </script>\r\n");
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
            BeginContext(7278, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OfficeAutomation.Models.view_courses_teachers> Html { get; private set; }
    }
}
#pragma warning restore 1591
