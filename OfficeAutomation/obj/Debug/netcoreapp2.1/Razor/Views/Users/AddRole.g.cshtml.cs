#pragma checksum "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b53d2e7f8c2d6ef945d710ef955261bbe5dd39da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_AddRole), @"mvc.1.0.view", @"/Views/Users/AddRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/AddRole.cshtml", typeof(AspNetCore.Views_Users_AddRole))]
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
#line 1 "D:\OfficeAutomation\OfficeAutomation\Views\_ViewImports.cshtml"
using OfficeAutomation;

#line default
#line hidden
#line 2 "D:\OfficeAutomation\OfficeAutomation\Views\_ViewImports.cshtml"
using OfficeAutomation.DAL.Helper;

#line default
#line hidden
#line 1 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
using OfficeAutomation.DAL;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b53d2e7f8c2d6ef945d710ef955261bbe5dd39da", @"/Views/Users/AddRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1092c2d1af773145c1a29f194d573162fd48e90", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_AddRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OfficeAutomation.Models.effect>>
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
            BeginContext(74, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(99, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cfdc3a4e8f441f49c3feb08e39e042a", async() => {
                BeginContext(105, 150, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1\">\r\n    <title>添加角色</title>\r\n    ");
                EndContext();
                BeginContext(255, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3dfd6fcfe2704aa3bff7101323bf5e6c", async() => {
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
                BeginContext(299, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(305, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7ec654b381614811bda69940cd00ce9c", async() => {
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
                BeginContext(354, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(362, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eed47396a7a47409df2b5bc3b89cfad", async() => {
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
                BeginContext(407, 2, true);
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
            BeginContext(416, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(418, 5186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3bb4a7a6195438eb56fdc5ba00ed4f5", async() => {
                BeginContext(456, 190, true);
                WriteLiteral("\r\n    <div class=\"layui-container\">\r\n        <div class=\"layui-row \">\r\n\r\n            <div class=\"layui-col-md12\">\r\n\r\n                <div style=\"margin-top: 3.5em; \">\r\n\r\n                    ");
                EndContext();
                BeginContext(646, 2918, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c046402b736413b8ae0eba0bf829b59", async() => {
                    BeginContext(671, 230, true);
                    WriteLiteral("\r\n\r\n\r\n                        <div class=\"layui-form-item\">\r\n                            <label class=\"layui-form-label\"><span class=\"text-red\">*</span>角色名称：</label>\r\n                            <div class=\"layui-input-block\">\r\n\r\n");
                    EndContext();
#line 29 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
                                  
                                    if (ViewData["value"] != null)
                                    {

#line default
#line hidden
                    BeginContext(1044, 178, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"dicvalue\" id=\"dicvalue\" required lay-verify=\"required\" placeholder=\"请输入角色\" autocomplete=\"off\" class=\"layui-input\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1222, "\"", 1248, 1);
#line 32 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
WriteAttributeValue("", 1230, ViewData["value"], 1230, 18, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1249, 3, true);
                    WriteLiteral(">\r\n");
                    EndContext();
#line 33 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                    BeginContext(1372, 181, true);
                    WriteLiteral("                                        <input type=\"text\" name=\"dicvalue\" id=\"dicvalue\" required lay-verify=\"required\" placeholder=\"请输入角色\" autocomplete=\"off\" class=\"layui-input\">\r\n");
                    EndContext();
#line 37 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
                                    }
                                

#line default
#line hidden
                    BeginContext(1627, 290, true);
                    WriteLiteral(@"                            </div>
                        </div>

                        <div class=""layui-form-item"">
                            <label class=""layui-form-label""><span class=""text-red"">*</span>功能：</label>
                            <div class=""layui-input-block"">
");
                    EndContext();
#line 45 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
                                 foreach (var item in Model)
                                {
                                    if ((int)ViewData["id"] == 0)
                                        {

#line default
#line hidden
                    BeginContext(2124, 80, true);
                    WriteLiteral("                                            <input type=\"checkbox\" name=\"effect\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2204, "\"", 2220, 1);
#line 49 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
WriteAttributeValue("", 2212, item.id, 2212, 8, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginWriteAttribute("title", " title=\"", 2221, "\"", 2239, 1);
#line 49 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
WriteAttributeValue("", 2229, item.name, 2229, 10, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2240, 3, true);
                    WriteLiteral(">\r\n");
                    EndContext();
#line 50 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
                                            continue;
                                        }
                                    DAL_Dictionary dalDictionary = new DAL_Dictionary();
                                    int count = dalDictionary.IfRelatedByRole(ViewData["value"].ToString(), item.id);
                                    if (count > 0)
                                    {

#line default
#line hidden
                    BeginContext(2641, 76, true);
                    WriteLiteral("                                        <input type=\"checkbox\" name=\"effect\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2717, "\"", 2733, 1);
#line 56 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
WriteAttributeValue("", 2725, item.id, 2725, 8, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginWriteAttribute("title", " title=\"", 2734, "\"", 2752, 1);
#line 56 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
WriteAttributeValue("", 2742, item.name, 2742, 10, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2753, 11, true);
                    WriteLiteral(" checked>\r\n");
                    EndContext();
#line 57 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                    BeginContext(2884, 76, true);
                    WriteLiteral("                                        <input type=\"checkbox\" name=\"effect\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 2960, "\"", 2976, 1);
#line 60 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
WriteAttributeValue("", 2968, item.id, 2968, 8, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginWriteAttribute("title", " title=\"", 2977, "\"", 2995, 1);
#line 60 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
WriteAttributeValue("", 2985, item.name, 2985, 10, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(2996, 3, true);
                    WriteLiteral(">\r\n");
                    EndContext();
#line 61 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
                                    }

                                }

#line default
#line hidden
                    BeginContext(3075, 482, true);
                    WriteLiteral(@"                            </div>
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
                BeginContext(3564, 983, true);
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
        var once = $(""#dicvalue"").val();
        form.on('submit(formDemo)', function (data) {
            var index = layer.msg('数据提交中，请稍候', { icon: 16, shade: 0.01, time: 10 });
            var upData = data.field;

            var effectid = """";
            $('input:checkbox[name=effect]:checked').each(function(i){
                if(0==i){
                    effectid = $(this).val();
                }else{
                    effectid += ("",""+$(this).val());
                }
            });

            $.ajax({
                type: ""post"",
                url: ""../Users/UpdateRole"",
                data: {
                    id:");
                EndContext();
                BeginContext(4548, 14, false);
#line 105 "D:\OfficeAutomation\OfficeAutomation\Views\Users\AddRole.cshtml"
                  Write(ViewData["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(4562, 1035, true);
                WriteLiteral(@",
                    dicvalue : upData.dicvalue,
                    reserve1: effectid,
                    NotMapped:once
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
                    }
                    console.log(data);

                }
            });

            return false;
        });

    });
    ");
                WriteLiteral("</script>\r\n");
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
            BeginContext(5604, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OfficeAutomation.Models.effect>> Html { get; private set; }
    }
}
#pragma warning restore 1591
