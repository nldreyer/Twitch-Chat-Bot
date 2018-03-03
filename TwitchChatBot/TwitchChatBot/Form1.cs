using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSendKeys = System.Windows.Forms.SendKeys;

namespace TwitchChatBot
{
    public partial class uxMainForm : Form
    {
        private static System.Timers.Timer t;

        private static System.Timers.Timer t2;

        public static int time;

        private static TextBox uxIntervalBox1;

        private static TextBox uxMessageBox;

        private static TextBox uxTimerBox;

        static string[] _heroes = { "OWLAna OWLAna OWLAna", "OWLBastion OWLBastion OWLBastion", "OWLDVa OWLDVa OWLDVa", "OWLDoomfist OWLDoomfist OWLDoomfist", "OWLGenji OWLGenji OWLGenji",
                                  "OWLHanzo OWLHanzo OWLHanzo", "OWLJunkrat OWLJunkrat OWLJunkrat", "OWLLucio OWLLucio OWLLucio", "OWLMcCree OWLMcCree OWLMcCree", "OWLMei OWLMei OWLMei",
                                  "OWLMercy OWLMercy OWLMercy", "OWLMoira OWLMoira OWLMoira", "OWLOrisa OWLOrisa OWLOrisa", "OWLPharah OWLPharah OWLPharah", "OWLReaper OWLReaper OWLReaper",
                                  "OWLReinhardt OWLReinhardt OWLReinhardt", "OWLRoadhog OWLRoadhog OWLRoadhog", "OWLSoldier76 OWLSoldier76 OWLSoldier76", "OWLSombra OWLSombra OWLSombra",
                                  "OWLSymmetra OWLSymmetra OWLSymmetra", "OWLTorbjorn OWLTorbjorn OWLTorbjorn", "OWLTracer OWLTracer OWLTracer", "OWLWidowmaker OWLWidowmaker OWLWidowmaker",
                                  "OWLWinston OWLWinston OWLWinston", "OWLZarya OWLZarya OWLZarya", "OWLZenyatta OWLZenyatta OWLZenyatta" };

        static string[] _teams = { "OWLBOS BOSTON UP OWLBOS", "OWLDAL BURN BLUE OWLDAL", "OWLHOU GREEN WALL OWLHOU", "OWLFLA BRING THE MAYHEM OWLFLA", "OWLGLA SHIELDS UP OWLGLA", "OWLLDN ACES HIGH OWLLDN",
                               "OWLNYE EXCELSIOR OWLNYE", "OWLPHI PDOMJNATE OWLPHI", "OWLSEO FLETA THE META OWLSEO", "OWLSFS SHOCKING OWLSFS", "OWLSHD FIGHTING FOR GLORY OWLSHD",
                               "OWLVAL WINGS OUT OWLVAL" };

        public uxMainForm()
        {
            InitializeComponent();

            InitializeImageLists();

            t = new System.Timers.Timer();

            t2 = new System.Timers.Timer();

            time = 0;

            t.Interval = 60000;
            t.Elapsed += OnTimedEvent;
            t.AutoReset = true;
            t.Enabled = false;

            t2.Interval = 1000;
            t2.Elapsed += OnTimedEvent2;    
            t2.Enabled = false;

            uxIntervalBox1 = uxIntervalBox;
            uxMessageBox = uxMessage;
            uxTimerBox = uxTimer;

            uxIntervalBox.Text = "Interval: " + Convert.ToString((int)(t.Interval / 1000));
            uxMessageBox.Text = "Last Message: ";
            uxTimerBox.Text = "Time Elapsed: ";

            TextBox.CheckForIllegalCrossThreadCalls = false;

        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            string[] messages = GetEmoteList();

            Random message = new Random();

            int m = message.Next(messages.Length);

            TSendKeys.SendWait(messages[m] + "{ENTER}");

            int newInterval = message.Next(120000, 300000); 

            t.Interval = newInterval;

            uxIntervalBox1.Text = "Interval: " + Convert.ToString((int)(t.Interval / 1000));

            uxMessageBox.Text = "Last Message: " + messages[m];

            time = 0;
        }

        private static void OnTimedEvent2(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (t.Enabled)
            {
                time++;
                uxTimerBox.Text = "Time Elapsed: " + Convert.ToString(time);
            }
            else
            {
                time = 0;
            }
        }

        private void uxOutputText_CheckedChanged(object sender, EventArgs e)
        {
            if (t.Enabled)
            {
                t.Enabled = false;
            }
            else
            {
                t.Enabled = true;
                t2.Enabled = true;
                t.Start();
                t2.Start();
            }
        }

        private void uxSendMessage_Click(object sender, EventArgs e)
        {
            uxSendMessage.Text = "Sending in 10 Seconds";
            uxSendMessage.Enabled = false;
            bool t2E = t2.Enabled;

            if (!t2E)
            {
                t2.Enabled = true;
                t2.Start();
            }

            while (time < 11)
            {
                uxTimerBox.Text = "Time Elapsed: " + Convert.ToString(time);
            }

            string[] messages = { "gg", "lol", "BibleThump", "Kappa", "PogChamp", "LUL", "nice", "FrankerZ", "OhMyDog", "FailFish", "DansGame" };

            Random message = new Random();

            int m = message.Next(messages.Length);

            TSendKeys.SendWait(messages[m] + "{ENTER}");

            uxMessageBox.Text = "Last Message: " + messages[m];

            if (!t2E)
            {
                t2.Enabled = false;
            }

            uxTimerBox.Text = "Time Elapsed: ";
            uxSendMessage.Text = "Send Message";

            uxSendMessage.Enabled = true;
        }

        private void uxMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            t2.Stop();
            t.Enabled = false;
            t2.Enabled = false;
        }

        private static string[] GetEmoteList()
        {
            string[] messageList = new string[38];

            foreach (string s in _heroes)
            {

            }

            return messageList;
        }

        private static void InitializeImageLists()
        {
            ImageList heroes = new ImageList();
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLAna.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLBastion.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLDoomfist.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLDVa.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLGenji.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLHanzo.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLJunkrat.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLLucio.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLMcCree.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLMei.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLMercy.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLMoira.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLOrisa.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLPharah.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLReaper.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLReinhardt.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLRoadhog.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLSoldier76.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLSombra.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLSymmetra.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLTorbjorn.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLTracer.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLWidowmaker.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLWinston.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLZarya.png"));
            heroes.Images.Add(Image.FromFile("TwitchChatBot/TwitchChatBot/Resources/Character_Images/OWLZenyatta.png"));
            ImageList teams = new ImageList();
        }
    }

    
}
