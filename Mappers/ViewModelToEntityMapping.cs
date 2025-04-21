using aspnetapp5.Entities;
using aspnetapp5.Entities.ViewModels;
using AutoMapper;

namespace aspnetapp5.Mappers
{
    public class ViewModelToEntityMapping: Profile
    {
        //Shortcut: ctor
        public ViewModelToEntityMapping()
        {
            CreateMap<NewsViewModel, News>();
        }
    }
}