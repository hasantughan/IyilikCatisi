using Business.Abstract;
using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class BagislarBS:IBagislarBS
    {
        private readonly IBagislarRepository _repo;

        public BagislarBS(IBagislarRepository repo)
        {
            _repo = repo;
        }









    }
}
