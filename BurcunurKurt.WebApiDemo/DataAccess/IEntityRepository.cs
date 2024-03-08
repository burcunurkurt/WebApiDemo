﻿using BurcunurKurt.WebApiDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BurcunurKurt.WebApiDemo.DataAccess
{
    public interface IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter = null);
        List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null);
        void Update(TEntity entity);
    }
}
