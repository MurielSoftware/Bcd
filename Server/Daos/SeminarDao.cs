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
    public class SeminarDao : BaseDao
    {
        public SeminarDao(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        internal IPagedList<SeminarDto> FindPaged(EventFilterDto eventFilterDto)
        {
            return _modelContext.Set<Seminar>()
                .Where(ExpressionQueryBuilder.BuildWhere<Seminar>(eventFilterDto))
                .OrderBy(x => x.Start)
                .Select(x => new SeminarDto() { Id = x.Id, Theme = x.Theme, Start = x.Start, End = x.End, City = x.City, CountryId = x.CountryId })
                .ToPagedList(eventFilterDto.Page, eventFilterDto.PageSize);
        }
    }
}
