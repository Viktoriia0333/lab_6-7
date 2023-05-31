using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class RoomsActions : IRoomActions
    {
        IMapper MRoom = new MapperConfiguration(cfg => cfg.CreateMap<Room, MRoom>()).CreateMapper();
        IMapper MStatus = new MapperConfiguration(cfg => cfg.CreateMap<Status, Status>()).CreateMapper();
        private readonly IUnitOfWork _uow;

        public RoomsActions(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public virtual List<MRoom> GetRooms()
        {
            return MRoom.Map<IEnumerable<Room>, List<MRoom>>(_uow.Rooms.Get());
        }

        public virtual List<Status> GetStatuses()
        {
            return MStatus.Map<IEnumerable<Status>, List<Status>>(_uow.Statuses.Get());
        }


        public virtual MRoom GetRoomById(int id)
        {
            return MRoom.Map<Room, MRoom>(_uow.Rooms.GetOne(x => (x.ID == id)));
        }

        public virtual bool AddRoom(MRoom newroom)
        {
            _uow.Rooms.Create(new Room() { ID = newroom.ID,Status = newroom.Status,Category = newroom.Category , DateTo = newroom.DateTo , Day_Price = newroom.Day_Price , Status_FK = newroom.Status_FK});
            _uow.Save();
            return true;
        }

        public virtual bool DeleteRoomByID(int id)
        {
            _uow.Rooms.Remove(_uow.Rooms.FindById(id));
            _uow.Save();
            return true;
        }


        public virtual bool ChangeRoom(MRoom newroom)
        {

            _uow.Rooms.Update(new Room() { ID = newroom.ID, Status = newroom.Status, Category = newroom.Category, DateTo = newroom.DateTo, Day_Price = newroom.Day_Price, Status_FK = newroom.Status_FK });
            _uow.Save();
            return true;
        }

        public virtual bool SaveThis()
        {
            _uow.Save();
            return true;
        }
    }
}
