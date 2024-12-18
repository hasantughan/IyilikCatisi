using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class KullaniciRolBS:IKullaniciRolBS
    {
        private readonly IKullaniciRolRepository _repo;

        public KullaniciRolBS(IKullaniciRolRepository repo)
        {
           _repo = repo;
        }
    }
}
