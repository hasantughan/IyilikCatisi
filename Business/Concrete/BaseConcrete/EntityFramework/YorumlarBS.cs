using Business.Abstract;
using Data.Abstract;
using Data.Concrete.EntityFramework.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class YorumlarBS:IYorumlarBS
    {
        private readonly IYorumlarRepository _repo;

        public YorumlarBS(IYorumlarRepository repo)
        {
            _repo = repo;
        }
    }
}
