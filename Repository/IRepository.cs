using ProAspNetCoreMvcModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcModelBinding.Repository
{
    public interface IRepository
    {
        IEnumerable<ProAspNetCoreMvcModelBinding.Models.Pessoa> Pessoa { get; }
        Pessoa this[int id] { get; set; }
    }
}
