using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class BildirimKullaniciBS:IBildirimKullaniciBS
    {
        private readonly IBildirimKullaniciRepository _repo;

        public BildirimKullaniciBS(IBildirimKullaniciRepository repo)
        {
            _repo = repo;
        }



    }
}
