using Ninject.Modules;

namespace DAL
{
    public class DataAccessModule : NinjectModule
    {
        public override void Load()
        {
            var Context = new Context();

            Bind<IGenericRepository<Room>>().ToConstructor(x => new ContextRepository<Room>(Context));
            Bind<IGenericRepository<Status>>().ToConstructor(x => new ContextRepository<Status>(Context));

            Bind<IUnitOfWork>().ToConstructor
                (x => new UnitOfWork(Context, x.Inject<IGenericRepository<Room>>(), x.Inject<IGenericRepository<Status>>()));
        }
    }
}
