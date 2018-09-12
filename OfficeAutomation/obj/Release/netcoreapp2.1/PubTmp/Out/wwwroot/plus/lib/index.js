;
layui.extend({
    setter: "config",
    admin: "lib/admin",
    view: "lib/view"
}).define(["setter", "admin"],
function(exports) {
    var setter = layui.setter,
    i = layui.element,
    admin = layui.admin,
    t = admin.tabsPage,
    view = layui.view,
    l = function(a, d) {
        var l, b = r("#LAY_app_tabsheader>li"),
        y = a.replace(/(^http(s*):)|(\?[\s\S]*$)/g, "");
        if (b.each(function(e) {
            var i = r(this),
            n = i.attr("lay-id");
            n === a && (l = !0, t.index = e)
        }), d = d || "新标签页", setter.pageTabs) l || (r(s).append(['<div class="layadmin-tabsbody-item layui-show">', '<iframe src="' + a + '" frameborder="0" class="layadmin-iframe"></iframe>', "</div>"].join("")), t.index = b.length, i.tabAdd(o, {
            title: "<span>" + d + "</span>",
            id: a,
            attr: y
        }));
        else {
            var u = admin.tabsBody(admin.tabsPage.index).find(".layadmin-iframe");
            u[0].contentWindow.location.href = a
        }
        i.tabChange(o, a),
        admin.tabsBodyChange(t.index, {
            url: a,
            text: d
        })
    },
    s = "#LAY_app_body",
    o = "layadmin-layout-tabs",
    r = layui.$;
    r(window);
    admin.screen() < 2 && admin.sideFlexible(),
    layui.config({
        base: setter.base + "modules/"
    }),
    layui.each(setter.extend, function(a, i) {
        var n = {};
        n[i] = "{/}" + setter.base + "lib/extend/" + i,
        layui.extend(n)
    }),
    view().autoRender(),
    layui.use("common"),
    exports("index", {
        openTabsPage: l
    })
});