#pragma checksum "C:\Users\10\source\repos\MvcMovie\MvcMovie\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f21d24106a2917c5c49fe19566e88880b5af91cc"
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
#line 1 "C:\Users\10\source\repos\MvcMovie\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#line 2 "C:\Users\10\source\repos\MvcMovie\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f21d24106a2917c5c49fe19566e88880b5af91cc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\10\source\repos\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Descriere pe scurt a aplicatiei";

#line default
#line hidden
            BeginContext(67, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(72, 17, false);
#line 4 "C:\Users\10\source\repos\MvcMovie\MvcMovie\Views\Home\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(89, 806, true);
            WriteLiteral(@"</h1>

<p>Aceasta aplicatie gestioneaza filme si intrarile unor masini intr-un service. Filmele pot fi cautate dupa doua criterii:</p>
    <p>-Titlul filmului (orice sir care contine subsirul cautat de catre noi va fi afisat)</p>
    <p>-Genul filmului (pentru cautarea dupa gen se selecteaza dintr-o lista cu toate genurile din baza de date genul pe care il dorim)</p>
<p> Intrarile in service pot fi cautate dupa patru criterii: </p>
   <p> -VIN-ul autovehicului (acesta este unic pentru fiecare masina) </p>
   <p>-Lucrarile efectuate (orice sir care contine subsirul cautat de catre noi va fi afisat)</p>
 <p>Am validat informatile care pot fi introduse de utilizator.</p>
<p> De exemplu,VIN-ul masinii trebuie sa aiba o lungime fixa de 17 caractere si contine doar litere mari si cifre.</p>
");
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
