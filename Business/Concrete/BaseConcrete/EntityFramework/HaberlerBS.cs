using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class HaberlerBS:IHaberlerBS
    {
        private readonly IHaberlerRepository _repo;

        public HaberlerBS(IHaberlerRepository repo)
        {
            _repo = repo;
        }


    }
}
