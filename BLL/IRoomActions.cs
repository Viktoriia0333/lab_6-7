using DAL;
using System.Collections.Generic;

namespace BLL
{
    public interface IRoomActions
    {
        List<MRoom> GetRooms();

        List<Status> GetStatuses();

        MRoom GetRoomById(int id);

        bool AddRoom(MRoom newroom);

        bool DeleteRoomByID(int id);

        bool ChangeRoom(MRoom newroom);

        bool SaveThis();
    }
}
