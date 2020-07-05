using AutoMapper;
using Codenation.Challenge.Models;


namespace Source
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Quote, QuoteView>().ReverseMap();

        }

    }
}
