﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Core.Context;
using Shared.Dtos.Trainings;
using Server.Model;
using PagedList;
using Shared.Core.Dtos;

namespace Server.Daos
{
    public class TrainingDao : BaseDao
    {
        public TrainingDao(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        internal IPagedList<TrainingDto> FindPaged(TrainingFilterDto trainingFilterDto)
        {
            return _modelContext.Set<Training>()
                .Where(ExpressionQueryBuilder.BuildWhere<Training>(trainingFilterDto))
                .OrderBy(x => x.Day)
                .Select(x => new TrainingDto() { Id = x.Id, Day = x.Day, Start = x.Start, End = x.End, City = x.City, UserReference = new ReferenceString() { Value = x.UserId + ":" + x.User.FirstName + " " + x.User.Surname }, UserId = x.UserId })
                .ToPagedList(trainingFilterDto.Page, trainingFilterDto.PageSize);
        }
    }
}
