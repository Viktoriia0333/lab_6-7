using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUnitOfWork
    {
        IGenericRepository<Room> Rooms { get; }

        IGenericRepository<Status> Statuses { get; }


        void Save();
        void Dispose();
    }
}
