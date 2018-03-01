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

        public uxMainForm()
        {
            InitializeComponent();

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
            string[] messages = { "gg", "lol", "BibleThump", "Kappa", "PogChamp", "LUL", "nice", "FrankerZ", "OhMyDog", "FailFish", "DansGame" };

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
            time++;
            uxTimerBox.Text = "Time Elapsed: " + Convert.ToString(time);
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
    }

    
}
