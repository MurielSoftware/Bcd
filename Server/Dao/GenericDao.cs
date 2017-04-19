using Server.Model;
using Shared.Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Dao
{
    public class GenericDao : BaseDao
    {
        public GenericDao(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        internal T Persist<T>(T entity) where T : BaseEntity
        {
            if (Guid.Empty.Equals(entity.Id))
            {
                _bujinkanContext.Set<T>().Add(entity);
            }
            else
            {

            }
            return entity;
        }
    }
}
