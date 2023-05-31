using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using BLL;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using Assert = NUnit.Framework.Assert;


namespace Tests
{
    [TestClass]
    public class OrderTests
    {
        private UnitOfWork uow;

        Context context = new Context();
        Mock<RoomsActions> mock;

        public OrderTests()
        {
            mock = new Mock<RoomsActions>();
            uow = new UnitOfWork(context, new ContextRepository<Room>(context) , new ContextRepository<Status>(context));
        }

        [TestMethod]
        public void GetTest()
        {


            List<MRoom> list = new List<MRoom>();
            MRoom u = new MRoom() { };
            mock.Setup(a => a.AddRoom(u));
            mock.Setup(a => a.GetRooms()).Returns(list);

            Assert.That(mock.Object.GetRooms(), Is.Not.Null);
        }


        [TestMethod]
        public void GetById()
        {

            List<MRoom> list = new List<MRoom>();
            MRoom u = new MRoom() { ID = 1 };
            mock.Setup(a => a.AddRoom(u));
            mock.Setup(a => a.GetRoomById(1)).Returns(u);

            Assert.That(mock.Object.GetRoomById(1), Is.EqualTo(u));
        }


        [TestMethod]
        public void AddTest()
        {

            List<MRoom> list = new List<MRoom>();
            MRoom u = new MRoom() { };
            mock.Setup(a => a.AddRoom(u)).Returns(true);

            Assert.That(mock.Object.AddRoom(u), Is.True);

        }


        [TestMethod]
        public void DeleteByIDTest()
        {

            List<MRoom> list = new List<MRoom>();
            MRoom u = new MRoom() { ID = 1 };
            mock.Setup(a => a.AddRoom(u)).Returns(true);
            mock.Setup(a => a.DeleteRoomByID(1)).Returns(true);

            Assert.That(mock.Object.DeleteRoomByID(1), Is.True);

        }
    }
}
