#pragma checksum "C:\Users\josei\Desktop\NetCoreComponent\Views\Shared\Components\TodoDB\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "109ea7eaf0d629bc0e0a8ae23e0cd881d0114c3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TodoDB_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TodoDB/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TodoDB/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TodoDB_Default))]
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
#line 1 "C:\Users\josei\Desktop\NetCoreComponent\Views\_ViewImports.cshtml"
using NetCoreComponent;

#line default
#line hidden
#line 2 "C:\Users\josei\Desktop\NetCoreComponent\Views\_ViewImports.cshtml"
using NetCoreComponent.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"109ea7eaf0d629bc0e0a8ae23e0cd881d0114c3a", @"/Views/Shared/Components/TodoDB/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11cf50d1a7db1f8340c2c5eb58fae60cdc8c68cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TodoDB_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TodoList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 32, true);
            WriteLiteral("<h1>My Todo List DB</h1>\r\n<ul>\r\n");
            EndContext();
#line 4 "C:\Users\josei\Desktop\NetCoreComponent\Views\Shared\Components\TodoDB\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(103, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(116, 9, false);
#line 6 "C:\Users\josei\Desktop\NetCoreComponent\Views\Shared\Components\TodoDB\Default.cshtml"
       Write(item.task);

#line default
#line hidden
            EndContext();
            BeginContext(125, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 7 "C:\Users\josei\Desktop\NetCoreComponent\Views\Shared\Components\TodoDB\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(139, 7, true);
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TodoList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
