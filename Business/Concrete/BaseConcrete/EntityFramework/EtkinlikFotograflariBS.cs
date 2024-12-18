using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class EtkinlikFotograflariBS:IEtkinlikFotograflariBS
    {
        private readonly IEtkinlikFotograflariRepository _repo;

        public EtkinlikFotograflariBS(IEtkinlikFotograflariRepository repo)
        {
            _repo = repo;
        }


    }
}
