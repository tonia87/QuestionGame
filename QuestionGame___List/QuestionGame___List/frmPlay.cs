using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuestionGame___List
{
    public partial class frmPlay : Form
    {
        //known to frmPlay
        List<Query> userList = new List<Query>();
        static int j = 30;//TIMER REVERSE COUNTER
        int helpCounter=3;
        int maxlist;
        int userScore=0;
        int userType;
        int userDifficulty;
        Query current = null; //new Query(0,0,0,0,0,null,null,null,null,null,null);
        Query exchangeTemp = null;
       
        string resourcesPath = System.IO.Directory.GetParent(Application.StartupPath).Parent.FullName + @"\Resources";
        

        public frmPlay()
        {
            InitializeComponent();
            pgb.Minimum = 0;
            pgb.Maximum = 1000;
            pgb.Step = 50;
        }


        //frmPlay load
        private void frmPlay_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Image.FromFile(resourcesPath + @"\" + "background.jpg");
            pbxTimer.BackColor = Color.Black;
           //pbxTimer.ImageAlign = ImageLayout.Stretch ;
            pbxTimer.Image  = Image.FromFile(resourcesPath + @"\" + "roundclock.gif");
          
            ListLoad();
            maxlist = userList.Count;
            SetNewGame();
        }

        //set new game
        private void SetNewGame()
        {

            cbxDifficulty.Items.Clear();
            cbxDifficulty.Items.Add("ΕΥΚΟΛΟ");
            cbxDifficulty.Items.Add("ΜΕΣΑΙΟ");
            cbxDifficulty.Items.Add("ΔΥΣΚΟΛΟ");
            cbxDifficulty.SelectedIndex = 0;


            cbxType.Items.Clear();
            cbxType.Items.Add("ΓΕΝΙΚΕΣ");
            cbxType.Items.Add("ΘΡΗΣΚΕΥΤΙΚΕΣ");
            cbxType.Items.Add("ΙΣΤΟΡΙΚΕΣ");
            cbxType.SelectedIndex = 0;

            btn1.Text = "Α. ";
            btn2.Text = "B. ";
            btn3.Text = "Γ. ";
            btn4.Text = "Δ. ";

            btnHelp.Text = "Hint (3)";
            UnlockStatus();
            userScore  = 0;
            PrintResultsDefault();
        }
        //print default score and message
        private void PrintResultsDefault()
        {
            lblScore.Text = "Βαθμοί ερώτησης: 0";
            lblTotal.Text = "Συνολικό σκορ: " + userScore.ToString();
            lblQuote.Text = "Καμία τρέχουσα ερώτηση";
            lblMessage.Text = "Έτοιμο...";

        }
        //load query list
        public void ListLoad()
        {
            userList.Clear();
            DeserializeListed();
            //userList.Add(new Query(1, 0, 1, 1, 50, "Πόσες ημέρες έχει η εβδομάδα;", 4, "2", "32", "5", "7"));
            //userList.Add(new Query(2, 0, 2, 1, 100, "Τι ζώδιο είναι κάποιος που έχει γεννηθεί στις 30/10;", 1, "Σκορπιός", "Αιγόκερως", "Κριός", "Ταύρος"));
            //userList.Add(new Query(3, 0, 1, 2, 50, "Πόσες εβδομάδες διαρκεί η Σαρακοστή;", 2, "2", "7", "8", "10"));
            //userList.Add(new Query(4, 0, 1, 2, 50, "Πού γεννήθηκε ο Ιησούς σύμφωνα με τη θρησκευτική παράδοση;", 3, "Μέκκα", "Ναζαρέτ", "Βηθλεέμ", "Αθήνα"));
            //userList.Add(new Query(5, 0, 2, 1, 100, "Πόσες ώρες έχει ένα ημερονύκτιο;", 1, "24 1/4", "24", "28", "26"));
            //userList.Add(new Query(6, 0, 2, 3, 100, "Πότε έγινε η Γαλλική Επανάσταση;", 2, "1875", "1789", "2000", "1940"));
            //userList.Add(new Query(7, 0, 3, 3, 150, "Πότε ιδρύθηκε το κίνημα των Νεοτούρκων;", 4, "1940", "1831", "1750", "1908"));
            //userList.Add(new Query(8, 0, 2, 1, 100, "Ποια χρώματα αναμειγνύονται για τη δημιουργία του πράσινου χρώματος;", 1, "Μπλε με κίτρινο", "Ροζ με κίτρινο", "Άσπρο με κίτρινο", "Γκρι με κίτρινο"));
            //userList.Add(new Query(9, 0, 1, 3, 50, "Πότε έγινε η Έξοδος του Μεσολογγίου;", 3, "1900", "2015", "1821", "1453"));
            //userList.Add(new Query(10, 0, 2, 3, 100, "Πότε έγινε η Αμερικανική Eπανάσταση;", 2, "3000", "1776", "Ποτέ", "1940"));
            //userList.Add(new Query(11, 0, 2, 1, 100, "Από ποιό σπόρο παρασκευάζεται το ταχίνι", 1, "Σησάμι", "Παπαρούνα", "Ηλιόσπορο", "Σινάπι"));
        }



        //check difficulty/type
        private void CheckUserChoice()
        {
            if (cbxDifficulty.SelectedIndex == 0)
            {
                userDifficulty = 1;
            }
            else if (cbxDifficulty.SelectedIndex==1)
            {
                userDifficulty = 2;
            }
            else
            {
                userDifficulty = 3;
            }

            if (cbxType.SelectedIndex==0)
            {
                userType = 1;
            }
            else if (cbxType.SelectedIndex==1)
            {
                userType = 2;
            }
            else
            {
                userType = 3;
            }
        }

        //lock game status
        private void LockStatus()
        {
            cbxType.Enabled = false;
            cbxDifficulty.Enabled = false;
            lblQuote.Enabled = true;

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;

            if (helpCounter > 0) { btnHelp.Enabled = true; }
            else
            {
                btnHelp.Enabled = true;
                btnHelp.Text = "No Hints Left";
            }
            CheckUserChoice();
        }
        //unlock game status
        private void UnlockStatus()
        {
            cbxDifficulty.Enabled = true;
            cbxType.Enabled = true;
            userType  = 0;
            userDifficulty  = 0;
            //stop timer when cbx enabled--question answered or next question awaits before screen
            tmrGame.Stop();

            lblQuote.Enabled = false;

            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;

            btnHelp.Enabled = false;
        }
        //button next question
        private void btnGetNext_Click(object sender, EventArgs e)
        {
            
            LockStatus();
            if (current == null)
            {
                GetNextNotPlayed(0);
            }
            else
            {
                //current.Played = 0;
                //userList.Remove(current);
                //userList.Add(current);
                exchangeTemp = current;
                //userList.Remove(exchangeTemp);
                //userList.m
                
                GetNextNotPlayed(0);

            }

        }

        private void GetNextNotPlayed(int k)
        {
            int i;
            maxlist = userList.Count;
            for ( i = 0; i < maxlist; i++)
            {
                //IF SHOWN OR NOT::NEVER ANSWERED
                if ((userList [i+k].played <=1) && (userList [i+k].type == userType) && (userList [i+k].difficulty == userDifficulty))
                {
                    
                    //userList[i].Played = 1;-->>DO IN SHOW_ON_SCREEN
                    //SECOND CHANGE::private QUERY ShowOnScreen 
                    //to return played changed status for current
                 current = ShowOnScreen(userList[i + k]);
                    //userList.Add(exchangeTemp);
                    //maxlist = userList.Count;
                    //userList[i] = current;
                    break;
                }
                else
                {
                    current = null;
                    
                    ShowOnScreen(new Query(80,3,3,3,3,"",0,"","","",""));
                }

            }
            if (i == maxlist)
            {
                
                if (current == null)
                {
                    lblMessage.Text = "ΤΕΛΟΣ ΕΡΩΤΗΣΕΩΝ";
                    MessageBox.Show("Δεν υπάρχουν διαθέσιμες ερωτησεις!");
                    PrintResults();
                }
            }
            
        }

        //print final results when no question available
        private void PrintResults()
        {
            UnlockStatus();
            lblScore.Text = "Βαθμοί ερώτησης: -";
            lblTotal.Text = "Συνολικό σκορ: " + userScore.ToString();
            lblQuote.Text = "Καμία τρέχουσα ερώτηση";
            lblMessage.Text = "Ολοκληρώθηκε";
            lblTimer.Text = ":30";

            btn1.Text = "Α. ";
            btn2.Text = "B. ";
            btn3.Text = "Γ. ";
            btn4.Text = "Δ. ";

        }
        //show question on screen and buttons
        private Query  ShowOnScreen(Query q)
        {
            //CHANGE SHOWN PROPERTY
            q.played = 1;

            lblQuote.Text = q.quote;
            lblScore.Text = "Βαθμοί ερώτησης: " + q.degrees;
            lblMessage.Text = "Αναμονή για απάντηση...";


            btn1.Text = "Α. "+q.answer[1];
            btn2.Text = "Β. "+q.answer[2];
            btn3.Text = "Γ. "+q.answer[3];
            btn4.Text = "Δ. "+q.answer[4];
            tmrGame.Enabled = true;
            tmrGame.Start();
            return q;
        }

        private string getCorrect(Query q, int c)
        {
            return q.answer[c];
        }
        //check button click //wmp response according to q.answer[0]::correct
        private void AnswerMatch(int buttonNumber,string b)
        {
            string msg="";
            
            if (current.answer[0]==buttonNumber.ToString())
            {
                wmpGameResponse.URL = resourcesPath + @"\" + "Applause sound effect.mp3";
                wmpGameResponse.BeginInit();
                msg = "Συγχαρητήρια! Η σωστή απάντηση ήταν το : " + b+ getCorrect(current,Convert.ToInt16( current.answer[0])) ;
                userScore += current.degrees;
                RaiseAccordingly(current.degrees);

            }
            else
            {
                wmpGameResponse.URL = resourcesPath + @"\" + "Wrong Buzzer - Sound Effect.mp3";
                wmpGameResponse.BeginInit();
                msg = "Λάθος απάντηση... Η σωστή απάντηση ήταν το : " + getCorrect(current, Convert.ToInt16(current.answer[0]));
            }
            lblMessage.Text = msg;
            lblTotal.Text="Συνολικό σκορ: "+userScore;
            UnlockStatus();
            //REMOVE WHEN ANSWERED!!!!!!
            if (userList.Contains(current)) 
            {
                userList.Remove(current);
            }
            j = 30;
            lblTimer.Text = ":30";

        }
        //raise progress bar
        private void RaiseAccordingly(int x)
        {
            int a = x / 50;
            for (int k = 0; k < a;k++ )
            {
                pgb.PerformStep();
            }

        }

        //clicks and checks btn1/2/3/4
        private void btn1_Click(object sender, EventArgs e)
        {
            UnlockStatus();
            AnswerMatch(1,"Α. ");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            UnlockStatus(); 
            AnswerMatch(2,"Β. ");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            UnlockStatus(); 
            AnswerMatch(3,"Γ. ");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            UnlockStatus();
            AnswerMatch(4,"Δ. ");
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            DateTime d=Convert.ToDateTime("00:00:"+j);
            if (j > 0)
            {
                try
                {
                    lblTimer.Text = d.ToString(":ss");
                    j--;
                    //keep counting down
                }
                catch
                {
                    MessageBox.Show("Error Starting Timer");
                }
            }
            else
            {
                tmrGame.Stop();
                 j = 30;
                 //show wrong answer
                AnswerMatch(0,"");
            }
            
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Button t=new Button ();
            

            if (helpCounter >0 ) { 
            wmpGameResponse.URL = resourcesPath + @"\" + "I Know You're Gonna Dig This.mp3";
            wmpGameResponse.BeginInit();
            t.Text  = "Α. "+current.answer[0];
            //show correct answer & win 
            AnswerMatch(Convert.ToInt16(current.answer[0]),"");
            helpCounter--;
            btnHelp.Text = "Hint (" + helpCounter.ToString() + ")";
            }
            else
            {
                btnHelp.Enabled = true;
                btnHelp.Text = "No Hints Left";
                //btnHelp.BackColor = Color.Plum;
                //btnHelp.ForeColor = Color.Silver ;
                
            }
        }

        private void frmPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void DeserializeListed()
        {
            string jsonOb = "";
            try
            {
                jsonOb = System.IO.File.ReadAllText(Application.StartupPath + @"\userList.json");
                userList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Query>>(jsonOb);
            }
            catch
            {
                MessageBox.Show("Failed to load query list");
            }
        }
    }

    //public class wrapList
    //{
    //    public List<Query> x
    //    { get;set;}
    //}
}
