#pragma checksum "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\Pages\TodoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f937cfce2d5cde476f0c870a815d80accb1ae139"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazorTeste1.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\_Imports.razor"
using blazorTeste1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\_Imports.razor"
using blazorTeste1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\_Imports.razor"
using blazorTeste1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todolist")]
    public partial class TodoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\Pages\TodoList.razor"
      

    
    List<Todo> listaTodo;
    protected override void OnInitialized()
    {

        listaTodo = new List<Todo>(){

        new Todo(){Title = "Passer com o cachorro", Done = false },
        new Todo(){Title = "Estudar programação", Done = true}
    };
    

    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
