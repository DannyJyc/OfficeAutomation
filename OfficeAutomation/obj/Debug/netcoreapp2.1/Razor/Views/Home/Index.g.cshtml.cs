#pragma checksum "D:\项目\OfficeAutomation\OfficeAutomation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51431b56ac3a867f59007843dea6cd2ac366b250"
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
#line 1 "D:\项目\OfficeAutomation\OfficeAutomation\Views\_ViewImports.cshtml"
using OfficeAutomation;

#line default
#line hidden
#line 2 "D:\项目\OfficeAutomation\OfficeAutomation\Views\_ViewImports.cshtml"
using OfficeAutomation.DAL.Helper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51431b56ac3a867f59007843dea6cd2ac366b250", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1092c2d1af773145c1a29f194d573162fd48e90", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/plus/layui/css/layui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/plus/style/admin.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plus/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-layout-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(27, 528, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b369b50d90e840509c89869e8f1d2b1e", async() => {
                BeginContext(33, 308, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>自动化办公系统</title>
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=0"">

    ");
                EndContext();
                BeginContext(341, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4dc33a8c5c0647c0bcd5665d3685734e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(412, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(418, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "16ce80e6ac2c4a0382c6a7ab02ec111f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(485, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(491, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e827f05fc17042369b205b409bec10ba", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(546, 2, true);
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
            BeginContext(555, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(559, 11210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7a0975142d84ef89dca2d7b10ddce20", async() => {
                BeginContext(591, 1665, true);
                WriteLiteral(@"
    <div id=""LAY_app"">
        <div class=""layui-layout layui-layout-admin"">
            <div class=""layui-header"">
                <!-- 头部区域 -->
                <ul class=""layui-nav layui-layout-left"">
                    <li class=""layui-nav-item layadmin-flexible"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""flexible"" title=""侧边伸缩"">
                            <i class=""layui-icon layui-icon-shrink-right"" id=""LAY_app_flexible""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <a href=""http://www.lnboxue.com/"" target=""_blank"" title=""官网"">
                            <i class=""layui-icon layui-icon-website""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""refresh"" title=""刷新""> 
                            <i class=""layui-");
                WriteLiteral(@"icon layui-icon-refresh-3""></i>
                        </a>
                    </li>
                </ul>
                <ul class=""layui-nav layui-layout-right"" lay-filter=""layadmin-layout-right"">
                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""fullscreen"">
                            <i class=""layui-icon layui-icon-screen-full""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item"" lay-unselect>
                        <a href=""javascript:;"">
                            <cite>");
                EndContext();
                BeginContext(2257, 20, false);
#line 46 "D:\项目\OfficeAutomation\OfficeAutomation\Views\Home\Index.cshtml"
                             Write(ViewData["username"]);

#line default
#line hidden
                EndContext();
                BeginContext(2277, 9244, true);
                WriteLiteral(@"</cite>
                        </a>
                        <dl class=""layui-nav-child"">
                            <dd>
                                <a lay-href=""../Login/Logout"">退出登录</a>
                            </dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""theme"">
                            <i class=""layui-icon layui-icon-theme""></i>
                        </a>
                    </li>

                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""about""><i class=""layui-icon layui-icon-more-vertical""></i></a>
                    </li>

                    <li class=""layui-nav-item layui-show-xs-inline-block layui-hide-sm"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""more""><i class=""layui-icon layui-icon-more-vertical""><");
                WriteLiteral(@"/i></a>
                    </li>
                </ul>
            </div>
            <!-- 侧边菜单 -->
            <div class=""layui-side layui-side-menu"">
                <div class=""layui-side-scroll"">
                    <div class=""layui-logo"" lay-href=""home/console.html"">
                        <span>自动化办公系统</span>
                    </div>
                    <ul class=""layui-nav layui-nav-tree"" lay-shrink=""all"" id=""LAY-system-side-menu"" lay-filter=""layadmin-system-side-menu"">
                        <li data-name=""home"" class=""layui-nav-item layui-nav-itemed"">
                            <a href=""javascript:;"" lay-tips=""主页"" lay-direction=""1"">
                                <i class=""layui-icon layui-icon-home""></i>
                                <cite>&nbsp;主&nbsp;页&nbsp;</cite>
                            </a>
                            <dl class=""layui-nav-child"">
                                <dd data-name=""console"" class=""layui-this"">
                                    <i cl");
                WriteLiteral(@"ass=""layui-icon layui-icon-console""></i>
                                    <a lay-href=""../Home/Console"">控制台</a>
                                </dd>
                            </dl>
                        </li>
                        <li data-name=""category"" class=""layui-nav-item"">
                            <a href=""javascript:;"" lay-tips=""类目"" lay-direction=""2"">
                                <i class=""layui-icon layui-icon-rmb""></i>
                                <cite>&nbsp;类&nbsp;&nbsp;&nbsp;目&nbsp;</cite>
                            </a>
                            <dl class=""layui-nav-child"">

                                <dd>
                                    <a lay-href=""../Category/One"">一级类目</a>
                                </dd>
                                <dd>
                                    <a lay-href=""../Category/Two"">二级类目</a>
                                </dd>
                                <dd>
                                    <a lay-href=""..");
                WriteLiteral(@"/Category/Three"">三级类目</a>
                                </dd>
                                <dd>
                                    <a lay-href=""../Category/Level"">级联</a>
                                </dd>
                            </dl>
                        </li>
                        <li data-name=""auditing"" class=""layui-nav-item"">
                            <a href=""javascript:;"" lay-tips=""审核"" lay-direction=""2"">
                                <i class=""layui-icon layui-icon-auz""></i>
                                <cite>&nbsp;审&nbsp;&nbsp;&nbsp;核&nbsp;</cite>
                            </a>
                            <dl class=""layui-nav-child"">

                                <dd>
                                    <a lay-href=""../Auditing/ItemAuditing"">运营项目审核</a>
                                </dd>

                            </dl>
                        </li>
                        <li data-name=""get"" class=""layui-nav-item"">
                            <a ");
                WriteLiteral(@"href=""javascript:;"" lay-href=""../Operational/"" lay-tips=""运营项目登记"" lay-direction=""2"">
                                <i class=""layui-icon layui-icon-set""></i>
                                <cite>运营项目登记</cite>
                            </a>
                        </li>

                        <li data-name=""classtime"" class=""layui-nav-item"">
                            <a href=""javascript:;"" lay-href=""../Classtime/"" lay-tips=""课表"" lay-direction=""2"">
                                <i class=""layui-icon layui-icon-date""></i>
                                <cite>&nbsp;课&nbsp;&nbsp;&nbsp;表&nbsp;</cite>
                            </a>
                        </li>

                        <li data-name=""database"" class=""layui-nav-item"">
                            <a href=""javascript:;"" lay-tips=""基础数据"" lay-direction=""2"">
                                <i class=""layui-icon layui-icon-read""></i>
                                <cite>&nbsp;基&nbsp;础&nbsp;数&nbsp;据&nbsp;</cite>
                   ");
                WriteLiteral(@"         </a>
                            <dl class=""layui-nav-child"">

                                <dd>
                                    <a lay-href=""../Basedata/Teachers"">教师管理</a>
                                </dd>
                                <dd>
                                    <a lay-href=""../Basedata/Courses"">课程管理</a>
                                </dd>
                                <dd>
                                    <a lay-href=""../Basedata/Classes"">专业管理</a>
                                </dd>
                                <dd>
                                    <a lay-href=""../Basedata/ClassTime"">课表管理</a>
                                </dd>
                            </dl>
                        </li>

                        <li data-name=""user"" class=""layui-nav-item"">
                            <a href=""javascript:;"" lay-tips=""用户管理"" lay-direction=""2"">
                                <i class=""layui-icon layui-icon-user""></i>
                 ");
                WriteLiteral(@"               <cite>&nbsp;后&nbsp;台&nbsp;管&nbsp;理&nbsp;</cite>
                            </a>
                            <dl class=""layui-nav-child"">
                                <dd>
                                    <a lay-href=""../Users/"">用户管理</a>
                                </dd>
                                <dd>
                                    <a lay-href=""../Users/Role"">角色管理</a>
                                </dd>
                                <dd>
                                    <a lay-href=""../Users/Effect"">功能设置</a>
                                </dd>
                                <dd>
                                    <a lay-href=""../Users/College"">学院管理</a>
                                </dd>
                            </dl>
                        </li>
                    </ul>
                </div>
            </div>
            <!-- 页面标签 -->
            <div class=""layadmin-pagetabs"" id=""LAY_app_tabs"">
                <div class=""layui-ic");
                WriteLiteral(@"on layadmin-tabs-control layui-icon-prev"" layadmin-event=""leftPage""></div>
                <div class=""layui-icon layadmin-tabs-control layui-icon-next"" layadmin-event=""rightPage""></div>
                <div class=""layui-icon layadmin-tabs-control layui-icon-down"">
                    <ul class=""layui-nav layadmin-tabs-select"" lay-filter=""layadmin-pagetabs-nav"">
                        <li class=""layui-nav-item"" lay-unselect>
                            <a href=""javascript:;""></a>
                            <dl class=""layui-nav-child layui-anim-fadein"">
                                <dd layadmin-event=""closeThisTabs"">
                                    <a href=""javascript:;"">关闭当前标签页</a>
                                </dd>
                                <dd layadmin-event=""closeOtherTabs"">
                                    <a href=""javascript:;"">关闭其它标签页</a>
                                </dd>
                                <dd layadmin-event=""closeAllTabs"">
                           ");
                WriteLiteral(@"         <a href=""javascript:;"">关闭全部标签页</a>
                                </dd>
                            </dl>
                        </li>
                    </ul>
                </div>
                <div class=""layui-tab"" lay-unauto lay-allowClose=""true"" lay-filter=""layadmin-layout-tabs"">
                    <ul class=""layui-tab-title"" id=""LAY_app_tabsheader"">
                        <li lay-id=""home/console.cshtml"" lay-attr=""home/console.cshtml"" class=""layui-this""><i class=""layui-icon layui-icon-home""></i></li>
                    </ul>
                </div>
            </div>
            <!-- 主体内容 -->
            <div class=""layui-body"" id=""LAY_app_body"">
                <div class=""layadmin-tabsbody-item layui-show"">
                    <iframe src=""../Home/Console"" frameborder=""0"" class=""layadmin-iframe""></iframe>
                </div>
            </div>
            <!-- 辅助元素，一般用于移动设备下遮罩 -->
            <div class=""layadmin-body-shade"" layadmin-event=""shade""></div>
      ");
                WriteLiteral("  </div>\r\n    </div>\r\n\r\n    ");
                EndContext();
                BeginContext(11521, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a47f0072e0f942aab9aca68f5f953e5e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11566, 196, true);
                WriteLiteral("\r\n    <script>\r\n        var layui = layui.config({\r\n            base: \'plus/\' //静态资源所在路径\r\n        }).extend({\r\n            index: \'lib/index\' //主入口模块\r\n            }).use(\'index\');\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11769, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
