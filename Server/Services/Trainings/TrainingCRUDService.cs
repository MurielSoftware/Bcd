using Server.Model;
using Shared.Core.Context;
using Shared.Dtos.Trainings;
using Shared.Services.Trainings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services.Trainings
{
    public class TrainingCRUDService : UserDefinableCRUDService<TrainingDto, Training>, ITrainingCRUDService
    {
        public TrainingCRUDService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
