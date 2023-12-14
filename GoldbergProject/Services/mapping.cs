using AutoMapper;
using DTOs;
using GoldbergProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<ImageDTO, Image>().ReverseMap();
            CreateMap<CommunitiesForOrganizationDTO, CommunitiesForOrganization>().ReverseMap();
            CreateMap<CommunityDTO, Community>().ReverseMap();
            CreateMap<OrganizationDTO, Organization>().ReverseMap();
        }
    }
}
