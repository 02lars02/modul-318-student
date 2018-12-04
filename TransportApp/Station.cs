using System;
using System.Collections.Generic;
using System.Linq;

namespace TransportApp
{
    public class Station
    {
        /// <summary>
        /// returns List of strings which you can print afterwards.
        /// The list contains stations name which are similare to the parameter string
        /// </summary>
        /// <param name="station"></param>
        /// <returns></returns>
        public List<string> GetStationNameSuggestion(string station)
        {
            List<string> output = new List<string>();
            SwissTransport.Transport transport = new SwissTransport.Transport();
            List<SwissTransport.Station> stations = new List<SwissTransport.Station>();

            stations = transport.GetStations(station).StationList;
            foreach (SwissTransport.Station transportStation in stations)
            {
                string stationname = transportStation.Name;
                output.Add(stationname);
            }

            return output;
        }

        /// <summary>
        /// Check if the Programm find a Station which have a similar name, to choose this
        /// </summary>
        /// <param name="station"></param>
        public Boolean CheckStation(string station)
        {
            List<string> possibleStations = GetStationNameSuggestion(station);

            //list is zero when there are no options
            if (possibleStations.Count == 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// returns the station with the most similar text
        /// </summary>
        /// <param name="station"></param>
        public SwissTransport.Station GetStation(string station)
        {
            SwissTransport.Transport transport = new SwissTransport.Transport();
            List<SwissTransport.Station> stations = new List<SwissTransport.Station>();

            stations = transport.GetStations(station).StationList;

            if (stations.Count() > 0)
            {
                return stations.First();
            }
            else
            {
                return null;
            }
        }
    }
}
