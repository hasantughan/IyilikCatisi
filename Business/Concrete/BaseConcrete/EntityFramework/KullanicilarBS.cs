using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class KullanicilarBS:IKullanicilarBS
    {
        private readonly IKullanicilarRepository _repo;

        public KullanicilarBS(IKullanicilarRepository repo)
        {
            _repo = repo;
        }



    }
}
