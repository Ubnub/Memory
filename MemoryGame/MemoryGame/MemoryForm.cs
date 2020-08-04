using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MemoryForm : Form
    {
        Thread th;
        Random rng = new Random();

        LogregDataContext db = new LogregDataContext();
        public string CurrentUser;


        // ALT LOCATIONS FOR ICONS if running from somewhere else.
        //Place Icons folder in c:\temp and set alt to 1
        private int alt = 0;

        #region AltIconLocations
        private string crystal2 = @"C:\temp\Icons\Crystal-Shard-icon.png";
        private string dragon2 = @"C:\temp\Icons\Monster-icon.png";
        private string potion2 = @"C:\temp\Icons\Potion-icon.png";
        private string witch2 = @"C:\temp\Icons\Sorceress-Witch-icon.png";
        private string book2 = @"C:\temp\Icons\Spell-Book-icon.png";
        private string sword2 = @"C:\temp\Icons\Sword-icon.png";
        private string unicorn2 = @"C:\temp\Icons\Unicorn-icon.png";
        private string wolf2 = @"C:\temp\Icons\Werewolf-icon.png";
        private string Default2 = @"C:\temp\Icons\quest.png";
        #endregion

        #region IconLocations
        private string crystal = @"C:\Users\arviu\Documents\GitHub\Memory\MemoryGame\MemoryGame\bin\Icons\Crystal-Shard-icon.png";
        private string dragon = @"C:\Users\arviu\Documents\GitHub\Memory\MemoryGame\MemoryGame\bin\Icons\Monster-icon.png";
        private string potion = @"C:\Users\arviu\Documents\GitHub\Memory\MemoryGame\MemoryGame\bin\Icons\Potion-icon.png";
        private string witch = @"C:\Users\arviu\Documents\GitHub\Memory\MemoryGame\MemoryGame\bin\Icons\Sorceress-Witch-icon.png";
        private string book = @"C:\Users\arviu\Documents\GitHub\Memory\MemoryGame\MemoryGame\bin\Icons\Spell-Book-icon.png";
        private string sword = @"C:\Users\arviu\Documents\GitHub\Memory\MemoryGame\MemoryGame\bin\Icons\Sword-icon.png";
        private string unicorn = @"C:\Users\arviu\Documents\GitHub\Memory\MemoryGame\MemoryGame\bin\Icons\Unicorn-icon.png";
        private string wolf = @"C:\Users\arviu\Documents\GitHub\Memory\MemoryGame\MemoryGame\bin\Icons\Werewolf-icon.png";
        private string Default = @"C:\Users\arviu\Documents\GitHub\Memory\MemoryGame\MemoryGame\bin\Icons\quest.png";
        #endregion

        #region PictureVariables
        private Dictionary<int, string> icons = new Dictionary<int, string>();
        private List<int> numbers=new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 };
        private List<int> shuffledimages=new List<int>() { };
        private List<PictureBox> pictureboxes=new List<PictureBox>();
        PictureBox First, Second;
        #endregion

        #region Integers(time/score)
        private static int timertime=60; //Game duration
        private static int pairs = 8; //Number of picture pairs
        private static int matches = 0; //How many succesfully matched
        private static int timeleft; //Gametime
        private static int Misses = 0; //Missed guesses
        private int yourscore;
        private int highscore;
        #endregion

        public MemoryForm(string user)
        {
            CurrentUser = user;
            InitializeComponent();
            ResetGame();
            ResetGame();
            if (alt == 1) 
            {
                icons.Add(1, crystal2);
                icons.Add(2, dragon2);
                icons.Add(3, potion2);
                icons.Add(4, witch2);
                icons.Add(5, book2);
                icons.Add(6, sword2);
                icons.Add(7, unicorn2);
                icons.Add(8, wolf2);
            }
            else
            {
                icons.Add(1, crystal);
                icons.Add(2, dragon);
                icons.Add(3, potion);
                icons.Add(4, witch);
                icons.Add(5, book);
                icons.Add(6, sword);
                icons.Add(7, unicorn);
                icons.Add(8, wolf);
            }
            GetScore();
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is PictureBox)
                {
                    pictureboxes.Add((PictureBox)tableLayoutPanel1.Controls[i]);
                }
            }
                                 
        }

        #region PictureStuff
        public void shuffleimages()
        {
            shuffledimages.Clear();
            List<int> images = new List<int>();
            foreach (var item in numbers)
            {
                images.Add(item);
            }
            for (int i = 0; i < numbers.Count(); i++)
            {
                int a = rng.Next(0, images.Count());
                shuffledimages.Add(images[a]);
                images.RemoveAt(a);
            }
        }

        public void showdefault(PictureBox a)
        {
            a.ImageLocation = Default;
        }
        public void showassigned(PictureBox a)
        {
            for (int i = 0; i < pictureboxes.Count(); i++)
            {
                if (a == pictureboxes[i])
                {
                    a.ImageLocation = icons[shuffledimages[i]];
                }
            }
        }
        public void checkifmatch(PictureBox a ,PictureBox b)
        {
            if (a.ImageLocation == b.ImageLocation)
            {
                a.Visible = false;
                b.Visible = false;
                matches++;
            }
            else
            {
                Misses++;
                showdefault(a);
                showdefault(b);
            }
        }
        #endregion

        #region TimerStuff
        public void updatetimerlabel()
        {
            int minutes = timeleft / 60;
            int seconds = timeleft % 60;
            string min, sec;
            min = minutes.ToString();
            sec = seconds.ToString();
            if (minutes < 10 && seconds < 10)
            {
                min = "0" + minutes.ToString();
                sec = "0" + seconds.ToString();
            }
            else if (minutes < 10)
                min = "0" + minutes.ToString();
            else if (seconds<10)
                sec = "0" + seconds.ToString();
            timerlabel.Text = min + ":" + sec;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            checkifmatch(First, Second);
            First = null;
            Second = null;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeleft--;
            updatetimerlabel();
            checkgame(matches, timeleft);
        }
        #endregion

        #region Buttons
        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(CloseMemory);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            ResetGame();
            tableLayoutPanel1.Visible = true;
            StopButton.Visible = true;
            StartButton.Visible = false;
            timer2.Start();

        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            ResetButton.Visible = true;

        }
        #endregion

        #region GameStuff
        private void checkgame(int matc,int time)
        {
            if (matc == 8 && time>0)
            {
                Victory();
            }
            else if (time == 0 && matc < 8)
            {
                Defeat();
            }
        }
        private void ResetGame()
        {
            tableLayoutPanel1.Visible = false;
            StopButton.Visible = false;
            ResetButton.Visible = false;
            StartButton.Visible = true;
            shuffleimages();
            timeleft = timertime;
            updatetimerlabel();
            matches = 0;
            Misses = 0;
            yourscore = 0;
            foreach (var item in pictureboxes)
            {
                showdefault(item);
                item.Visible = true;
            }

        }
        private void picturebox_Click(object sender, EventArgs e)
        {            
            if (First != null && Second != null)
                return;
            PictureBox clickedbox = sender as PictureBox;
            if (clickedbox == null)
                return;
            if (clickedbox.ImageLocation != Default)
                return;
            if (First == null)
            {
                First = clickedbox;
                showassigned(First);
                return;
            }
            Second = clickedbox;
            showassigned(Second);

            timer1.Start();
       
        }
        public void Victory()
        {
            timer2.Stop();
            CountScore();
            bool winwin=checkifhigher(yourscore, highscore);
            if (winwin)
                MessageBox.Show("Congratulation. You've won!\nYou beat your previous highscore!\nYour score: "+yourscore);
            else
                MessageBox.Show("Congratulation. You've won!\nYour score: " + yourscore + "\n\nYour highscore: " + highscore);
            ResetGame();
        }
        public void Defeat()
        {
            timer2.Stop();
            MessageBox.Show("You Died");
            ResetGame();
        }
        #endregion

        #region ScoreStuff

        public void CountScore()
        {
            if (Misses < 6)
                yourscore += 500;
            else if (Misses > 6)
                yourscore += 500 - (Misses - 6) * 20;

            if (timeleft > 30)
                yourscore += 100 + timeleft * 10;
            else
                yourscore += timeleft * 10;
        }
        public void GetScore()
        {
            // No clue why Score1. Maybe because had to add it twice.
            var scorequery = (from x in db.GetTable<Score>() where x.Username == CurrentUser select x.Score1).FirstOrDefault();
            if (scorequery != null)
                highscore = int.Parse(scorequery.ToString());
            else
                highscore = default(int);
        }
        public bool checkifhigher(int current,int old)
        {
            if (current > old)
            {
                Score newscore = (from x in db.Scores where x.Username == CurrentUser select x).FirstOrDefault();
                newscore.Score1 = current;
                db.SubmitChanges();
                highscore = current;
                return true;
            }

            else
                return false;
        }

        #endregion
        public void CloseMemory()
        {
            Application.Run(new Form1());
        }


    }
}
