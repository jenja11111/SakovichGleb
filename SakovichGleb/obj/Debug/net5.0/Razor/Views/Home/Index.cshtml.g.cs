#pragma checksum "D:\Projects\SakovichGleb\SakovichGleb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "595eda44ded1a065d5b0f598bc368bbce568e3c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "D:\Projects\SakovichGleb\SakovichGleb\Views\_ViewImports.cshtml"
using SakovichGleb.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595eda44ded1a065d5b0f598bc368bbce568e3c9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8963cc55210dc03b398468516ac6bbe72d1aced", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SakovichGleb.ViewModels.HomeViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\SakovichGleb\SakovichGleb\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Главная";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\SakovichGleb\SakovichGleb\Views\Home\Index.cshtml"
 if(Model.User.Login == "Admin"){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3> Админская панель </h3>\r\n    <p></p><p></p>\r\n    <ol>       \r\n");
#nullable restore
#line 9 "D:\Projects\SakovichGleb\SakovichGleb\Views\Home\Index.cshtml"
         foreach(var user in Model.UserRepository.GetUsers())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 11 "D:\Projects\SakovichGleb\SakovichGleb\Views\Home\Index.cshtml"
           Write(user.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 11 "D:\Projects\SakovichGleb\SakovichGleb\Views\Home\Index.cshtml"
                           Write(user.FName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 11 "D:\Projects\SakovichGleb\SakovichGleb\Views\Home\Index.cshtml"
                                         Write(user.LName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 12 "D:\Projects\SakovichGleb\SakovichGleb\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\r\n");
#nullable restore
#line 14 "D:\Projects\SakovichGleb\SakovichGleb\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1> Домашняя страница </h1>\r\n");
#nullable restore
#line 18 "D:\Projects\SakovichGleb\SakovichGleb\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SakovichGleb.ViewModels.HomeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
