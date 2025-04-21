using aspnetapp5.Entities;
using aspnetapp5.Entities.ViewModels;
using AutoMapper;

namespace aspnetapp5.Mappers
{
    public class EntityToViewModelMapping : Profile
    {
        //Shortcut: ctor
        public EntityToViewModelMapping()
        {
            CreateMap<News, NewsViewModel>();
        }
    }
}