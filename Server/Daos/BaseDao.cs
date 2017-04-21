using Server.Context;
using Server.Model;
using Shared.Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Daos
{
    public abstract class BaseDao
    {
        protected BujinkanContext _modelContext;

        internal BaseDao(IUnitOfWork unitOfWork)
        {
            _modelContext = (BujinkanContext)unitOfWork.GetContext();
        }

        protected BujinkanContext GetModelContext()
        {
            return _modelContext;
        }
    }
}
