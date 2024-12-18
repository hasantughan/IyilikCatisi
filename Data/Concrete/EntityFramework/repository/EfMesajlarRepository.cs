using Data.Abstract;
using Data.Concrete.EntityFramework.context;
using Infrastructure.Concrete.EntityFramework;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EntityFramework.repository
{
    public class EfMesajlarRepository:EfRepositoryBase<Mesajlar,İyilikCatisiDbContext>,IMesajlarRepository
    {
    }
}
