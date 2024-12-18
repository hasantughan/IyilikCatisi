using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class EtkinlikBS:IEtkinlikBS
    {
        private readonly IEtkinlikRepository _repo;

        public EtkinlikBS(IEtkinlikRepository repo)
        {
            _repo = repo;
        }

    }
}
