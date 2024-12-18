using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class RollerBS:IRollerBS
    {
        private readonly IRollerRepository _repo;

        public RollerBS(IRollerRepository repo)
        {
            _repo = repo;
        }
    }
}
