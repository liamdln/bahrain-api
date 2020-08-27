using AutoMapper;
using bahrain_api.Models;
using bahrain_api.DTOs;

namespace bahrain_api.Profiles
{

    public class ATControllersProfile : Profile
    {

        public ATControllersProfile()
        {
            
            // Source -> target

            //GETTING
            CreateMap<ATController, ATControllerReadDTO>();

            //POSTING
            CreateMap<ATControllerCreateDTO, ATController>();

            // PUTTING
            CreateMap<ATControllerUpdateDTO, ATController>();

            //PATCHING
            CreateMap<ATController, ATControllerUpdateDTO>();

        }

    }

}