using Data.Abstract;
using Data.Concrete.EntityFramework.context;
using Infrastructure.Abstract;
using Infrastructure.Concrete.EntityFramework;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EntityFramework.repository
{
    public class EfBildirimlerRepository:EfRepositoryBase<Bildirimler,İyilikCatisiDbContext>,IBildirimlerRepository
    {
    }
}
