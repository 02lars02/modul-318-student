using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TransportApp;
using System.Collections.Generic;

namespace TransportAppTest
{
    [TestClass]
    public class StationTest
    {
        List<string> listOfStationnameSursee = new List<string>();
        private void initalizeListOfStationnameSursee()
        {
            listOfStationnameSursee.Add("Sursee");
            listOfStationnameSursee.Add("Sursee, Bahnhof");
            listOfStationnameSursee.Add("Sursee, Park");
            listOfStationnameSursee.Add("Sursee, Altstadt");
            listOfStationnameSursee.Add("Sursee, Mariazell");
            listOfStationnameSursee.Add("Sursee, Spital");
            listOfStationnameSursee.Add("Sursee, Frieslirain");
            listOfStationnameSursee.Add("Sursee, Kotten");
            listOfStationnameSursee.Add("Sursee, Surentalstrasse");
            listOfStationnameSursee.Add("Sursee, Sonnhalde");
        }


        [TestMethod]
        public void writeParteOfAStationname_getStationNameSuggestion_correctStationToChoose()
        {
            //arrange
            initalizeListOfStationnameSursee();
            Station station = new Station();

            //act
            List<string> result = station.GetStationNameSuggestion("Sursee");
            
            //assert
            CollectionAssert.AreEqual(listOfStationnameSursee, result);
        }

        [TestMethod]
        public void writeParteOfAStationname_checkStation_answerThatAStationWithSimilarNameExists()
        {
            //arrange
            Station station = new Station();

            //act
            Boolean result = station.CheckStation("Sursee");

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void writeSomethingWhichDoesNotExist_checkStation_answerThatAStationWithSimilarNameExists()
        {
            //arrange
            Station station = new Station();

            //act
            Boolean result = station.CheckStation("asfasfas");

            //assert
            Assert.IsFalse(result);
        }
    }
}