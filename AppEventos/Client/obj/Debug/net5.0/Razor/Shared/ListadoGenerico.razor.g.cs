#pragma checksum "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b18d233ffd70ce27aa1586a39b9ed3dd4901fb50"
// <auto-generated/>
#pragma warning disable 1591
namespace AppEventos.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using AppEventos.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using AppEventos.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using AppEventos.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using AppEventos.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using AppEventos.Shared.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using AppEventos.Client.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class ListadoGenerico<Titem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
 if (Listado == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
     if (Cargando == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Cargando...");
#nullable restore
#line 7 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
                                
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 11 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
         Cargando

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 11 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
     
}
else if (Listado.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
     if (NoHayRegistros == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "No hay registros para mostrar");
#nullable restore
#line 18 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
                                                  
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, 
#nullable restore
#line 22 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
         NoHayRegistros

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 22 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
                       
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
     
}
else
{
    if (HayRegistros != null)
    {
        foreach (var elemento in Listado)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 31 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
             HayRegistros(elemento)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 31 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
                                   
        }
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 36 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
         HayRegistrosCompleto

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 36 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
                             
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/ListadoGenerico.razor"
       
    [Parameter] public RenderFragment Cargando { get; set; }
    [Parameter] public RenderFragment NoHayRegistros { get; set; }
    [Parameter] public RenderFragment<Titem> HayRegistros { get; set; }
    [Parameter] public RenderFragment HayRegistrosCompleto { get; set; }
    [Parameter] public List<Titem> Listado { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591