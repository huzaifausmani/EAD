using webapp2.Models.ViewModels;
using webapp2.Models;
using AutoMapper;                        //must have to add this line

namespace webapp2.MappingConfiguration
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // CreateMap<User, UserViewModel>();

            //For different properties in User.cs and UserViewModel.cs
            CreateMap<User, UserViewModel>()
                .ForMember(dest =>
                dest.FName,
                opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest =>
                dest.LName,
                opt => opt.MapFrom(src => src.LastName));
        }
    }
}