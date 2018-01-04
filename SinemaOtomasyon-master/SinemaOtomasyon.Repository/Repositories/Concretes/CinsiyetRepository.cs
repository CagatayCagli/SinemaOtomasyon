﻿using SinemaOtomasyon.Core.Concrete;
using SinemaOtomasyon.DAL.SinemaContext;
using SinemaOtomasyon.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SinemaOtomasyon.Repository.Repositories.Concretes
{
    public class CinsiyetRepository : EFRepositoryBase<Cinsiyet, SinemaContext>, ICinsiyetRepository
    {
        public CinsiyetRepository(DbContext Context) : base(Context)
        {
        }
    }
}
