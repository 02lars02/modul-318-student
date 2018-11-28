using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class Verbindung : Form
    {
        public Verbindung()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sie befinden sich bereits auf dieser Seite.");
        }

        private void btnConnectionboard_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cobStartstation_DropDown(object sender, EventArgs e)
        {
            cobStartstation.Items.Clear(); //Remove old items from last search
            SwissTransport.Transport transport = new SwissTransport.Transport();
            List<SwissTransport.Station> stations = new List<SwissTransport.Station>();
            stations = transport.GetStations(cobStartstation.Text).StationList;

            foreach (SwissTransport.Station station in stations)
            {
                cobStartstation.Items.Add(station.Name);
            }
        }

        private void cobEndstation_DropDown(object sender, EventArgs e)
        {
            cobEndstation.Items.Clear(); //Remove old items from last search
            SwissTransport.Transport transport = new SwissTransport.Transport();
            List<SwissTransport.Station> stations = new List<SwissTransport.Station>();
            stations = transport.GetStations(cobEndstation.Text).StationList;

            foreach (SwissTransport.Station station in stations)
            {
                cobEndstation.Items.Add(station.Name);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SwissTransport.Transport transport = new SwissTransport.Transport();
            List<SwissTransport.Connection> connections = new List<SwissTransport.Connection>();
            connections = transport.GetConnections(cobStartstation.Text, cobEndstation.Text).ConnectionList;

            foreach (SwissTransport.Connection connection in connections)
            {
                //Substrings the String so, that only hh:mm will be shown
                string departureTime = connection.From.Departure.Substring(11, 5);
                string arrivalTime = connection.To.Arrival.Substring(11, 5);

                libConnection.Items.Add(departureTime + "-" + arrivalTime + " Gleis " + connection.From.Platform);
            }
        }
    }
}
