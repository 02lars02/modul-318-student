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
            List<string> connectionList = connection.GetConnections("Sursee", "Luzern", "2018-12-13", "16:30");

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
            List<string> connectionList = connection.GetConnections("Sursee", "sdadadad", "2018-12-13", "16:30");

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
            List<string> connectionList = connection.GetConnections("Sursee", "Sursee, Surentalstr. 10", "2018-12-13", "16:30");

            output.Add("Eine Station existiert nicht");
            output.Add("oder hat keine Verbindungen.");

            //assert
            CollectionAssert.AreEqual(connectionList, output);
        }

        [TestMethod]
        public void twoCorrectStationAndADateFarBehindToday_getConnections_noInformationForThisDate()
        {
            //arrange
            Connection connection = new Connection();
            List<string> output = new List<string>();

            //act
            List<string> connectionList = connection.GetConnections("Sursee", "Luzern", "2006-12-13", "16:30");

            output.Add("Zu diesem Datum konnten keine");
            output.Add("Informationen gefunden werden.");

            //assert
            CollectionAssert.AreEqual(connectionList, output);
        }
    }
}
