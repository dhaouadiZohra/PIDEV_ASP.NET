using DATA.Infrastructure;
using Domain.Entities;
using Services.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CongerService : Service<CongerService>, ICongerService
    {
        private static DatabaseFactory dbf = new DatabaseFactory();
        private static UnitOfWork uof = new UnitOfWork(dbf);
        public CongerService() : base(uof)
        {



        }
                public virtual conger GetById(long id)
        {
            //  return _repository.GetById(id);
            return uof.getRepository<conger>().GetById(id);
        }
        public virtual void Delete(conger entity)
        {
            //   _repository.Delete(entity);
            uof.getRepository<conger>().Delete(entity);
        }





    }
}

