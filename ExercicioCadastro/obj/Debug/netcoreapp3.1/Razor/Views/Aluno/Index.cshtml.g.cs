#pragma checksum "C:\Users\ACPA\Desktop\Códigos.NETCore\ExercicioCadastro\Views\Aluno\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "703256a2bfaa3ab14e1ecee41a908b85a1e55fbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_Index), @"mvc.1.0.view", @"/Views/Aluno/Index.cshtml")]
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
#line 1 "C:\Users\ACPA\Desktop\Códigos.NETCore\ExercicioCadastro\Views\_ViewImports.cshtml"
using ExercicioCadastro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACPA\Desktop\Códigos.NETCore\ExercicioCadastro\Views\_ViewImports.cshtml"
using ExercicioCadastro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"703256a2bfaa3ab14e1ecee41a908b85a1e55fbd", @"/Views/Aluno/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e97b733fbfa700a2bcfe6c94fc0d8d2cd8e1f8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExercicioCadastro.Models.Aluno>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Todos os Alunos</h2>\r\n\r\n<a href=\"/Aluno/Cadastrar\" class=\"btn btn-success\">Novo aluno</a>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\ACPA\Desktop\Códigos.NETCore\ExercicioCadastro\Views\Aluno\Index.cshtml"
 foreach(var aluno in Model) 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Nome: ");
#nullable restore
#line 9 "C:\Users\ACPA\Desktop\Códigos.NETCore\ExercicioCadastro\Views\Aluno\Index.cshtml"
        Write(aluno.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Sobrenome: ");
#nullable restore
#line 10 "C:\Users\ACPA\Desktop\Códigos.NETCore\ExercicioCadastro\Views\Aluno\Index.cshtml"
             Write(aluno.Sobrenome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>CPF: ");
#nullable restore
#line 11 "C:\Users\ACPA\Desktop\Códigos.NETCore\ExercicioCadastro\Views\Aluno\Index.cshtml"
       Write(aluno.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Curso: ");
#nullable restore
#line 12 "C:\Users\ACPA\Desktop\Códigos.NETCore\ExercicioCadastro\Views\Aluno\Index.cshtml"
         Write(aluno.Curso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 321, "\"", 360, 2);
            WriteAttributeValue("", 328, "/Aluno/Editar/", 328, 14, true);
#nullable restore
#line 13 "C:\Users\ACPA\Desktop\Códigos.NETCore\ExercicioCadastro\Views\Aluno\Index.cshtml"
WriteAttributeValue("", 342, aluno.MatriculaId, 342, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Editar</a>\r\n    <hr>\r\n");
#nullable restore
#line 15 "C:\Users\ACPA\Desktop\Códigos.NETCore\ExercicioCadastro\Views\Aluno\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExercicioCadastro.Models.Aluno>> Html { get; private set; }
    }
}
#pragma warning restore 1591