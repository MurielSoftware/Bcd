using Server.Context;
using Server.Model;
using Shared.Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Dao
{
    public abstract class BaseDao
    {
        protected BujinkanContext _bujinkanContext;

        internal BaseDao(IUnitOfWork unitOfWork)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            _bujinkanContext = new BujinkanContext();
            _bujinkanContext.Set<User>().ToList();
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            //_bujinkanContext = (BujinkanContext)unitOfWork.GetContext();
        }
    }
}
