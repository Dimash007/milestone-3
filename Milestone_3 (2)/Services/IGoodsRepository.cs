﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Milestone_3.Models.Goods;

namespace Milestone_3.Services
{
    public interface IGoodsRepository
    {
        void Add(Good good);

        void Update(Good good);
        Task Save();

        Task<List<Good>> GetAll();

        Task<List<Good>> GetGoods(Expression<Func<Good,bool>> predicate);
    }
}