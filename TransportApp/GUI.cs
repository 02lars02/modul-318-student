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
    public partial class GUI : Form
    {
        //boolean used to check to search for Connection or Connectionboard
        Boolean searchingForConnection = true;

        public GUI()
        {
            InitializeComponent();

            //When User starts Programm, it will be shown middle of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            //size should not be changed by user
            this.MaximumSize = new Size(900, 470);
            this.MinimumSize = new Size(900, 470);
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            //change label Text
            lblStartstation.Text = "Von:";
            lblEndstation.Text = "Nach:";
            //Enable second combobox
            cobEndstation.Enabled = true;
            //set boolean
            searchingForConnection = true;

            clearBoxes();
        }

        private void btnConnectionboard_Click(object sender, EventArgs e)
        {
            //change label Text
            lblStartstation.Text = "Station:";
            lblEndstation.Text = "";    //User won't see label any more
            //Enable second combobox
            cobEndstation.Enabled = false;
            //set boolean
            searchingForConnection = false;

            clearBoxes();
        }

        private void cobStartstation_DropDown(object sender, EventArgs e)
        {
            List<string> stationnames = new List<string>();
            Station station = new Station();

            //Remove old items from last search
            cobStartstation.Items.Clear();

            stationnames = station.GetStationNameSuggestion(cobStartstation.Text);
            try
            {
                foreach (string stationname in stationnames)
                {
                    cobStartstation.Items.Add(stationname);
                }
            }
            catch(ArgumentNullException)
            {
                /*throws ArgumentNullException when User made type mistake,
                but the programm can handel it, but the exception has to be cathched*/
            }
        }

        private void cobEndstation_DropDown(object sender, EventArgs e)
        {
            List<string> stationnames = new List<string>();
            Station station = new Station();

            //Remove old items from last search
            cobEndstation.Items.Clear();

            stationnames = station.GetStationNameSuggestion(cobEndstation.Text);
            try
            {
                foreach (string stationname in stationnames)
                {
                    cobEndstation.Items.Add(stationname);
                }
            }
            catch (ArgumentNullException)
            {
                /*throws ArgumentNullException when User made type mistake,
                but the programm can handel it, but the exception has to be cathched*/
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchingForConnection)
            {
                Connection connections = new Connection();
                List<string> connectionList = new List<string>();

                //Remove old items from last search
                libConnection.Items.Clear();

                connectionList = connections.GetConnections(cobStartstation.Text, cobEndstation.Text);
                foreach (string conection in connectionList)
                {
                    libConnection.Items.Add(conection);
                }
            }
            else
            {
                Connectionboard connectionboard = new Connectionboard();
                List<string> connectionboardList = new List<string>();
                //just nedded to get station with all informationen
                Station s = new Station();
                SwissTransport.Station station;

                station = s.GetStation(cobStartstation.Text);

                connectionboardList = connectionboard.GetConnectionboard(station);

                //Remove old items from last search
                libConnection.Items.Clear();

                foreach (string connection in connectionboardList)
                {
                    libConnection.Items.Add(connection);
                }
            }
        }

        /// <summary>
        /// resets all GUI components with text in it
        /// </summary>
        private void clearBoxes()
        {
            cobStartstation.Items.Clear();
            cobStartstation.Text = "";
            cobEndstation.Items.Clear();
            cobEndstation.Text = "";
            libConnection.Items.Clear();
        }
    }
}