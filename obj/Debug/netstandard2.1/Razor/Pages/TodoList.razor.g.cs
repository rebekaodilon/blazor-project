#pragma checksum "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\Pages\TodoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f937cfce2d5cde476f0c870a815d80accb1ae139"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>To do\'s</h1>\r\n\r\n");
            __builder.OpenComponent<Blazorise.Table>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Blazorise.TableHeader>(4);
                __builder2.AddAttribute(5, "ThemeContrast", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.ThemeContrast>(
#nullable restore
#line 6 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\Pages\TodoList.razor"
                                ThemeContrast.Light

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(7, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.TableRow>(8);
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(10, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(11);
                        __builder4.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(13, "TODO");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(14, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(15);
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(17, "DONE");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(18, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenComponent<Blazorise.TableBody>(21);
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(23, "\r\n");
#nullable restore
#line 13 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\Pages\TodoList.razor"
         foreach (var item in listaTodo)
        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(24, "            ");
                    __builder3.OpenComponent<Blazorise.TableRow>(25);
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(27, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(28);
                        __builder4.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(30, 
#nullable restore
#line 16 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\Pages\TodoList.razor"
                               item.Title

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddContent(31, " ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(32, "\r\n");
#nullable restore
#line 17 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\Pages\TodoList.razor"
                 if (@item.Done != false)
                {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(33, "                    ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(34);
                        __builder4.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(36, "YES");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n");
#nullable restore
#line 20 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\Pages\TodoList.razor"
                }else{

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(38, "                    ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(39);
                        __builder4.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(41, "NO");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(42, "\r\n");
#nullable restore
#line 22 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\Pages\TodoList.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(43, "            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n");
#nullable restore
#line 24 "C:\Users\rebek\OneDrive\Documentos\Faculdade\Dev s.i\blazorTeste1\Client\Pages\TodoList.razor"
        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(45, "    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n");
            }
            ));
            __builder.CloseComponent();
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
