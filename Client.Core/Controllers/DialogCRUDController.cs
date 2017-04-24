using Shared.Core.Dtos;
using Shared.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Core.Controllers
{
    public abstract class DialogCRUDController<T, U> : CRUDController<T, U>
        where T : BaseDto
        where U : ICRUDService<T>
    {
    }
}
