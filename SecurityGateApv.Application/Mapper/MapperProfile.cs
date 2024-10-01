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
            CreateMap<VisitDetail, GetVisitDetailRes>().ReverseMap();
            CreateMap<VisitDetail, GetVisitDetailRes>().ReverseMap();
            CreateMap<Gate, GetGateRes>().ReverseMap();
            CreateMap<VisitorSession, VisitorSessionCheckOutCommand>().ReverseMap();
            CreateMap<ProcessByDepartmentManagerIdRes, Schedule>().ReverseMap();
            CreateMap<ProcessDetailByDepartmentManagerIdRes, Schedule>().ReverseMap();
            CreateMap<GetDepartmentRes, Department>().ReverseMap();
            CreateMap<GetScheduleRes, Schedule>().ReverseMap();
            CreateMap<CreateUserComman, User>().ReverseMap();
            CreateMap<DepartmentCreateCommand, Department>().ReverseMap();
            CreateMap<GetCardRes, QRCard>().ReverseMap()
                .ForMember(dest => dest.QrCardTypename, opt => opt.MapFrom(src => src.QRCardType.CardTypeName))
                .ForMember(dest => dest.QrCardStatusName, opt => opt.MapFrom(src => src.QRCardStatus.StatusName));


            #region Visit map
            CreateMap<GetVisitByDateRes, Visit>().ReverseMap()
                .ForMember(dest => dest.ScheduleTypeName, opt => opt.MapFrom(src => src.Schedule.ScheduleName))
                .ForMember(dest => dest.CreateByname, opt => opt.MapFrom(src => src.CreateBy.FullName));
            CreateMap<VisitRes, Visit>().ReverseMap()
                .ForMember(dest => dest.ScheduleTypeName, opt => opt.MapFrom(src => src.Schedule.ScheduleName))
                .ForMember(dest => dest.CreateByname, opt => opt.MapFrom(src => src.CreateBy.FullName));
            #endregion

            #region VisitDetail map
            CreateMap<GetVisitDetailRes, VisitDetail>().ReverseMap();
            CreateMap<GetVisitByCredentialCardRes, VisitDetail>().ReverseMap();
            #endregion

            #region Visitor map
            CreateMap<Visitor, VisitorRes>().ReverseMap();
            #endregion
            
        }
    }
}
