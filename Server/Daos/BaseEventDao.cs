using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Server.Model;
using PagedList;
using Shared.Dtos.Events;

namespace Server.Daos
{
    public class BaseEventDao : BaseDao
    {
        public BaseEventDao(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        internal IPagedList<T> FindPaged<T, U>(EventFilterDto eventFilterDto) where T : BaseEventDto, new() where U : BaseEvent
        {
            return _modelContext.Set<U>()
                .Where(ExpressionQueryBuilder.BuildWhere<U>(eventFilterDto))
                .OrderBy(x => x.Start)
                .Select(x => new T() { Id = x.Id, Theme = x.Theme, Start = x.Start, End = x.End, City = x.City, CountryId = x.CountryId })
                .ToPagedList(eventFilterDto.Page, eventFilterDto.PageSize);
        }
    }
}
