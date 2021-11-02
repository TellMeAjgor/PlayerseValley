using AutoMapper;
using PlayerseValleyDomain.Entities;
using PlayerseValleyDomain.Informations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerseValleyDomain.MappingProfile
{
    public class AutoMapperProfile: Profile 
    {
        public AutoMapperProfile()
        {
            CreateMap<Account, AccountInformation>().ReverseMap();
            CreateMap<Map, MapInformation>().ReverseMap();
            CreateMap<Player, PlayerInformation>().ReverseMap();
        }
    }
}
