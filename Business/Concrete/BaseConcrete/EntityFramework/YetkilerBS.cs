using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class YetkilerBS:IYetkilerBS
    {
        private readonly IYetkilerRepository _repo;

        public YetkilerBS(IYetkilerRepository repo)
        {
            _repo = repo;
        }


    }
}
