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
            CreateMap<Role, RoleRes>().ReverseMap();
            //CreateMap<Role, RoleRes>().ReverseMap();
            CreateMap<VisitDetail, VisitDetailRes>().ReverseMap();
            CreateMap<Visitor, VisitorRes>().ReverseMap();
            CreateMap<VisitDetail, VisitDetailRes>().ReverseMap();
            CreateMap<Gate, GetGateRes>().ReverseMap();
            CreateMap<VisitorSession, VisitorSessionCheckOutCommand>().ReverseMap();
            CreateMap<ProcessByDepartmentManagerIdRes, Schedule>().ReverseMap();
            CreateMap<ProcessDetailByDepartmentManagerIdRes, Schedule>().ReverseMap();
            CreateMap<GetDepartmentRes, Department>().ReverseMap();
            CreateMap<GetScheduleRes, Schedule>().ReverseMap();
            CreateMap<ScheduleResForVisit, Schedule>().ReverseMap();
            CreateMap<CreateUserComman, User>().ReverseMap();
            CreateMap<DepartmentCreateCommand, Department>().ReverseMap();
            CreateMap<VisitCreateCommand, Visit>().ReverseMap();
            CreateMap<GetVisitorRes, Visitor>().ReverseMap();
            CreateMap<VisitDetailOldCommand, VisitDetail>().ReverseMap();
            CreateMap<GetCardRes, QRCard>().ReverseMap()
                .ForMember(dest => dest.QrCardTypename, opt => opt.MapFrom(src => src.QRCardType.CardTypeName))
                .ForMember(dest => dest.QrCardStatusName, opt => opt.MapFrom(src => src.QRCardStatus.StatusName));

        }
    }
}
