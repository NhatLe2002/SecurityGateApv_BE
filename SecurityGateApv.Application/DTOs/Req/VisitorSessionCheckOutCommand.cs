﻿using SecurityGateApv.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SecurityGateApv.Application.DTOs.Req
{
    public  class VisitorSessionCheckOutCommand
    {
        public DateTime CheckoutTime { get; set; }
        public int SecurityOutId { get; set; }
        public int GateOutId { get; set; }
        [JsonIgnore]
        public string Status { get; set; } = string.Empty;

        //public ICollection<VehicleSessionImage> Images { get; set; }
    }
}
