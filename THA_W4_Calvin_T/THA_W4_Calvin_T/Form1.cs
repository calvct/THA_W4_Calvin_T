using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace THA_W4_Calvin_T
{
    public partial class Form1 : Form
    {
        List<Team> teams = new List<Team>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddTeam_Click(object sender, EventArgs e)
        {
            bool benar = false;
            if(!string.IsNullOrEmpty(tbox_Country.Text) && !string.IsNullOrEmpty(tbox_TeamName.Text) && !string.IsNullOrEmpty(tbox_City.Text))
            {
                foreach(Team team in teams)
                {
                    if(team.TeamCountry.ToUpper() == tbox_Country.Text.ToUpper())
                    {
                        if(team.TeamName.ToUpper() == tbox_TeamName.Text.ToUpper())
                        {
                            benar = true;
                        }
                    }
                }
                if(benar == true)
                {
                    
                    MessageBox.Show("Team name already exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                }
                else
                {
                    teams.Add(new Team
                    {
                        TeamCountry = tbox_Country.Text,
                        TeamName = tbox_TeamName.Text,
                        TeamCity = tbox_City.Text,
                    });
                    UpdateCountry();
                }
                
                tbox_Country.Clear();
                tbox_City.Clear();
                tbox_TeamName.Clear();
                tbox_TeamName.Focus();
            }
            else 
            {
                MessageBox.Show("All Fields must be fiiled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddPlayer_Click(object sender, EventArgs e)
        {
            bool benar = false;
            if (!string.IsNullOrEmpty(tbox_PlayerName.Text) && !string.IsNullOrEmpty(tbox_Number.Text) && !string.IsNullOrEmpty(cmbBox_Position.Text))
            {
                if (cmbBox_Team.Text == "")
                {
                    MessageBox.Show("select a team", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (Team team in teams)
                    {
                        if (team.TeamName.ToLower() == cmbBox_Team.SelectedItem.ToString().ToLower())
                        {
                            foreach (Player player in team.Players)
                            {

                                if (player.playerNum.ToUpper() == tbox_Number.Text.ToUpper())
                                {
                                    benar = true;
                                }
                            }
                            if (benar == true)
                            {

                                MessageBox.Show("The number already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                team.Players.Add(new Player
                                {
                                    playerName = tbox_PlayerName.Text,
                                    playerNum = tbox_Number.Text,
                                    playerPos = cmbBox_Position.Text
                                });
                            }
                            break;
                        }
                    }
                }
                UpdatePlayer();
                tbox_PlayerName.Clear();
                tbox_Number.Clear();
                cmbBox_Position.SelectedIndex = -1;
                tbox_PlayerName.Focus();
            }
            else
            {
                MessageBox.Show("All Fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBox_Team_SelectionChangeCommitted(object sender, EventArgs e)
        {

            UpdatePlayer();
        }

        private void cmbBox_Country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateTeam();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if(listBox_Player.Items.Count <= 11)
            {
                MessageBox.Show("Player cannot be less than 11","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                
                foreach(Team team in teams)
                {
                    if(team.TeamName.ToLower() == cmbBox_Team.Text.ToLower())
                    {
                        foreach (Player player in team.Players)
                        {
                            if (listBox_Player.SelectedItem.ToString().Contains(player.playerName))
                            {
                                team.Players.Remove(player);
                                break;
                            }
                        }
                        
                    }
                   
                }
                listBox_Player.Items.RemoveAt(listBox_Player.SelectedIndex);
            }
        }
        public void UpdatePlayer()
        {
            listBox_Player.Items.Clear();
            foreach (Team team in teams)
            {
                if (team.TeamName.ToLower() == cmbBox_Team.SelectedItem.ToString().ToLower())
                {
                    foreach (Player players in team.Players)
                    {
                        listBox_Player.Items.Add($"({players.playerNum}) {players.playerName}, {players.playerPos}");
                        listBox_Player.Sorted = true;
                    }
                    break;
                }
            }
        }
        public void UpdateTeam()
        {
            cmbBox_Team.Text = "";
            cmbBox_Team.Items.Clear();
            foreach (Team team in teams)
            {
                if (cmbBox_Country.SelectedItem.ToString() == team.TeamCountry)
                {
                    cmbBox_Team.Items.Add(team.TeamName);
                }
            }
        }
        public void UpdateCountry()
        {
            if (!cmbBox_Country.Items.Contains(tbox_Country.Text))
            {
                cmbBox_Country.Items.Add(tbox_Country.Text);
                cmbBox_Country.Text = "";
                cmbBox_Team.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Team team1 = new Team()
            {
                TeamName = "Barcelona FC",
                TeamCity = "Barcelona",
                TeamCountry = "Spain"
            };
            
            teams.Add(team1);
            Team team2 = new Team()
            {
                TeamCountry = "Spain",
                TeamName = "Real Madrid",
                TeamCity = "Madrid"
            };
            teams.Add(team2);
            Team team3 = new Team()
            {
                TeamCountry = "England",
                TeamName = "Manchester United",
                TeamCity = "Manchester"
            };
            teams.Add(team3);
            foreach (Team team in teams)
            {
                if (!cmbBox_Country.Items.Contains(team.TeamCountry))
                {
                    cmbBox_Country.Items.Add(team.TeamCountry);
                }
            }
            team1.Players.Add(new Player("Lionel Messi", "10", "FW"));
            team1.Players.Add(new Player("Gerard Pique", "03", "DF"));
            team1.Players.Add(new Player("Sergio Busquets", "05", "MF"));
            team1.Players.Add(new Player("Jordi Alba", "18", "DF"));
            team1.Players.Add(new Player("Marc-André ter Stegen", "01", "GK"));
            team1.Players.Add(new Player("Robert Lewandowski", "09", "FW"));
            team1.Players.Add(new Player("Frenkie de Jong", "21", "MF"));
            team1.Players.Add(new Player("Pedri", "16", "MF"));
            team1.Players.Add(new Player("Ousmane Dembélé", "11", "FW"));
            team1.Players.Add(new Player("Ronald Araújo", "04", "DF"));
            team1.Players.Add(new Player("Emerson Royal", "22", "DF"));

            team2.Players.Add(new Player("Karim Benzema", "09", "FW"));
            team2.Players.Add(new Player("Sergio Ramos", "04", "DF"));
            team2.Players.Add(new Player("Toni Kroos", "08", "MF"));
            team2.Players.Add(new Player("Luka Modric", "10", "MF"));
            team2.Players.Add(new Player("Raphael Varane", "05", "DF"));
            team2.Players.Add(new Player("Thibaut Courtois", "01", "GK"));
            team2.Players.Add(new Player("Federico Valverde", "15", "MF"));
            team2.Players.Add(new Player("Marco Asensio", "11", "FW"));
            team2.Players.Add(new Player("Vinícius Júnior", "20", "FW"));
            team2.Players.Add(new Player("Lucas Vázquez", "17", "DF"));
            team2.Players.Add(new Player("Nacho", "06", "DF"));

            team3.Players.Add(new Player("David de Gea", "01", "GK"));
            team3.Players.Add(new Player("Harry Maguire", "05", "DF"));
            team3.Players.Add(new Player("Bruno Fernandes", "18", "MF"));
            team3.Players.Add(new Player("Marcus Rashford", "10", "FW"));
            team3.Players.Add(new Player("Paul Pogba", "06", "MF"));
            team3.Players.Add(new Player("Scott McTominay", "39", "MF"));
            team3.Players.Add(new Player("Luke Shaw", "23", "DF"));
            team3.Players.Add(new Player("Aaron Wan-Bissaka", "29", "DF"));
            team3.Players.Add(new Player("Edinson Cavani", "07", "FW"));
            team3.Players.Add(new Player("Fred", "17", "MF"));
            team3.Players.Add(new Player("Victor Lindelöf", "02", "DF"));
        }
    }
}
