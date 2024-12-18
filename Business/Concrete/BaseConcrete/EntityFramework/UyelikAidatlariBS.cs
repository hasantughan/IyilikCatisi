using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class UyelikAidatlariBS:IUyelikAidatlariBS
    {
        private readonly IUyelikAidatlariRepository _repo;

        public UyelikAidatlariBS(IUyelikAidatlariRepository repo)
        {
            _repo = repo;
        }
    }
}
