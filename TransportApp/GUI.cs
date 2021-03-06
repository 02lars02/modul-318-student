﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class GUI : Form
    {
        //boolean used to check for searchig for Connection or Connectionboard
        Boolean searchingForConnection = true;
        //boolean used for autocompletion to know in which combobox the autocompleted text should be set
        Boolean isStartstationSelected = true;

        public GUI()
        {
            InitializeComponent();

            //When User starts Programm, it will be shown middle of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            //size should not be changed by user
            this.MaximumSize = new Size(900, 470);
            this.MinimumSize = new Size(900, 470);

            //make dtpTime only allow to take time and only in format HH:mm
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH:mm";
            dtpTime.ShowUpDown = true;
        }

        //when the button "Verbindungen" be pressed, all the elements needed will be activated
        private void btnConnection_Click(object sender, EventArgs e)
        {
            //change label Text
            lblStartstation.Text = "Von:";
            lblEndstation.Text = "Nach:";
            //Enable second combobox and dateTimePickers
            txtEndstation.Enabled = true;
            dtpDate.Enabled = true;
            dtpTime.Enabled = true;
            //set boolean
            searchingForConnection = true;

            clearBoxes();
        }

        //when the button "Verbindungen" be pressed, all the elements needed will be activated and disabled unused
        private void btnConnectionboard_Click(object sender, EventArgs e)
        {
            //change label Text
            lblStartstation.Text = "Station:";
            lblEndstation.Text = "";    //User won't see label any more
            //Disabel second combobox and dateTimePickers
            txtEndstation.Enabled = false;
            dtpDate.Enabled = false;
            dtpTime.Enabled = false;
            //set boolean
            searchingForConnection = false;

            clearBoxes();
        }

        /// <summary>
        /// resets all GUI components with text in it.
        /// </summary>
        private void clearBoxes()
        {
            txtStartstation.Text = "";
            txtEndstation.Text = "";
            libConnection.Items.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //searching for connection or searching for connectionboard
                if (searchingForConnection)
                {
                    Connection connections = new Connection();
                    List<string> connectionList = new List<string>();

                    //Remove old items from last search
                    libConnection.Items.Clear();

                    connectionList = connections.GetConnections(txtStartstation.Text, txtEndstation.Text, dtpDate.Value.ToString("yyyy-MM-dd"), dtpTime.Value.ToString("HH:mm"));

                    //add all item to listbox
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

                    //Remove old items from last search
                    libConnection.Items.Clear();

                    //get the station for Methode GetConnectionboard(station)
                    station = s.GetStation(txtStartstation.Text);

                    connectionboardList = connectionboard.GetConnectionboard(station);

                    //add all item to listbox
                    foreach (string connection in connectionboardList)
                    {
                        libConnection.Items.Add(connection);
                    }
                }
            }
            //during network problem this exception will be thrown
            catch(WebException)
            {
                MessageBox.Show("Es konnte keine Abfrage gemacht werden.\n" +
                    "Bitte versichern Sie sich das Sie mit einem Netzwerk verbunden sind.\n" +
                    "Zudem können Sie nur Tausend Abfragen pro Tag und pro IP-Adresse machen.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //when no elements are available to add to listbox this exception will be thrown
            catch (NullReferenceException)
            {
                /*Will be shown as Information in the box,
                two elements because it will be shown on two lines*/
                libConnection.Items.Add("Ihre eingegebenen Station");
                libConnection.Items.Add("existiert nicht.");
            }
        }

        private void txtStartstation_KeyDown(object sender, KeyEventArgs e)
        {
            //needed for autocompletion (libConnection_KeyDown)
            isStartstationSelected = true;

            //will be activated after the three character was typed
            if (txtStartstation.Text.Length >= 3)
            {
                List<string> stationnames = new List<string>();
                Station station = new Station();

                //Remove old items from last search
                libConnection.Items.Clear();

                stationnames = station.GetStationNameSuggestion(txtStartstation.Text);
                try
                {
                    foreach (string stationname in stationnames)
                    {
                        libConnection.Items.Add(stationname);
                    }

                    //when it is empty, this message will be shown
                    if (libConnection.Items.Count == 0)
                    {
                        libConnection.Items.Add("Keine Übereinstimmung");
                    }

                    //switch to listbox
                    if (e.KeyCode == Keys.Enter)
                    {
                        libConnection.Focus();
                        libConnection.SetSelected(0, true);
                    }
                }
                catch (ArgumentNullException)
                {
                    /*throws ArgumentNullException when User made type mistake,
                    but the programm can handel it, but the exception has to be cathched*/
                }
            }
        }

        private void txtEndstation_KeyDown(object sender, KeyEventArgs e)
        {
            //needed for autocompletion (libConnection_KeyDown)
            isStartstationSelected = false;

            //will be activated after the three character was typed
            if (txtEndstation.Text.Length >= 3)
            {
                List<string> stationnames = new List<string>();
                Station station = new Station();

                //Remove old items from last search
                libConnection.Items.Clear();

                stationnames = station.GetStationNameSuggestion(txtEndstation.Text);
                try
                {
                    foreach (string stationname in stationnames)
                    {
                        libConnection.Items.Add(stationname);
                    }

                    //when it is empty, this message will be shown
                    if (libConnection.Items.Count == 0)
                    {
                        libConnection.Items.Add("Keine Übereinstimmung");
                    }

                    //switch to listbox
                    if (e.KeyCode == Keys.Enter)
                    {
                        libConnection.Focus();
                        libConnection.SetSelected(0, true);
                    }
                }
                catch (ArgumentNullException)
                {
                    /*throws ArgumentNullException when User made type mistake,
                    but the programm can handel it, but the exception has to be cathched*/
                }
            }
        }

        private void libConnection_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //check in which textbox text should be written
                if(isStartstationSelected)
                {
                    //write text from selected item in listbox in combobox Startstation
                    txtStartstation.Text = libConnection.Text;
                }
                else
                {
                    //write text from selected item in listbox in combobox Endstation
                    txtEndstation.Text = libConnection.Text;
                }
            }
        }
    }
}