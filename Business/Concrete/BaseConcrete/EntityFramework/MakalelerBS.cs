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
    public class MakalelerBS:IMakalelerBS

    {
        private readonly IMakalelerRepository _repo;

        public MakalelerBS(IMakalelerRepository repo)
        {
            _repo = repo;
        }



    }
}
