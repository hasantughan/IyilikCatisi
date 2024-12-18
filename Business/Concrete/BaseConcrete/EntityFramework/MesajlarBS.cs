using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class MesajlarBS:IMesajlarBS
    {
        private readonly IMesajlarRepository _repo;

        public MesajlarBS(IMesajlarRepository repo)
        {
            _repo = repo;
        }
    }
}
