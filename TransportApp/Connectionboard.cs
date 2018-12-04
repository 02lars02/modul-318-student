using System;
using System.Collections.Generic;
using SwissTransport;

namespace TransportApp
{
    public class Connectionboard
    {
        /// <summary>
        /// returns List of strings which you can print afterwards.
        /// The list contains connections from start station from now
        /// </summary>
        /// <param name="station"></param>
        /// <returns></returns>
        public List<string> GetConnectionboard(SwissTransport.Station station)
        {
            List<string> output = new List<string>();
            Transport transport = new Transport();
            StationBoardRoot connectionboard;

            try
            {
                //could return null!
                connectionboard = transport.GetStationBoard(station.Name, station.Id);
                //shows Stationname first in the listbox
                output.Add(station.Name);

                foreach (StationBoard connection in connectionboard.Entries)
                {
                    //Substrings the String so, that only hh:mm will be shown
                    String departure = connection.Stop.Departure.ToString().Substring(11, 5);

                    //check if there is a platform
                    string platform;
                    if (connection.Stop.Platform == null)
                    {
                        //will not show a platform, because at the most station with this information it has only one
                        platform = "";
                    }
                    else
                    {
                        platform = "Gleis: " + connection.Stop.Platform;
                    }

                    output.Add(departure + " " + connection.To + " " + platform);
                }
            }
            catch(NullReferenceException)
            {
                //two output, so it will shown on two lines
                output.Add("Diese Station existiert nicht");
                output.Add("oder hat keine Verbindungen.");
            }

            return output;
        }
    }
}