using Business.Abstract;
using Data.Abstract;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.BaseConcrete.EntityFramework
{
    public class YorumTipBS:IYorumTipBS
    {
        private readonly IYorumTipRepository _repo;

        public YorumTipBS(IYorumTipRepository repo)
        {
             _repo = repo;
        }
    }


}
