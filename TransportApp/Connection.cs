using System;
using System.Collections.Generic;
using System.Linq;

namespace TransportApp
{
    public class Connection
    {
        /// <summary>
        /// returns List of strings which you can print afterwards.
        /// The list contains connections between start and end station by specified date and time
        /// </summary>
        /// <param name="startStation"></param>
        /// <param name="endStation"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public List<string> GetConnections(string startStation, string endStation, string date, string time)
        {
            List<string> output = new List<string>();
            Station s = new Station();

            //check if the Station is valid
            if (s.CheckStation(startStation) && s.CheckStation(endStation))
            {
                try
                {
                    SwissTransport.Transport transport = new SwissTransport.Transport();
                    List<SwissTransport.Connection> connections = new List<SwissTransport.Connection>();

                    //could return null!
                    connections = transport.GetConnections(startStation, endStation, date, time).ConnectionList;

                    //When Time is to far back, the API won't send items
                    if (connections.Count() == 0)
                    {
                        /*Will be shown as Information in the box,
                        two elements because it will be shown on two lines*/
                        output.Add("Zu diesem Datum konnten keine");
                        output.Add("Informationen gefunden werden.");
                    }
                    else
                    {
                        //shwos in list box first which connection it is
                        output.Add("Von: " + startStation);
                        output.Add("Bis: " + endStation);

                        foreach (SwissTransport.Connection connection in connections)
                        {
                            //Substrings the String so, that only hh:mm will be shown
                            string departureTime = connection.From.Departure.Substring(11, 5);
                            string arrivalTime = connection.To.Arrival.Substring(11, 5);

                            //platform could be null !!!
                            string platform;
                            if (connection.From.Platform == null)
                            {
                                platform = "Keine Angaben";
                            }
                            else
                            {
                                platform = "Gleis " + connection.From.Platform;
                            }

                            output.Add(departureTime + "-" + arrivalTime + " " + platform);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                    /*Will be shown as Information in the box,
                    two elements because it will be shown on two lines*/
                    output.Add("Eine Station existiert nicht");
                    output.Add("oder hat keine Verbindungen.");
                }
            } else
            {
                /*Will be shown as Information in the box,
                two elements because it will be shown on two lines*/
                output.Add("Eine ihrer eingegebenen");
                output.Add("Station existiert nicht.");
            }
            return output;
        }
    }
}
