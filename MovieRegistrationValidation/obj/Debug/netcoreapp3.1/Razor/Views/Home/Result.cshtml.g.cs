#pragma checksum "D:\Grand Circus\Grand Circus Docs\NET Core\MovieRegistrationValidation\MovieRegistrationValidation\MovieRegistrationValidation\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "386a35222e3c4ec7d34357cb09f6a3ba9c7c232f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "D:\Grand Circus\Grand Circus Docs\NET Core\MovieRegistrationValidation\MovieRegistrationValidation\MovieRegistrationValidation\Views\_ViewImports.cshtml"
using MovieRegistrationValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Grand Circus\Grand Circus Docs\NET Core\MovieRegistrationValidation\MovieRegistrationValidation\MovieRegistrationValidation\Views\_ViewImports.cshtml"
using MovieRegistrationValidation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"386a35222e3c4ec7d34357cb09f6a3ba9c7c232f", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a482235e16d0c5cc80e844e35e9737e7025f6ece", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Thank You For Registering!</h2>\r\n\r\n<h4>");
#nullable restore
#line 4 "D:\Grand Circus\Grand Circus Docs\NET Core\MovieRegistrationValidation\MovieRegistrationValidation\MovieRegistrationValidation\Views\Home\Result.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been registerd!</h4>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591