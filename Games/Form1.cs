using System;
using System.Linq;
using System.Windows.Forms;

namespace Games
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private GamesDBEntities context = new GamesDBEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateCombobox();
        }

        private void ButtonDevelopersAdd_Click(object sender, EventArgs e)
        {
            string developerName = TBDevelopername.Text;
            string developerCountry = TBDeveloperCountry.Text;
            Developer developer = new Developer();
            developer.Name = developerName;
            developer.Country = developerCountry;
            context.Developers.Add(developer);
            context.SaveChanges();
            UpdateCombobox();
        }

        private void UpdateCombobox()
        {
            comboBox3.DataSource = (from q in context.Games select q).ToList();
            comboBox2.DataSource = (from q in context.Games select q).ToList();
            comboBox2.DisplayMember = "Name";
            comboBox3.DisplayMember = "Name";
            comboBox4.DataSource = (from p in context.Players select p).ToList();
            comboBox4.DisplayMember = "PNR";
            comboBox1.DataSource = (from q in context.Developers select q).ToList();
            comboBox1.DisplayMember = "name";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            comboBox4.SelectedItem = null;
        }

        private void ButtonGamesAdd_Click(object sender, EventArgs e)
        {
            string gameName = TBGamename.Text;
            string EAN = TBGamesEAN.Text;
            DateTime releaseDate = datetimeGamesReleasedate.Value;
            Game game = new Game();
            game.Name = gameName;
            game.EAN = EAN;
            game.Release_date = releaseDate;
            TBGamename.Clear();
            TBGamesEAN.Clear();
            context.Games.Add(game);
            context.SaveChanges();
            UpdateCombobox();
        }

        private void ButtonPlayersAdd_Click(object sender, EventArgs e)
        {
            string playerName = TBPlayersName.Text;
            string playerPNR = TBPlayersPNR.Text;
            Player player = new Player();
            player.Name = playerName;
            player.PNR = playerPNR;
            context.Players.Add(player);
            context.SaveChanges();
            UpdateCombobox();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Game theGame;
            string searchword = TBSearchWord.Text;
            var fråga = from games in context.Games
                        where games.EAN == searchword
                        select games;
            theGame = fråga.Single();
            if (theGame != null)
            {
                textBox1.Text = "Name: " + theGame.Name + " EAN: " + theGame.EAN + " Release date: " + theGame.Release_date;
            }
            else
            {
                MessageBox.Show("Finns ej");
            }
        }

        private void buttonDevelopAdd_Click(object sender, EventArgs e)
        {
            Developer developer = (Developer)comboBox1.SelectedItem;
            var q = from a in context.Developers
                    where a.Name == developer.Name
                    select a;

            q.Single().Games.Add((Game)comboBox2.SelectedItem);

            context.SaveChanges();
        }

        private void buttonPlayingAdd_Click(object sender, EventArgs e)
        {
            Player player = (Player)comboBox4.SelectedItem;
            var q = from a in context.Players
                    where a.PNR == player.PNR
                    select a;
            q.Single().Games.Add((Game)comboBox3.SelectedItem);
            context.SaveChanges();
        }
        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            foreach (var games in context.Games)
            {
                listBox1.Items.Add("Name:   " + games.Name + "  EAN: " + games.EAN + "    Release date: " + games.Release_date);
            }
            foreach (var dev in context.Developers)
            {
                listBox2.Items.Add(dev.Name + " from " + dev.Country);
            }
            foreach (var player in context.Players)
            {
                listBox3.Items.Add("Name:   " + player.Name+ "  Player PNR:  " + player.PNR);
            }
            foreach(var players in context.Players)
            {
                listBox4.Items.Add(players.Name + " plays " + players.Games);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            context.Games.Remove((Game)listBox1.SelectedItem);
        }
    }
}
