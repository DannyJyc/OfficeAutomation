#pragma checksum "C:\Users\DannyJiang\Desktop\OfficeAutomation-master\OfficeAutomation\Views\Home\Theme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83b96b9fec9c19807a15ecf63e7753bbbbc0728f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Theme), @"mvc.1.0.view", @"/Views/Home/Theme.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Theme.cshtml", typeof(AspNetCore.Views_Home_Theme))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83b96b9fec9c19807a15ecf63e7753bbbbc0728f", @"/Views/Home/Theme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f4f90d70adeb54b7b2218114d7f7b67819af638", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Theme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1499, true);
            WriteLiteral(@"<!-- 主题设置模板 -->

<script type=""text/html"" template lay-done=""layui.data.theme();"">
    {{#
    var local = layui.data(layui.setter.tableName)
    ,theme = local.theme || {}
    ,themeColorIndex =  parseInt((theme && theme.color) ? theme.color.index : 0) || 0;
    }}

    <div class=""layui-card-header"">
        配色方案
    </div>
    <div class=""layui-card-body layadmin-setTheme"">
        <ul class=""layadmin-setTheme-color"">
            {{# layui.each(layui.setter.theme.color, function(index, item){ }}
            <li layadmin-event=""setTheme"" data-index=""{{ index }}"" data-alias=""{{ item.alias }}""
                {{ index === themeColorIndex ? 'class=""layui-this""' : '' }} title=""{{ item.alias }}"">
                <div class=""layadmin-setTheme-header"" style=""background-color: {{ item.header }};""></div>
                <div class=""layadmin-setTheme-side"" style=""background-color: {{ item.main }};"">
                    <div class=""layadmin-setTheme-logo"" style=""background-color: {{ item.logo }};""></div>
             ");
            WriteLiteral(@"   </div>
            </li>
            {{# }); }}
        </ul>
    </div>
</script>

<script>
    layui.data.theme = function () {
        layui.use('form', function () {
            var form = layui.form
                , admin = layui.admin;

            //监听隐藏开关
            form.on('switch(system-theme-sideicon)', function () {
                admin.theme({
                    hideSideIcon: this.checked
                })
            });
        });
    };
</script>");
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
