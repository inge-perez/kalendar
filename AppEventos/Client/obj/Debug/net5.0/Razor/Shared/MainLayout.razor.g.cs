#pragma checksum "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "785be24200bb448e6901400004bde97c9664633f"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "wrapper");
            __builder.AddAttribute(2, "class", "wrapper");
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<AppEventos.Client.Shared.NavMenu>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "section");
            __builder.AddAttribute(8, "class", "event-wrap-layout3 inner-page-top-margin bg--accent");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container");
            __builder.AddContent(11, 
#nullable restore
#line 8 "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Shared/MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenComponent<AppEventos.Client.Shared.Footer>(13);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591