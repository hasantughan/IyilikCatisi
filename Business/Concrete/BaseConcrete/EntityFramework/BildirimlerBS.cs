using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class BildirimlerBS:IBildirimlerBS
    {

        private readonly IBildirimlerRepository _repo;

        public BildirimlerBS(IBildirimlerRepository repo)
        {
            _repo = repo;
        }





    }
}
