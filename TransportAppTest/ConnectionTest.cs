using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportApp;

namespace TransportAppTest
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        public void twoCorrectStation_getConnections_outputIsNotNull()
        {
            //arrange
            Connection connection = new Connection();

            //act
            List<string> connectionList = connection.GetConnections("Sursee", "Luzern");

            //assert
            Assert.IsNotNull(connectionList);
        }

        [TestMethod]
        public void oneNotExistingStation_getConnections_stationDoesNotExist()
        {
            //arrange
            Connection connection = new Connection();
            List<string> output = new List<string>();

            //act
            List<string> connectionList = connection.GetConnections("Sursee", "sdadadad");

            output.Add("Eine ihrer eingegebenen");
            output.Add("Station existiert nicht.");


            //assert
            CollectionAssert.AreEqual(connectionList, output);

        }

        [TestMethod]
        public void twoCorrectStationOneWithNoConnections_getConnections_stationsHaveNoConnections()
        {
            //arrange
            Connection connection = new Connection();
            List<string> output = new List<string>();

            //act
            List<string> connectionList = connection.GetConnections("Sursee", "Sursee, Surentalstr. 10");

            output.Add("Eine Station existiert nicht");
            output.Add("oder hat keine Verbindungen.");

            //assert
            CollectionAssert.AreEqual(connectionList, output);
        }
    }
}
