using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HigherLower
{
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
            StartButton.Hide();
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            string currentUserName = UserNameTextBox.Text;
            if(currentUserName == "")
            {
                MessageBox.Show("Please enter a Name");
                return;
            }
            if (!PlayerList.DoesPlayerExist(currentUserName)) 
            {
                listBox1.Items.Add(PlayerList.NumberOfPlayers + ")  " + currentUserName);
                Player newPlayer = new Player(currentUserName);
                PlayerList.AddPlayerInVector(newPlayer);

                UserNameTextBox.Clear();
                if (PlayerList.IsGameFull())
                    AddPlayerButton.Hide();

                if (PlayerList.AreEnoughPlayers())
                    StartButton.Show();
            }
            else
            {
                MessageBox.Show("This username is already used");
            }
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            FirstPlayerView frm = new FirstPlayerView();
            frm.Show();
        }
    }
}
