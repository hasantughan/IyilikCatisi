using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class UyelikDurumuBS:IUyelikDurumuBS
    {
        private readonly IUyelikDurumuRepository _repo;

        public UyelikDurumuBS(IUyelikDurumuRepository repo)
        {
            _repo = repo;
        }


    }
}
