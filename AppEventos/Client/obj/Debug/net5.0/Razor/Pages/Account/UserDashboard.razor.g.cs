#pragma checksum "/Users/juanseperez/Documents/Juanse/Proyectos/AppEventos/AppEventos/Client/Pages/Account/UserDashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03fae7daf05dd040e51b2e1594250ba5354b141b"
// <auto-generated/>
#pragma warning disable 1591
namespace AppEventos.Client.Pages.Account
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/userdashboard")]
    public partial class UserDashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "my-account-wrap padding-top-6 padding-bottom-6");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, @"<div class=""col-lg-4 col-12""><ul class=""nav nav-tabs my-account-nav""><li><a class=""active"" href=""#dashboard"" data-toggle=""tab"" aria-expanded=""false"">Crear Evento</a></li>
                <li><a href=""#listings"" data-toggle=""tab"" aria-expanded=""false"">Mis Eventos</a></li>
                <li><a href=""#account-details"" data-toggle=""tab"" aria-expanded=""false"">Perfil</a></li>
                <li><a href=""#logout"" data-toggle=""tab"" aria-expanded=""false"">Cerrar Sesión</a></li></ul></div>
        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-lg-8 col-12");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "my-account-content tab-content");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "tab-pane active show");
            __builder.AddAttribute(11, "id", "dashboard");
            __builder.OpenComponent<AppEventos.Client.Pages.Account.NewEvent>(12);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n\n                ");
            __builder.AddMarkupContent(14, @"<div class=""tab-pane fade"" id=""listings""><div class=""listing-box-list""><div class=""product-box""><div class=""item-img bg--gradient-50""><div class=""item-status status-open active"">Open</div>
                                <img src=""img/listing/listing-25.jpg"" alt=""Listing"" class=""img-fluid list-view-img"">
                                <ul class=""item-rating""><li><i class=""fas fa-star""></i></li>
                                    <li><i class=""fas fa-star""></i></li>
                                    <li><i class=""fas fa-star""></i></li>
                                    <li><i class=""fas fa-star""></i></li>
                                    <li><i class=""fas fa-star""></i></li>
                                    <li><span>8.4<span> / 10</span></span></li></ul></div>
                            <div class=""item-content""><h3 class=""item-title""><a href=""#"">Westfield Restaurant</a></h3>
                                <ul class=""contact-info""><li><i class=""fas fa-map-marker-alt""></i>59 Street, Mk tower,
                                        Brooklyn
                                    </li>
                                    <li><i class=""far fa-calendar-alt""></i>19th August, 2018</li></ul>
                                <ul class=""meta-item""><li class=""item-btn""><a href=""#"" class=""btn-fill"">Edit</a></li>
                                    <li class=""item-btn""><a href=""#"" class=""btn-fill"">Delete</a></li></ul></div></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
