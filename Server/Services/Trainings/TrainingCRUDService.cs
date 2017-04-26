using Server.Model;
using Shared.Core.Context;
using Shared.Dtos.Trainings;
using Shared.Services.Trainings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using Server.Daos;
using Shared.Core.Utils;

namespace Server.Services.Trainings
{
    public class TrainingCRUDService : UserDefinableCRUDService<TrainingDto, Training>, ITrainingCRUDService
    {
        private TrainingDao _trainingDao;

        public TrainingCRUDService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _trainingDao = new TrainingDao(unitOfWork);
        }

        public IPagedList<TrainingDto> ReadAdministrationPaged(TrainingFilterDto trainingFilterDto)
        {
            return _trainingDao.FindPaged(trainingFilterDto);
        }

        protected override Training CreateEntity(TrainingDto trainingDto)
        {
            Training training = base.CreateEntity(trainingDto);
            DateTime timeStart = StringUtils.ParseTime(trainingDto.TimeStart);
            DateTime timeEnd = StringUtils.ParseTime(trainingDto.TimeEnd);
            training.Start = timeStart;
            training.End = timeEnd;
            return training;
        }

        protected override TrainingDto CreateDto(Training training)
        {
            TrainingDto trainingDto = base.CreateDto(training);
            trainingDto.TimeStart = StringUtils.ParseTime(trainingDto.Start);
            trainingDto.TimeEnd = StringUtils.ParseTime(trainingDto.End);
            return trainingDto;
        }
    }
}
