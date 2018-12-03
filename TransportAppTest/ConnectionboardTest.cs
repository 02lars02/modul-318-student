using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportApp;

namespace TransportAppTest
{
    [TestClass]
    public class ConnectionboardTest
    {
        [TestMethod]
        public void oneCorrectStation_getConnectionboard_outputIsNotNull()
        {
            //arrange
            Connectionboard connectionboard = new Connectionboard();
            Station s = new Station();
            SwissTransport.Station station;
            station = s.GetStation("Basel SBB");

            //act
            List<string> connectionboardList = connectionboard.GetConnectionboard(station);

            //assert
            Assert.IsNotNull(connectionboardList);
        }

        [TestMethod]
        public void oneInvalidStation_getConnectionboard_stationsDoesNotExists()
        {
            //arrange
            Connectionboard connectionboard = new Connectionboard();
            Station s = new Station();
            SwissTransport.Station station;
            station = s.GetStation("afdasf");
            List<string> output = new List<string>();

            //act
            List<string> connectionboardList = connectionboard.GetConnectionboard(station);

            output.Add("Diese Station existiert nicht");
            output.Add("oder hat keine Verbindungen.");

            //assert
            CollectionAssert.AreEqual(connectionboardList, output);
        }

        [TestMethod]
        public void oneCorrectStationWithNoConnections_getConnectionboard_stationsHaveNoConnections()
        {
            //arrange
            Connectionboard connectionboard = new Connectionboard();
            Station s = new Station();
            SwissTransport.Station station;
            station = s.GetStation("Luzerner Kantonalbank AG, Luzern, Fanghöfli 6");
            List<string> output = new List<string>();

            //act
            List<string> connectionboardList = connectionboard.GetConnectionboard(station);

            output.Add("Luzerner Kantonalbank AG, Luzern, Fanghöfli 6");
            output.Add("Diese Station existiert nicht");
            output.Add("oder hat keine Verbindungen.");

            //assert
            CollectionAssert.AreEqual(connectionboardList, output);
        }
    }
}
