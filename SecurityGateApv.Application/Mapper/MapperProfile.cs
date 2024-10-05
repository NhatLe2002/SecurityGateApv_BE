using AutoMapper;
using SecurityGateApv.Application.DTOs.Req;
using SecurityGateApv.Application.DTOs.Req.CreateReq;
using SecurityGateApv.Application.DTOs.Req.UpdateReq;
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
            #region
            CreateMap<User, CreateByRes>().ReverseMap();
            CreateMap<User, GetUserRes>().ReverseMap();
            #endregion

            #region Role
            CreateMap<Role, RoleRes>().ReverseMap();
            #endregion
            CreateMap<Gate, GetGateRes>().ReverseMap();
            CreateMap<VisitorSession, VisitorSessionCheckOutCommand>().ReverseMap();
            CreateMap<GetDepartmentRes, Department>().ReverseMap();
            CreateMap<GetScheduleRes, Schedule>().ReverseMap();
            CreateMap<ScheduleResForVisit, Schedule>().ReverseMap();
            CreateMap<CreateUserComman, User>().ReverseMap();
            CreateMap<DepartmentCreateCommand, Department>().ReverseMap();
            CreateMap<VisitCreateCommand, Visit>().ReverseMap();
            CreateMap<GetVisitorRes, Visitor>().ReverseMap();
            CreateMap<User, UpdateUserCommand>().ReverseMap();
            CreateMap<User, UpdateUserNoDepartmentIdCommand>().ReverseMap();
            CreateMap<VisitDetailOldCommand, VisitDetail>().ReverseMap();
            CreateMap<Department, DeparmentRes>().ReverseMap();
            CreateMap<CredentialCardTypeRes, CredentialCardType>().ReverseMap();
            CreateMap<GetCardRes, QRCard>().ReverseMap()
                .ForMember(dest => dest.QrCardTypename, opt => opt.MapFrom(src => src.QRCardType.CardTypeName))
                .ForMember(dest => dest.QrCardStatusName, opt => opt.MapFrom(src => src.QRCardStatus.StatusName));

            #region Visitor map
            CreateMap<CreateVisitorRes, Visitor>().ReverseMap();
            #endregion


            #region Visit map
            CreateMap<Visit, GetVisitRes>().ReverseMap();
            CreateMap<Visit, GetVisitNoDetailRes>().ReverseMap();
            CreateMap<VisitDetail, VisitDetailRes>().ReverseMap();
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
            CreateMap<Visitor, CreateVisitorCommand>().ReverseMap();
            CreateMap<VisitorDetailRes, Visitor>().ReverseMap();
            #endregion
            #region
            CreateMap<GetScheduleTypeRes, ScheduleType>().ReverseMap();
            #endregion
        }
    }
}
