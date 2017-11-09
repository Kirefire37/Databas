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
            Update();
        }

        private void ButtonDevelopersAdd_Click(object sender, EventArgs e)
        {
            foreach (var developer2 in context.Developers)
            {
                if (TBDevelopername.Text == developer2.Name)
                {
                    MessageBox.Show("It already exist a developer with this name");
                    return;
                }
                else if(TBDevelopername.Text == "")
                {
                    MessageBox.Show("There is no name");
                    return;
                }
                else
                {
                }
            }
            //Skapar en ny developer av klassen developer
            Developer developer = new Developer();
            //Ger värden till det nya objektet 
            developer.Name = TBDevelopername.Text;
            developer.Country = TBDeveloperCountry.Text;
            //Lägger till det nya objektet i databasen och sparar
            context.Developers.Add(developer);
            context.SaveChanges();
            UpdateCombobox();
            TBDevelopername.Clear();
            TBDeveloperCountry.Clear();
        }

        private void Update()
        {
            LBPlaying.Items.Clear();
            LBPDevelopedBy.Items.Clear();
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
            foreach (var developers in context.Developers)
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
        private void UpdateCombobox()
        {
            //Får combobox:arna att visa objekten i databasen
            comboBox3.DataSource = (from q in context.Games select q).ToList();
            comboBox2.DataSource = (from q in context.Games select q).ToList();
            comboBox2.DisplayMember = "Name";
            comboBox3.DisplayMember = "Name";
            comboBox4.DataSource = (from q in context.Players select q).ToList();
            comboBox4.DisplayMember = "PNR";
            comboBox1.DataSource = (from q in context.Developers select q).ToList();
            comboBox1.DisplayMember = "Name";
            //Combobox:arna har inget skrivet i dem från början
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            comboBox4.SelectedItem = null;
        }

        private void ButtonGamesAdd_Click(object sender, EventArgs e)
        {
            foreach (var games in context.Games)
            {
                if(TBGamesEAN.Text == games.EAN)
                {
                    MessageBox.Show("It already exists a game with this number as an EAN");
                    return;
                }
                else if(TBGamename.Text == "" || TBGamesEAN.Text == "")
                {
                    MessageBox.Show("There is no name or no EAN.");
                    return;
                }
                else
                {
                }
            }
            //Skapar ett "game" av klassen Game
            Game game = new Game();
            //Ger objektet värden
            game.Name = TBGamename.Text;
            game.EAN = TBGamesEAN.Text;
            game.Release_date = datetimeGamesReleasedate.Value;
            //Lägger till objektet i databasen och sparar
            context.Games.Add(game);
            context.SaveChanges();
            UpdateCombobox();
            TBGamename.Clear();
            TBGamesEAN.Clear();
        }

        private void ButtonPlayersAdd_Click(object sender, EventArgs e)
        {
            //Kollar om personnummret man skrev in i textboxen redan finns i databasen
            foreach (var player2 in context.Players)
            {
                if (TBPlayersPNR.Text == player2.PNR)
                {
                    MessageBox.Show("A person with this personal identity number does already exist");
                    return;
                }

                else if(TBPlayersPNR.Text == "" || TBPlayersName.Text == "")
                {
                    MessageBox.Show("There is no name or no EAN");
                    return;
                }
                else if(TBPlayersPNR.TextLength != 10)
                {
                    MessageBox.Show("There must be 10 digits.");
                    return;
                }
                else
                {
                }
            }
            //Skapar en "player" av klassen Player
            //Ger objektet värden
            Player player = new Player();
            player.Name = TBPlayersName.Text;
            player.PNR = TBPlayersPNR.Text;
            context.Players.Add(player);
            context.SaveChanges();
            UpdateCombobox();
            TBPlayersName.Clear();
            TBPlayersPNR.Clear();
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
                MessageBox.Show("Doesn't exist");
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
            //Lägger till var q i databasen
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
            //Skriver ut all data i databasen i listor
            foreach (var games in context.Games)
            {
                LBGames.Items.Add("Name:   " + games.Name + "  EAN: " + games.EAN + "    Release date: " + games.Release_date);
            }
            foreach (var dev in context.Developers)
            {
                if (dev.Country != "")
                {
                    LBDevelopers.Items.Add(dev.Name + " from " + dev.Country);
                }
                else
                {
                    LBDevelopers.Items.Add(dev.Name);
                }
            }
            foreach (var player in context.Players)
            {
                LBPlayers.Items.Add("Name:   " + player.Name+ "  Player PNR:  " + player.PNR);
            }
            Update();
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
            Update();
            TBSearchWord.Clear();
        }
    }
}
