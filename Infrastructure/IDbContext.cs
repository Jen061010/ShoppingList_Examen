﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IDbContext
    {
         IDbSet<TEntity> GetSet<TEntity>() where TEntity : class;
        


    }
}
