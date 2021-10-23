using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppEventos.Shared.DTOs;
using AppEventos.Shared.Entidades;
using AppEventos.Web.DTOs;
using AutoMapper;

namespace Eventos.Web.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Evento, EventoCreacionDTO>().ReverseMap();
            CreateMap<Evento, EventoVisualizarDTO>();
            CreateMap<Evento, EventoDTO>()
                .ForMember(x => x.Municipio, options => options.MapFrom(MapEventosMunicipio))
                .ForMember(x => x.Departamento, options => options.MapFrom(MapEventosDepartamento))
                .ForMember(x => x.Categoria, options => options.MapFrom(MapEventosCategoría));

            CreateMap<Departamento, DepartamentoDetalleDTO>();
            CreateMap <Municipio, MunicipioDetalleDTO>();
        }

        private Municipio MapEventosMunicipio(Evento evento, EventoDTO peliculaDetallesDTO)
        {
            var resultado = new Municipio();
            resultado.Id = evento.MunicipioId;
            resultado.Nombre = evento.Municipio.Nombre;

            return resultado;
        }

        private Departamento MapEventosDepartamento(Evento evento, EventoDTO peliculaDetallesDTO)
        {
            var resultado = new Departamento();
            resultado.Id = evento.Departamento.Id;
            resultado.Nombre = evento.Departamento.Nombre;

            return resultado;
        }

        private Categoria MapEventosCategoría(Evento evento, EventoDTO peliculaDetallesDTO)
        {
            var resultado = new Categoria();
            resultado.Id = evento.Categoria.Id;
            resultado.Descripcion = evento.Categoria.Descripcion;

            return resultado;
        }
    }
}
