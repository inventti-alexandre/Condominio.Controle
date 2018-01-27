using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Condominio.Controle.Domain.Entities;
using Condominio.Controle.MVC.ViewModels;

namespace Condominio.Controle.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
                cfg.CreateMap<Apartamento, ApartamentoViewModel>().ReverseMap();
                cfg.CreateMap<Bloco, BlocoViewModel>().ReverseMap();
                cfg.CreateMap<Marca, MarcaViewModel>().ReverseMap();
                cfg.CreateMap<Modelo, ModeloViewModel>().ReverseMap();
                cfg.CreateMap<Proprietario, ProprietarioViewModel>().ReverseMap();
                cfg.CreateMap<Veiculo, VeiculoViewModel>().ReverseMap();
            });
        }
    }
}