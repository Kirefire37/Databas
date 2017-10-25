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
            //Skapar en ny developer av klassen developer
            developer.Name = developerName;
            developer.Country = developerCountry;
            //Ger värden till det nya objektet 
            context.Developers.Add(developer);
            context.SaveChanges();
            //Lägger till det nya objektet i databasen och sparar
            UpdateCombobox();
        }

        private void UpdateCombobox()
        {
            //Får combobox:arna att visa objekten i databasen
            comboBox3.DataSource = (from q in context.Games select q).ToList();
            comboBox2.DataSource = (from q in context.Games select q).ToList();
            comboBox2.DisplayMember = "Name";
            comboBox3.DisplayMember = "Name";
            comboBox4.DataSource = (from p in context.Players select p).ToList();
            comboBox4.DisplayMember = "PNR";
            comboBox1.DataSource = (from q in context.Developers select q).ToList();
            comboBox1.DisplayMember = "name";
            //Combobox:arna har inget skrivet i dem från början
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
            //Skapar ett "game" av klassen Game
            game.Name = gameName;
            game.EAN = EAN;
            game.Release_date = releaseDate;
            //Ger objektet värden
            TBGamename.Clear();
            TBGamesEAN.Clear();
            context.Games.Add(game);
            context.SaveChanges();
            //Lägger till objektet i databasen och sparar
            UpdateCombobox();
        }

        private void ButtonPlayersAdd_Click(object sender, EventArgs e)
        {
            string playerName = TBPlayersName.Text;
            string playerPNR = TBPlayersPNR.Text;
            Player player = new Player();
            //Skapar en "player" av klassen Player
            player.Name = playerName;
            player.PNR = playerPNR;
            //Ger objektet värden
            context.Players.Add(player);
            context.SaveChanges();
            //Lägger till objektet i databasen och sparar
            UpdateCombobox();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Game theGame;
            string searchword = TBSearchWord.Text;
            //Frågar databasen om det finns något objekt som har samma EAN som searchword och ger isåfall det värdet till thegame
            var question = from game in context.Games
                        where game.EAN == searchword
                        select game;
            theGame = question.FirstOrDefault();
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
            //Kopplar en "developer" till ett "game"
            Developer developer = (Developer)comboBox1.SelectedItem;
            var q = from a in context.Developers
                    where a.Name == developer.Name
                    select a;
            q.First().Games.Add((Game)comboBox2.SelectedItem);
            //Sparar databasen
            context.SaveChanges();
            LBPDevelopedBy.Items.Clear();
            foreach(var developers in context.Developers)
            {
                if (developers.Games.Count > 0)
                {
                    string developedByString = developers.Name + " developed ";
                    foreach (var games in developers.Games)
                    {
                        developedByString += games.Name + ", ";
                    }
                    LBPDevelopedBy.Items.Add(developedByString);
                }
                else
                {
                    LBPDevelopedBy.Items.Add(developers.Name + " developed nothing.");
                }
            }
        }

        private void buttonPlayingAdd_Click(object sender, EventArgs e)
        {
            Player player = (Player)comboBox4.SelectedItem;
            //Frågar databasen om det finns något PNR som matchar players.PNR och väljer då det det objektet som matchar player.PNR
            var q = from a in context.Players
                    where a.PNR == player.PNR
                    select a;
            q.First().Games.Add((Game)comboBox3.SelectedItem);
            context.SaveChanges();
            LBPlaying.Items.Clear();
            foreach (var players in context.Players)
            {
                if (players.Games.Count > 0)
                {
                    string playingString = players.Name + " plays ";
                    foreach (var games in players.Games)
                    {
                        playingString += games.Name + ", ";
                    }
                    LBPlaying.Items.Add(playingString);
                }
                else
                {
                    LBPlaying.Items.Add(players.Name + " plays nothing");
                }
            }
        }
        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            LBGames.Items.Clear();
            LBDevelopers.Items.Clear();
            LBPlayers.Items.Clear();
            LBPlaying.Items.Clear();
            LBPDevelopedBy.Items.Clear();
            //Skriver ut all data i databasen i listor
            foreach (var games in context.Games)
            {
                LBGames.Items.Add("Name:   " + games.Name + "  EAN: " + games.EAN + "    Release date: " + games.Release_date);
            }
            foreach (var dev in context.Developers)
            {
                LBDevelopers.Items.Add(dev.Name + " from " + dev.Country);
            }
            foreach (var player in context.Players)
            {
                LBPlayers.Items.Add("Name:   " + player.Name+ "  Player PNR:  " + player.PNR);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string remove = TBSearchWord.Text;
            Game gameRemoved;
            var question = from game in context.Games
                        where game.EAN == remove
                        select game;
            //Frågar databasen om det finns något objekt som har samma EAN som värdet i remove
            gameRemoved = question.FirstOrDefault();

            if(gameRemoved != null)
            {
                context.Games.Remove(gameRemoved);
                context.SaveChanges();
                UpdateCombobox();
                TBSearchWord.Clear();
            }
            else
            {
                MessageBox.Show("The game doesn't exist");
                TBSearchWord.Clear();
            }
        }
    }
}
