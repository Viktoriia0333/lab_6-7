using DAL;
using Ninject;
using Ninject.Modules;

namespace BLL.Dependencies
{
    public class BusinessLogicModule : NinjectModule
    {
        public override void Load()
        {
            var unitOfWork = new StandardKernel(new DataAccessModule()).Get<IUnitOfWork>();
            Bind<IRoomActions>().ToConstructor(x => new RoomsActions(unitOfWork));
        }
    }
}
