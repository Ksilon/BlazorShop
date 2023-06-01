using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazShop.Client.Services.StatsService
{
    interface IStatsService
    {
        Task GetVisits();
        Task IncrementVisits();
    }
}
