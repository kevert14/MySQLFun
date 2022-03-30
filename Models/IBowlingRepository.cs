using System;
using System.Linq;

namespace MySQLFun.Models
{
    public interface IBowlingRepository
    {
        IQueryable<Bowler> Bowlers { get; }
    }
}
