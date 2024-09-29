using AutoMapper;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Res;
using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Application.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Visit, GetVisitRes>().ReverseMap();
            CreateMap<Visit, GetVisitNoDetailRes>().ReverseMap();
            CreateMap<User, CreateByRes>().ReverseMap();
            CreateMap<User, GetUserRes>().ReverseMap();
            //CreateMap<Role, RoleRes>().ReverseMap();
            CreateMap<VisitProcess, VisitProcessRes>().ReverseMap();
            CreateMap<VisitDetail, VisitDetailRes>().ReverseMap();
            CreateMap<Visitor, VisitorRes>().ReverseMap();
            CreateMap<VisitDetail, VisitDetailRes>().ReverseMap();
            CreateMap<Gate, GetGateRes>().ReverseMap();
            CreateMap<VisitorSession, VisitorSessionCheckOutCommand>().ReverseMap();
            CreateMap<ProcessByDepartmentManagerIdRes, Process>().ReverseMap();
            CreateMap<ProcessDetailByDepartmentManagerIdRes, Process>().ReverseMap();
            CreateMap<ProcessDetailRes, VisitProcess>().ReverseMap();
            CreateMap<GetCardRes, QRCard>().ReverseMap()
                .ForMember(dest => dest.QrCardTypename, opt => opt.MapFrom(src => src.QRCardType.CardTypeName))
                .ForMember(dest => dest.QrCardStatusName, opt => opt.MapFrom(src => src.QRCardStatus.StatusName));

        }
    }
}
