using System.Collections.Generic;
using System.Web.Http;
using BLL;

namespace UI.Controllers
{
    public class RoomController : ApiController
    {
        private readonly IRoomActions roomActions;

        public RoomController(IRoomActions roomActions)
        {
            this.roomActions = roomActions;
        }

        // GET: api/Room
        public IEnumerable<MRoom> Get()
        {
            return roomActions.GetRooms();
        }

        // GET: api/Room/5
        public MRoom Get(int id)
        {
            return roomActions.GetRoomById(id);
        }

        // POST: api/Room
        public void Post([FromBody]MRoom value)
        {
            roomActions.AddRoom(value);
        }

        // PUT: api/Room/5
        public void Put(int id, [FromBody]MRoom value)
        {
            roomActions.ChangeRoom(value);
        }

        // DELETE: api/Room/5
        public void Delete(int id)
        {
            roomActions.DeleteRoomByID(id);
        }
    }
}
