﻿using AutoMapper;
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
            CreateMap<VisitDetail, VisitDetailRes>().ReverseMap();
            CreateMap<Visitor, VisitorRes>().ReverseMap();
            CreateMap<VisitDetail, VisitDetailRes>().ReverseMap();
            CreateMap<Gate, GetGateRes>().ReverseMap();
            CreateMap<VisitorSession, VisitorSessionCheckOutCommand>().ReverseMap();

        }
    }
}
