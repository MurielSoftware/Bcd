using Server.Services.Dojos;
using Server.Services.Events;
using Server.Services.Roles;
using Server.Services.Trainings;
using Server.Services.Users;
using Shared.Core.Context;
using Shared.Services.Dojos;
using Shared.Services.Events;
using Shared.Services.Roles;
using Shared.Services.Trainings;
using Shared.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core
{
    public class ServiceManager
    {
        //private static Dictionary<Type, Type> SERVICES = CreateServiceMapping();
        private static System.Reflection.Assembly assembly = System.Reflection.Assembly.Load("Server");

        private IUnitOfWork _unitOfWork;

        public ServiceManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public T Get<T>()
        {
            Type type = assembly.GetTypes().Where(x => x.Name == GetInstanceName(typeof(T))).SingleOrDefault();
            return (T)Activator.CreateInstance(type, new object[] { _unitOfWork });
            //return (T)assembly.CreateInstance(GetInstanceName(typeof(T)));
            //return (T)Activator.CreateInstance(SERVICES[typeof(T)], new object[] { _unitOfWork });
        }

        private static string GetInstanceName(Type type)
        {
            return type.Name.Substring(1);
        }

        //private static Dictionary<Type, Type> CreateServiceMapping()
        //{
        //    Dictionary<Type, Type> map = new Dictionary<Type, Type>();
        //    map.Add(typeof(IUserCRUDService), typeof(UserCRUDService));
        //    map.Add(typeof(ITrainingCRUDService), typeof(TrainingCRUDService));
        //    map.Add(typeof(IDojoCRUDService), typeof(DojoCRUDService));
        //    map.Add(typeof(IRoleCRUDService), typeof(RoleCRUDService));
        //    map.Add(typeof(ISeminarCRUDService), typeof(SeminarCRUDService));
        //    return map;
        //}
    }
}
