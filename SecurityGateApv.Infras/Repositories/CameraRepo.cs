﻿using Microsoft.EntityFrameworkCore;
using SecurityGateApv.Domain.Interfaces.Repositories;
using SecurityGateApv.Domain.Models;
using SecurityGateApv.Infras.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Infras.Repositories
{
    public class CameraRepo : RepoBase<Camera>, ICameraRepo
    {
        private readonly SecurityGateApvDbContext _context;
        private readonly DbSet<Visit> _dbSet;

        public CameraRepo(SecurityGateApvDbContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Visit>();
        }
    }
}