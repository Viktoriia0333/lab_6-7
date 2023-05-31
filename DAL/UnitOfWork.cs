using System;

namespace DAL
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly Context BD;

        public IGenericRepository<Room> Rooms { get; }

        public IGenericRepository<Status> Statuses { get; }


        private bool Disposed;

        public UnitOfWork(Context bD, IGenericRepository<Room> rooms, IGenericRepository<Status> statuses)
        {
            BD = bD;
            Statuses = statuses;
            Rooms = rooms;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (Disposed) return;
            if (disposing)
            {
                BD.Dispose();
            }

            Disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            bool saveFailed;
            do
            {
                saveFailed = false;

              
                    BD.SaveChanges();
                
             

            } while (saveFailed);
        }


    }
}
