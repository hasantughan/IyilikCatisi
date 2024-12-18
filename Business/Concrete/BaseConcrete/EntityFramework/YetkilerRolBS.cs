using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class YetkilerRolBS:IYetkiRolBS
    {
        private readonly IYetkiRolRepository _repo;

        public YetkilerRolBS(IYetkiRolRepository repo)
        {
            _repo = repo;
        }



    }
}
