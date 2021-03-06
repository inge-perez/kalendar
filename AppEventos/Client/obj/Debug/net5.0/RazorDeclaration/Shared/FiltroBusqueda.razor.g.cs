// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class FiltroBusqueda : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/FiltroBusqueda.razor"
      
    private List<Departamento> Departamentos = new List<Departamento>();
    private List<Municipio> Municipios = new List<Municipio>();
    private List<Categoria> Categorias = new List<Categoria>();
    private int defaultValue = 0;

    DateTime? date = DateTime.Today;

    protected async override Task OnInitializedAsync()
    {
        var responseHttp = await repositorio.Get<List<Departamento>>("api/departamentos");
        Departamentos = responseHttp.Response;
        var responseHttpCategoria = await repositorio.Get<List<Categoria>>("api/eventos/obtenerCategoria");
        Categorias = responseHttpCategoria.Response;
    }

    private async Task CargarMunicipio(int i)
    {
        if (i != 0)
        {
            var responseHttp = await repositorio.Get<List<Municipio>>($"api/municipios/{i}");
            Municipios = responseHttp.Response;
        }
        else
            Municipios = new List<Municipio>();

    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
        if (firstRender)
        {
        }
    }
 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
