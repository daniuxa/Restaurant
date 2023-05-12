﻿using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Services.Interfaces
{
    //TODO
    public interface ITableService
    {
        Task<Table> AddTableAsync(Table table);
        Task<bool> SaveChangesAsync();
        Task DeleteAllTables();
    }
}