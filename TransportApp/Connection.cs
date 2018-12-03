using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class Connection
    {
        public List<string> GetConnections(string startStation, string endStation, string date, string time)
        {
            List<string> output = new List<string>();
            //just needed to check station
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

                    //shwos in list box firts which connection it is
                    output.Add("Von: " + connections.First().From.Station.Name);
                    output.Add("Bis: " + connections.First().To.Station.Name);

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
                catch (NullReferenceException)
                {
                    //two output, so it will shown on two lines
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
