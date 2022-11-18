using AutoMapper;
using ViewModels;
using TP4.Models;

public class PerfilDeMapeo : Profile
{
    public PerfilDeMapeo()
    {
        CreateMap<Cadete, CadeteViewModel>().ReverseMap();
    }   
}