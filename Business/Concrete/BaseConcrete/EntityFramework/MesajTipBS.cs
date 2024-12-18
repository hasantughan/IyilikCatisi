using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class MesajTipBS:IMesajTipBS
    {
        private readonly IMesajTipRepository _repo;

        public MesajTipBS(IMesajTipRepository repo)
        {
            _repo = repo;
        }
    }
}
