using AutoMapper;
using CursoWebAPI.Models;
using CursoWebAPI.ViewModels;

namespace CursoWebAPI.Configurations
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
        }
    }
}