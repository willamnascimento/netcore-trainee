#pragma checksum "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee0345868041665da72bd0e4d066748e8ff12a85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Create), @"mvc.1.0.view", @"/Views/Cliente/Create.cshtml")]
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
#line 1 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\_ViewImports.cshtml"
using Trainee.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\_ViewImports.cshtml"
using Trainee.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee0345868041665da72bd0e4d066748e8ff12a85", @"/Views/Cliente/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aa29b998e73b8d5d36b0251e963da35d96ebc30", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Trainee.Application.ViewModels.ClienteViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml"
  
    ViewData["Title"] = "Novo Cliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Novo Cliente</h2>\r\n\r\n<hr />\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml"
 using (Html.BeginForm("adicionar", "cliente", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml"
                            ;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 15 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml"
   Write(Html.LabelFor(m => m.Nome, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Nome, new { @class = "form-control", @placeholder = "Nome" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 22 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml"
   Write(Html.LabelFor(m => m.Ativo, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml"
       Write(Html.CheckBoxFor(m => m.Ativo, new { @class = "form-control", @placeholder = "Ativo" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Ativo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Salvar\" class=\"btn btn-success\" />\r\n            ");
#nullable restore
#line 31 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml"
       Write(Html.ActionLink("Cancel", "Index", null, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\Willism\source\repos\netcore-trainee\Trainee.Web\Views\Cliente\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Trainee.Application.ViewModels.ClienteViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591