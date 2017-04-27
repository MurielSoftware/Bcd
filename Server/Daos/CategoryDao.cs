using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Shared.Dtos.Categories;
using Shared.Core.Dtos;
using Server.Model;

namespace Server.Daos
{
    public class CategoryDao : BaseDao
    {
        public CategoryDao(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        internal ListReferenceDto FindAllReferences<T>(CategoryFilterDto categoryFilterDto) where T : Category
        {
            Dictionary<Guid, string> references = _modelContext.Set<T>()
                .Where(ExpressionQueryBuilder.BuildWhere<T>(categoryFilterDto))
                .OrderBy(x => x.Name)
                .Select(x => new { Id = x.Id, Name = x.Name })
                .ToDictionary(x => x.Id, x => x.Name);
            return new ListReferenceDto() { References = references };
        }
    }
}
