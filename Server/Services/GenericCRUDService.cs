using Server.Dao;
using Server.Model;
using Shared.Core.Context;
using Shared.Core.Dtos;
using Shared.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    public abstract class GenericCRUDService<T, U> : BaseService, ICRUDService<T>
        where T : BaseDto
        where U : BaseEntity
    {
        protected GenericDao _genericDao;

        public GenericCRUDService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _genericDao = new GenericDao(unitOfWork);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public T Persist(T dto)
        {
            throw new NotImplementedException();
        }

        public T Read(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }

        protected virtual U DoPersist(U entity)
        {
            throw new NotImplementedException();
        }

        protected virtual void DoDelete(U entity)
        {

        }

        protected virtual void ValidateBeforePersist()
        {

        }

        protected virtual void ValidateBeforeDelete()
        {

        }

        protected bool EntityExists(T dto)
        {
            return dto.Id != Guid.Empty;
        }
    }
}
