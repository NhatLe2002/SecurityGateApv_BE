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
            #region User
            CreateMap<User, CreateByRes>().ReverseMap();
            CreateMap<User, GetUserRes>().ReverseMap();
            CreateMap<SecurityRes, User>().ReverseMap();
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
            CreateMap<GetCardRes, Card>().ReverseMap()
                .ForMember(dest => dest.QrCardTypename, opt => opt.MapFrom(src => src.CardType.CardTypeName));

            #region Visitor map
            CreateMap<CreateVisitorRes, Visitor>().ReverseMap();
            #endregion


            #region Visit map
            CreateMap<Visit, GetVisitRes>().ReverseMap();
            CreateMap<Visit, GetVisitNoDetailRes>().ReverseMap();
            CreateMap<VisitDetail, VisitDetailRes>().ReverseMap();
            CreateMap<UpdateVisitBeforeStartDateCommand, Visit>().ReverseMap();
            CreateMap<UpdateVisitAfterStartDateCommand, Visit>().ReverseMap();
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
            CreateMap<VisitDetaiUpdateVisitAfterStartDateCommand, VisitDetail>().ReverseMap();
            CreateMap<UpdateAppendTimeForVisitCommand, Visit>().ReverseMap();
            #endregion

            #region Visitor map
            CreateMap<Visitor, VisitorRes>().ReverseMap();
            CreateMap<Visitor, CreateVisitorCommand>().ReverseMap();
            CreateMap<VisitorDetailRes, Visitor>().ReverseMap();
            CreateMap<GetVisitorCreateRes, Visitor>().ReverseMap();
            CreateMap<UpdateVisitorCommand, Visitor>().ReverseMap();
            #endregion

            #region ScheduleType
            CreateMap<GetScheduleTypeRes, ScheduleType>().ReverseMap();
            CreateMap<GetScheduleUserRes, ScheduleUser>().ReverseMap();
            CreateMap<ScheduleGetScheduleUserRes, Schedule>().ReverseMap();
            CreateMap<ScheduleTypeGetScheduleUserRes, ScheduleType>().ReverseMap();
            CreateMap<ScheduleTypeGetScheduleUserRes, ScheduleType>().ReverseMap();
            CreateMap<UserGetScheduleUserRes, User>().ReverseMap();
            #endregion

            #region SessionsImageRes
            CreateMap<SessionsImageRes, VisitorSessionsImage>().ReverseMap();
            CreateMap<VisitorSessionsImageCheckinCommand, VisitorSessionsImage>().ReverseMap();

            #endregion

            #region Gate
            CreateMap<GateRes, Gate>().ReverseMap();
            #endregion

            #region VisitSession
                CreateMap<GetVisitorSessionRes, VisitorSession>().ReverseMap();
                CreateMap<SessionsRes, VisitorSession>().ReverseMap();
            #endregion
            #region Card
            CreateMap<Card, GetCardRes>().ReverseMap();
            CreateMap<VisitCard, VisitCardRes>().ReverseMap();
            #endregion
        }
    }
}
