#pragma checksum "C:\Users\VKumar\source\repos\vkicore\vkicore\Views\Shared\AdminLTE\_TopNavigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d75a8d76ad965b61f2b3bdc07578eb9c079cc98c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AdminLTE__TopNavigation), @"mvc.1.0.view", @"/Views/Shared/AdminLTE/_TopNavigation.cshtml")]
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
#nullable restore
#line 1 "C:\Users\VKumar\source\repos\vkicore\vkicore\Views\_ViewImports.cshtml"
using vkicore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VKumar\source\repos\vkicore\vkicore\Views\_ViewImports.cshtml"
using vkicore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d75a8d76ad965b61f2b3bdc07578eb9c079cc98c", @"/Views/Shared/AdminLTE/_TopNavigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e7adf356328b6760452d81e61447f66d7e366d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AdminLTE__TopNavigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- Navbar -->
<nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
    <!-- Left navbar links -->
    <ul class=""navbar-nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
        </li>
");
            WriteLiteral("        <li class=\"nav-item d-none d-sm-inline-block\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 655, "\"", 694, 1);
#nullable restore
#line 16 "C:\Users\VKumar\source\repos\vkicore\vkicore\Views\Shared\AdminLTE\_TopNavigation.cshtml"
WriteAttributeValue("", 662, Url.Action("index","Dashboard"), 662, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""nav-link"">Dashboard</a>
        </li>
    </ul>

    <!-- Right navbar links -->
    <ul class=""navbar-nav ml-auto"">
       
        <li class=""nav-item"">
            <a class=""nav-link"" data-widget=""fullscreen"" href=""#"" role=""button"">
                <i class=""fas fa-expand-arrows-alt""></i>
            </a>
        </li>
");
            WriteLiteral("    </ul>\r\n</nav>\r\n<!-- /.navbar -->\r\n");
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
